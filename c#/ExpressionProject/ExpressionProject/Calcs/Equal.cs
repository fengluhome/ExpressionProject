using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionProject.Calcs
{
    public class Equal : ICalc
    {
        public bool CanExecute { get { return false; } }

        public bool IsCalcOperator { get { return false; } }

        public int GetLevel(char chr, bool outside)
        {
            return 0;
        }  

        public int Execute(int firstSecond, int secondNumber)
        {
            throw new NotImplementedException();
        }
    }
}
