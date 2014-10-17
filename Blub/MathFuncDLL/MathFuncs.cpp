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

//C++ class with C bridge
namespace Calc
{
		Calculator::Calculator()
		{
		}

		Calculator::~Calculator()
		{
		}

		double Calculator::Add(double x, double y)
		{
			return x + y;
		}
}
