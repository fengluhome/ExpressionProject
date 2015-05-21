using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpressionProject;

namespace ExpressionProject.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Null()
        {
            var expressionParser = new ExpressionParser();

            expressionParser.Execute(null);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Empty()
        {
            var expressionParser = new ExpressionParser();

            expressionParser.Execute("");
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_WhiteSpace()
        {
            var expressionParser = new ExpressionParser();

            expressionParser.Execute("    ");
        }

        [TestMethod]
        public void Test_Add()
        {
            var expressionParser = new ExpressionParser();
            Assert.AreEqual(3, expressionParser.Execute("1+2="));
            Assert.AreEqual(3, expressionParser.Execute("1+2"));
            Assert.AreEqual(6, expressionParser.Execute("1+2+3="));
            Assert.AreEqual(10, expressionParser.Execute("1+2+3+4="));
        }

        [TestMethod]
        public void Test_AddAndSubtract()
        {
            var expressionParser = new ExpressionParser();

            Assert.AreEqual(4, expressionParser.Execute("1+2+3-2="));
            Assert.AreEqual(4, expressionParser.Execute("1+2+3-2"));
            Assert.AreEqual(-2, expressionParser.Execute("1+2-3-2="));
        }

        [TestMethod]
        public void Test_AddAndSubtractAndMultipy()
        {
            var expressionParser = new ExpressionParser();

            Assert.AreEqual(0, expressionParser.Execute("1+2*2-3-2="));
        }

        [TestMethod]
        public void Test_AddAndSubtractAndMultipyAndDiv()
        {
            var expressionParser = new ExpressionParser();

            Assert.AreEqual(-2, expressionParser.Execute("1+2*2/2-3-2="));
            Assert.AreEqual(6, expressionParser.Execute("2+3*4-8/2*2"));
        }

        [TestMethod]
        public void Test_Bracket()
        {
            var expressionParser = new ExpressionParser();
            Assert.AreEqual(3, expressionParser.Execute("(1+2)="));
            Assert.AreEqual(0, expressionParser.Execute("2+3*((4-3)*(1+1))-8/2*2="));
        }
    }
}
