using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionProject.Calcs
{
    public class CalcFactory : ICalcFactory
    {
        private static readonly Dictionary<char, ICalc> Calcs;

        static CalcFactory()
        {
            Calcs = new Dictionary<char, ICalc>
            {
                {'*', new Multipy()},
                {'/', new  Div()},
                {'+', new Add()},
                {'-', new Subtract()},
                {'(', new LeftBracket()},
                {')', new RightBracket()},
                {'=', new Equal()}
            };
        }

        public ICalc Get(char chr)
        {
            if (!Calcs.ContainsKey(chr))
                throw new NotImplementedException("未注册操作符操作类");

            return Calcs[chr];
        }
    }
}
