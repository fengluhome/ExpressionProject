using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionProject.Calcs
{
    public interface ICalcFactory
    {
        ICalc Get(char chr);
    }
}
