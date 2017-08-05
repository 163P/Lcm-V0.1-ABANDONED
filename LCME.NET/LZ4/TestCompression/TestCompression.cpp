// TestCompression.cpp : �������̨Ӧ�ó������ڵ㡣
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
    lpFile      ԭʼ�ļ�������
    lpOutput    ѹ�����������
    lpTemp      ��ѹ���������
    lpWorkMem   aPLibʹ�õĹ����ڴ�
  */

  if (argc < 2)
  {
    printf("������Ҫ���Ե��ļ�·��!\n");
    getchar();
    return 0;
  }

  lpFile = GetFileBuffer(argv[1], &dwSize);

  if (lpFile == NULL)
  {
    printf("��ȡ�ļ�����ʧ��![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  hTimer = timer_Create();

  if (hTimer == NULL)
  {
    free(lpFile);
    printf("������ʱ��ʧ��![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  printf("�Ѷ�ȡ�ļ���С:%u Bytes, %u KBs\n\n", dwSize, dwSize / 1024);

  lpTemp = malloc(dwSize + 32);

  if (lpTemp == NULL)
  {
    free(lpFile);
    free(lpTemp);

    printf("���뻺����ʧ��![%u]\n", GetLastError());
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

    printf("�������������ʧ��![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  lpWorkMem = malloc(dwTemp);

  if (lpWorkMem)
  {
    printf("׼��ʹ��aplibѹ��!\n");
    printf("aplibԤ��ѹ������󳤶�:%u Bytes\n", dwMaxLen);
    printf("aplibԤ�ƹ����ڴ��С:%u Bytes\n", dwTemp);

    timer_Begin(hTimer);
    dwTemp = aPsafe_pack(lpFile, lpOutput, dwSize, lpWorkMem, NULL, NULL);
    dwDiff = timer_CurrentDiff_us32(hTimer);

    free(lpWorkMem);
    printf("aplibѹ����Ĵ�С:%d Bytes,����:%lf%%,��ʱ:%u us!\n", dwTemp, (double)dwTemp * 100.0f / (double)dwSize, dwDiff);

    timer_Begin(hTimer);
    dwTemp = aPsafe_depack(lpOutput, dwTemp, lpTemp, dwSize + 32);
    dwDiff = timer_CurrentDiff_us32(hTimer);
    
    printf("aplib��ѹ��Ĵ�С:%d Bytes,��ʱ:%u us!\n\n", dwTemp, dwDiff);
  }
  else
    printf("Ϊaplib���빤���ڴ�ʧ��,����aplib!\n\n");

  //LZ4
  dwMaxLen = LZ4_compressBound(dwSize);
  printf("׼��ʹ��lz4ѹ��!\n");
  printf("lz4Ԥ��ѹ������󳤶�:%u Bytes\n", dwMaxLen);
  lpOutput = realloc(lpOutput, dwMaxLen);

  if (lpOutput == NULL)
  {
    free(lpFile);
    free(lpTemp);

    printf("�������������ʧ��![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  timer_Begin(hTimer);
  dwTemp = LZ4_compress((const char *)lpFile, (char *)lpOutput, dwSize);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("lz4ѹ����Ĵ�С:%d Bytes,����:%lf%%,��ʱ:%u us!\n", dwTemp, (double)dwTemp * 100.0f / (double)dwSize, dwDiff);

  timer_Begin(hTimer);
  dwTemp = LZ4_decompress_safe((const char *)lpOutput, (char *)lpTemp, dwTemp, dwSize + 32);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("lz4��ѹ��Ĵ�С:%d Bytes,��ʱ:%u us!\n\n", dwTemp, dwDiff);

  //snappy
  dwMaxLen = snappy_max_compressed_length(dwSize);
  printf("׼��ʹ��snappyѹ��!\n");
  printf("snappyԤ��ѹ������󳤶�:%u Bytes\n", dwMaxLen);
  lpOutput = realloc(lpOutput, dwMaxLen);

  if (lpOutput == NULL)
  {
    free(lpFile);
    free(lpTemp);

    printf("�������������ʧ��![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  dwTemp = dwMaxLen;
  timer_Begin(hTimer);
  ss = snappy_compress((const char *)lpFile, dwSize, (char *)lpOutput, (size_t *)&dwTemp);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("snappy����ֵ:%d\n", ss);
  printf("snappyѹ����Ĵ�С:%d Bytes,����:%lf%%,��ʱ:%u us!\n", dwTemp, (double)dwTemp * 100.0f / (double)dwSize, dwDiff);

  dwMaxLen = dwSize + 32;
  timer_Begin(hTimer);
  ss = snappy_uncompress((const char *)lpOutput, dwTemp, (char *)lpTemp, (size_t *)&dwMaxLen);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("snappy����ֵ:%d\n", ss);
  printf("snappy��ѹ��Ĵ�С:%d Bytes,��ʱ:%u us!\n\n", dwMaxLen, dwDiff);

  //zlib
  dwMaxLen = compressBound(dwSize);
  printf("׼��ʹ��zlibѹ��!\n");
  printf("zlibԤ��ѹ������󳤶�:%u Bytes\n", dwMaxLen);
  lpOutput = realloc(lpOutput, dwMaxLen);

  if (lpOutput == NULL)
  {
    free(lpFile);
    free(lpTemp);

    printf("�������������ʧ��![%u]\n", GetLastError());
    getchar();
    return 0;
  }

  timer_Begin(hTimer);
  zret = compress((Bytef *)lpOutput, &dwMaxLen, (const Bytef *)lpFile, dwSize);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("zlib����ֵ:%d\n", zret);
  printf("zlibѹ����Ĵ�С:%d Bytes,����:%lf%%,��ʱ:%u us!\n", dwMaxLen, (double)dwMaxLen * 100.0f / (double)dwSize, dwDiff);

  dwTemp = dwSize + 32;
  timer_Begin(hTimer);
  zret = uncompress((Bytef *)lpTemp, &dwTemp, (const Bytef *)lpOutput, dwMaxLen);
  dwDiff = timer_CurrentDiff_us32(hTimer);

  printf("zlib����ֵ:%d\n", zret);
  printf("zlib��ѹ��Ĵ�С:%d Bytes,��ʱ:%u us!\n\n", dwTemp, dwDiff);

  free(lpFile);
  free(lpOutput);
  free(lpTemp);

  getchar();
	return 1;
}

