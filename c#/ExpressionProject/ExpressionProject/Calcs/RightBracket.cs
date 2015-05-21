using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionProject.Calcs
{
    public class RightBracket : ICalc
    {
        public bool CanExecute { get { return false; } }
        public bool IsCalcOperator { get { return false; } }
        public int Execute(int firstSecond, int secondNumber)
        {
            throw new NotImplementedException();
        }
        public int GetLevel(char chr, bool outside)
        {
            return 1;
        }
    }
}
