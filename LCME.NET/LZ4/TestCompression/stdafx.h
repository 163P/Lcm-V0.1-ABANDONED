#pragma once

#include "targetver.h"

#ifdef _WIN32_WINNT
#undef _WIN32_WINNT
#endif

#define _WIN32_WINNT _WIN32_WINNT_WINXP

#include <stdio.h>
#include <stdint.h>
#include <Windows.h>
#include <tchar.h>

#include "timer.hpp"

#define ZLIB_WINAPI       1

// aPLib 1.1.1
#include "../aplib/lib/coff/aplib.h"
#pragma comment(lib,"../aplib/lib/coff/aplib.lib")

// lz4-r127
#include "../lz4-r127/lib/lz4.h"
#pragma comment(lib,"liblz4.lib")

// snappy 1.1.2
#include "../snappy/snappy-c.h"
#pragma comment(lib,"libsnappy.lib")

// zlib-1.2.8
#include "../zlib-1.2.8/zlib.h"
#pragma comment(lib,"zlibstat.lib")
