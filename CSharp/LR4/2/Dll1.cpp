#include "pch.h"

#include <math.h>
#include <utility>
#include <limits.h>

#define DLL_EXPORTS extern "C" __declspec(dllexport) double

DLL_EXPORTS __stdcall Perimeter(double a, double b)
{
	return (a + b) * 2;
}

DLL_EXPORTS __cdecl Area(double a, double b)
{
	return a*b;
}

DLL_EXPORTS __stdcall Diagonal(double a, double b)
{
	return sqrt(pow(a,2) + pow(b, 2));
}