using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpressionProject.Calcs;

namespace ExpressionProject
{
    public class ExpressionParser
    {
        private readonly ICalcFactory _calcFactory = new CalcFactory();

        public int Execute(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                throw new ArgumentNullException("expression");

            if (expression[expression.Length - 1] != '=')
                expression += '=';

            var numbers = new Stack<int>();
            var operators = new Stack<char>();

            foreach (var chr in expression)
            {
                if (char.IsNumber(chr))
                    numbers.Push(chr - '0');
                else
                {
                    var currentOperatorCalc = _calcFactory.Get(chr);
                    var currentOperatorLevel = currentOperatorCalc.GetLevel(chr, true);

                    while (true)
                    {
                        if (operators.Count == 0)
                            break;

                        var frontOperator = operators.Peek();
                        var frontOperatorCalc = _calcFactory.Get(frontOperator); 

                        if (currentOperatorLevel > frontOperatorCalc.GetLevel(frontOperator, false))
                            break;
                        operators.Pop();

                        if (!frontOperatorCalc.CanExecute)
                            break;
                        var secondNumber = numbers.Pop();
                        var firstSecond = numbers.Pop();

                        numbers.Push(frontOperatorCalc.Execute(firstSecond, secondNumber));
                    }

                    if (currentOperatorCalc.IsCalcOperator)
                        operators.Push(chr);
                }

            }

            if (numbers.Count != 1)
                throw new ApplicationException("error");

            return numbers.Pop();
        }
    }
}
