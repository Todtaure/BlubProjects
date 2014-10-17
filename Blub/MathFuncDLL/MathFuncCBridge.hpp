#pragma once
#include "MathFuncs.hpp"
#include "stdafx.h"

namespace Calc
{
	extern "C"
	{
		__declspec(dllexport) Calculator * CreateCalculator(double x, double y);
		__declspec(dllexport) void DisposeCalculator(Calculator* ptrObject);
		__declspec(dllexport) double CalculatorAdd(Calculator* ptrObject);
	}
}