#pragma once
#include <utility>
#include <limits.h>

#define DLL_EXPORTS extern "C" __declspec(dllexport) double

DLL_EXPORTS __stdcall Perimeter(double a, double b);
DLL_EXPORTS __cdecl Area(double a, double b);
DLL_EXPORTS __stdcall Diagonal(double a, double b);