using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatrixTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        double[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[,] B = { { -3, 23, 1.5 }, { 2.5, 8, -4.7 }, { 4.24, 2.17, -7.823 } };
        [TestMethod]
        public void TestMethod_matrixAddition()
        {
            double[,] expectedResults = { { -2, 25, 4.5 }, { 6.5, 13, 1.3 }, { 11.24, 10.17, 1.117 } };
            double[,] actualResults = Matrix.matrixAddition(A, B);
            Assert.AreEqual(expectedResults, actualResults);
        }
    }
}
