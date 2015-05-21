﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionProject.Calcs
{
    public class Multipy : ICalc
    {
        public bool CanExecute { get { return true; } }

        public bool IsCalcOperator { get { return true; } }

        public int GetLevel(char chr, bool outside)
        {
            return 4;
        } 

        public int Execute(int firstSecond, int secondNumber)
        {
            return firstSecond * secondNumber;
        }
    }
}
