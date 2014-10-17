#pragma once
#include "MathFuncs.hpp"
#include "stdafx.h"

namespace Calc
{
	extern "C"
	{
		__declspec(dllexport) Calculator * CreateCalculator();
		__declspec(dllexport) void DisposeCalculator(Calculator* ptrObject);
		__declspec(dllexport) double CalculatorAdd(Calculator* ptrObject, double x, double y);
	}
}