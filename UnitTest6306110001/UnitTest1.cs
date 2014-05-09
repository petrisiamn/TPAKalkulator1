using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTest6306110001
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAddition()
        {
            MainWindow calc = new MainWindow();
            double op1 = 4;
            double op2 = 7;
            double expect = 11;
            double actual = calc.addition(op1, op2);

            Assert.AreEqual(expect, actual, "true");
        }
        [TestMethod]
        public void TestMethodSubstaction()
        {
            MainWindow calc = new MainWindow();
            double op1 = 3;
            double op2 = 1;
            double expect = 2;
            double actual = calc.substraction(op1, op2);

            Assert.AreEqual(expect, actual, "true");

        }
        [TestMethod]
        public void TestMethodMultiplication()
        {
            MainWindow calc = new MainWindow();
            double op1 = 7;
            double op2 = 8;
            double expect = 56;
            double actual = calc.multipication(op1, op2);

            Assert.AreEqual(expect, actual, "true");
        }
        [TestMethod]
        public void TestMethodDivision()
        {
            MainWindow calc = new MainWindow();
            double op1 = 16;
            double op2 = 2;
            double expect = 8;
            double actual = calc.division(op1, op2);

            Assert.AreEqual(expect, actual, "true");
        }
    }
}
