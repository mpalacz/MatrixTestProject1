using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatrixTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        double[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[,] B = { { -3, 23, 1.5 }, { 2.5, 8, -4.7 }, { 4.24, 2.17, -7.823 } };
        double k = 1.5;
        double[,] C = { { 1, 0, 2 }, { -1, 3, 1 } };
        double[,] D = { { 3, 1 }, { 2, 1 }, { 1, 0 } };
        [TestMethod]
        public void TestMethod_matrixAddition()
        {
            double[,] expectedResults = { { -2, 25, 4.5 }, { 6.5, 13, 1.3 }, { 11.24, 10.17, 1.117 } };
            double[,] actualResults = Matrix.matrixAddition(A, B);
            Assert.AreEqual(expectedResults, actualResults);
        }
        [TestMethod]
        public void TestMethod_matrixMultiplicationByScalar()
        {
            double[,] expectedResult = { { 1.5, 3, 4.5 }, { 6, 7.5, 9 }, { 10.5, 12, 13.5 } };
            double[,] actualResult = Matrix.matrixMultiplicationByScalar(A, k);
            Assert.AreEqual(expectedResult, actualResult);  
        }
        [TestMethod]
        public void TestMethod_matrixMultiplication()
        {
            double[,] expectedResult = { { 5, 1 }, { 4, 2 } };
            double[,] actualResult = Matrix.matrixMultiplication(C, D);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
