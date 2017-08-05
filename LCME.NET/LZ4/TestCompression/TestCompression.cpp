// TestCompression.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"



void *GetFileBuffer(PTCHAR lpPath, LPDWORD lpSize)
{
  HANDLE hFile;
  LPVOID lpBuffer;
  DWORD dwSize;

  hFile = CreateFile(lpPath, GENERIC_READ, FILE_SHARE_READ, NULL, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, NULL);

  if (hFile == INVALID_HANDLE_VALUE)
    return NULL;

  dwSize = GetFileSize(hFile, NULL);

  if (dwSize == 0)
  {
    CloseHandle(hFile);
    return NULL;
  }

  lpBuffer = malloc(dwSize);

  SetFilePointer(hFile, 0, NULL, FILE_BEGIN);

  if (!ReadFile(hFile, lpBuffer, dwSize, lpSize, NULL))
  {
    free(lpBuffer);
    CloseHandle(hFile);
    return NULL;
  }

  CloseHandle(hFile);
  return lpBuffer;
}

int _tmain(int argc, _TCHAR* argv[])
{
  LPVOID lpFile, lpOutput, lpTemp, lpWorkMem;
  HANDLE hTimer;
  DWORD dwSize, dwDiff, dwMaxLen, dwTemp;
  snappy_status ss;
  int zret;

  /*
    lpFile      原始文件数据流
    lpOutput    压缩后的数据流
    lpTemp      解压后的数据流
    lpWorkMem   aPLib使用的工作内存
  */

  if (argc < 2)
  {
    printf("请输入要测试的文件路径!\n");
    getchar();
    return 0;
  }

  lpFile = GetFileBuffer(argv[1], &dwSize);

  if (lpFile == NULL)
  {
    printf("获取文件数据失败![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  hTimer = timer_Create();

  if (hTimer == NULL)
  {
    free(lpFile);
    printf("创建定时器失败![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  printf("已读取文件大小:%u Bytes, %u KBs\n\n", dwSize, dwSize / 1024);

  lpTemp = malloc(dwSize + 32);

  if (lpTemp == NULL)
  {
    free(lpFile);
    free(lpTemp);

    printf("申请缓冲区失败![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  //aPLib
  dwMaxLen = aP_max_packed_size(dwSize);
  dwTemp = aP_workmem_size(dwSize);
  lpOutput = malloc(dwMaxLen);

  if (lpOutput == NULL)
  {
    free(lpFile);
    free(lpTemp);

    printf("申请输出缓冲区失败![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  lpWorkMem = malloc(dwTemp);

  if (lpWorkMem)
  {
    printf("准备使用aplib压缩!\n");
    printf("aplib预计压缩后最大长度:%u Bytes\n", dwMaxLen);
    printf("aplib预计工作内存大小:%u Bytes\n", dwTemp);

    timer_Begin(hTimer);
    dwTemp = aPsafe_pack(lpFile, lpOutput, dwSize, lpWorkMem, NULL, NULL);
    dwDiff = timer_CurrentDiff_us32(hTimer);

    free(lpWorkMem);
    printf("aplib压缩后的大小:%d Bytes,比率:%lf%%,用时:%u us!\n", dwTemp, (double)dwTemp * 100.0f / (double)dwSize, dwDiff);

    timer_Begin(hTimer);
    dwTemp = aPsafe_depack(lpOutput, dwTemp, lpTemp, dwSize + 32);
    dwDiff = timer_CurrentDiff_us32(hTimer);
    
    printf("aplib解压后的大小:%d Bytes,用时:%u us!\n\n", dwTemp, dwDiff);
  }
  else
    printf("为aplib申请工作内存失败,跳过aplib!\n\n");

  //LZ4
  dwMaxLen = LZ4_compressBound(dwSize);
  printf("准备使用lz4压缩!\n");
  printf("lz4预计压缩后最大长度:%u Bytes\n", dwMaxLen);
  lpOutput = realloc(lpOutput, dwMaxLen);

  if (lpOutput == NULL)
  {
    free(lpFile);
    free(lpTemp);

    printf("申请输出缓冲区失败![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  timer_Begin(hTimer);
  dwTemp = LZ4_compress((const char *)lpFile, (char *)lpOutput, dwSize);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("lz4压缩后的大小:%d Bytes,比率:%lf%%,用时:%u us!\n", dwTemp, (double)dwTemp * 100.0f / (double)dwSize, dwDiff);

  timer_Begin(hTimer);
  dwTemp = LZ4_decompress_safe((const char *)lpOutput, (char *)lpTemp, dwTemp, dwSize + 32);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("lz4解压后的大小:%d Bytes,用时:%u us!\n\n", dwTemp, dwDiff);

  //snappy
  dwMaxLen = snappy_max_compressed_length(dwSize);
  printf("准备使用snappy压缩!\n");
  printf("snappy预计压缩后最大长度:%u Bytes\n", dwMaxLen);
  lpOutput = realloc(lpOutput, dwMaxLen);

  if (lpOutput == NULL)
  {
    free(lpFile);
    free(lpTemp);

    printf("申请输出缓冲区失败![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  dwTemp = dwMaxLen;
  timer_Begin(hTimer);
  ss = snappy_compress((const char *)lpFile, dwSize, (char *)lpOutput, (size_t *)&dwTemp);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("snappy返回值:%d\n", ss);
  printf("snappy压缩后的大小:%d Bytes,比率:%lf%%,用时:%u us!\n", dwTemp, (double)dwTemp * 100.0f / (double)dwSize, dwDiff);

  dwMaxLen = dwSize + 32;
  timer_Begin(hTimer);
  ss = snappy_uncompress((const char *)lpOutput, dwTemp, (char *)lpTemp, (size_t *)&dwMaxLen);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("snappy返回值:%d\n", ss);
  printf("snappy解压后的大小:%d Bytes,用时:%u us!\n\n", dwMaxLen, dwDiff);

  //zlib
  dwMaxLen = compressBound(dwSize);
  printf("准备使用zlib压缩!\n");
  printf("zlib预计压缩后最大长度:%u Bytes\n", dwMaxLen);
  lpOutput = realloc(lpOutput, dwMaxLen);

  if (lpOutput == NULL)
  {
    free(lpFile);
    free(lpTemp);

    printf("申请输出缓冲区失败![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  timer_Begin(hTimer);
  zret = compress((Bytef *)lpOutput, &dwMaxLen, (const Bytef *)lpFile, dwSize);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("zlib返回值:%d\n", zret);
  printf("zlib压缩后的大小:%d Bytes,比率:%lf%%,用时:%u us!\n", dwMaxLen, (double)dwMaxLen * 100.0f / (double)dwSize, dwDiff);

  dwTemp = dwSize + 32;
  timer_Begin(hTimer);
  zret = uncompress((Bytef *)lpTemp, &dwTemp, (const Bytef *)lpOutput, dwMaxLen);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("zlib返回值:%d\n", zret);
  printf("zlib解压后的大小:%d Bytes,用时:%u us!\n\n", dwTemp, dwDiff);

  free(lpFile);
  free(lpOutput);
  free(lpTemp);

  getchar();
	return 1;
}

