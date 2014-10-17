#pragma once

namespace Calc{
	class Calculator
	{
	public:
		Calculator();
		~Calculator();
		double Add(double x, double y);

	private:
		double _x;
		double _y;
	};
}