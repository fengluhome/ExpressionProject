using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionProject.Calcs
{
    public interface ICalc
    {
        /// <summary>
        /// 是否可以执行
        /// </summary>
        bool CanExecute { get; }

        /// <summary>
        /// 是否是运算符
        /// </summary>
        bool IsCalcOperator { get; }

        int Execute(int firstSecond, int secondNumber);


        /// <summary>
        /// 获取等级
        /// </summary>
        /// <param name="chr">操作符</param>
        /// <param name="outside">是否在外面</param>
        /// <returns>等级</returns>
        int GetLevel(char chr, bool outside);


    }
}
