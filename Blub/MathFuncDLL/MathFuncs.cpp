#include "stdafx.h"
#include "MathFuncs.hpp"

using namespace std;

extern "C"{
	double __declspec(dllexport) Add(double a, double b)
	{
		return a + b;
	}

	double __declspec(dllexport) Subtract(double a, double b)
	{
		return a - b;
	}

	double __declspec(dllexport) Multiply(double a, double b)
	{
		return a * b;
	}
}

namespace Calc
{
		Calculator::Calculator(double x, double y)
		{
			_x = x;
			_y = y;
		}

		Calculator::~Calculator()
		{
		}

		double Calculator::Add()
		{
			return _x + _y;
		}
}
