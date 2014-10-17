#include "stdafx.h"
#include "MathFuncCBridge.hpp"
#include "MathFuncs.hpp"

using namespace std;

extern "C"{
	Calc::Calculator __declspec(dllexport) * Calc::CreateCalculator(double x, double y)
	{
		return new Calculator(x, y);
	}

	void __declspec(dllexport) Calc::DisposeCalculator(Calculator* ptrObject)
	{
		if (ptrObject != NULL)
		{
			delete ptrObject;
			ptrObject = NULL;
		}
	}

	double __declspec(dllexport) Calc::CalculatorAdd(Calculator* ptrObject)
	{
		return ptrObject->Add();
	}
}