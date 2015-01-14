using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTester
{
    public static class ExpressionTree
    {
        public static void Run()
        {
            // Creating a parameter expression.
            ParameterExpression value = Expression.Parameter(typeof(int), "value");

            // Creating an expression to hold a local variable. 
            ParameterExpression result = Expression.Parameter(typeof(int), "result");

            // Creating a label to jump to from a loop.
            LabelTarget label = Expression.Label(typeof(int));

            // Creating a method body.
            BlockExpression block = Expression.Block(
                // Adding a local variable. 
                new[] { result },
                // Assigning a constant to a local variable: result = 1
                Expression.Assign(result, Expression.Constant(1)),
                // Adding a loop.
                    Expression.Loop(
                // Adding a conditional block into the loop.
                       Expression.IfThenElse(
                // Condition: value > 1
                           Expression.GreaterThan(value, Expression.Constant(1)),
                // If true: result *= value --
                           Expression.MultiplyAssign(result,
                               Expression.PostDecrementAssign(value)),
                // If false, exit the loop and go to the label.
                           Expression.Break(label, result)
                       ),
                // Label to jump to.
                   label
                )
            );

            // Compile and execute an expression tree. 
            int factorial = Expression.Lambda<Func<int, int>>(block, value).Compile()(5);
            
            Console.WriteLine("Factorial of 5 is {0}", factorial);
            // Prints 120.
        }

        public static void RunIsResultLessThan(int firstInt, int secondInt, int constantInt)
        {
            Expression<Func<int, int, bool>> resultIsLessExpr = (i, i1) => i - i1 < constantInt;

            Console.WriteLine("Is {0} - {1} less than {2}?", firstInt, secondInt, constantInt);
            Console.WriteLine(resultIsLessExpr.Compile()(firstInt, secondInt));

            //Can also be written as
            //var result = resultIsLessExpr.Compile();
            //Console.WriteLine(result(firstInt, secondInt));
        }

    }
}
