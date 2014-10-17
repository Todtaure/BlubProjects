#pragma once

namespace Calc{
	class Calculator
	{
	public:
		Calculator(double x, double y);
		~Calculator();
		double Add();

	private:
		double _x;
		double _y;
	};
}