using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionProject.Calcs
{
    public class LeftBracket : ICalc
    {
        public bool CanExecute
        {
            get { return false; }
        }

        public bool IsCalcOperator
        {
            get { return true; }
        }

        public int Execute(int firstSecond, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public int GetLevel(char chr, bool outside)
        {
            return outside ? 5 : 2;
        }
    }
}
