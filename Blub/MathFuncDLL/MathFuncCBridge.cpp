#include "stdafx.h"
#include "MathFuncCBridge.hpp"
#include "MathFuncs.hpp"

using namespace std;

extern "C"{
	Calc::Calculator __declspec(dllexport) * Calc::CreateCalculator()
	{
		return new Calculator();
	}

	void __declspec(dllexport) Calc::DisposeCalculator(Calculator* ptrObject)
	{
		if (ptrObject != NULL)
		{
			delete ptrObject;
			ptrObject = NULL;
		}
	}

	double __declspec(dllexport) Calc::CalculatorAdd(Calculator* ptrObject, double x, double y)
	{
		return ptrObject->Add(x, y);
	}
}