namespace MatrixTestProject1
{
    internal class Matrix
    {
        public static double[,] matrixAddition(double[,] A, double[,] B)
        {
            int Am = A.GetLength(0); // no of rows of A
            int An = A.GetLength(1); // no of columns of A
            int Bm = B.GetLength(0); // no of rows of B
            int Bn = B.GetLength(1); // no of columns of B
            if ((Am == Bm) && (An == Bn))
            {
                double[,] result = new double[Am, An];
                for (int i = 0; i < Am; i++)
                    for (int j = 0; j < An; j++)
                        result[i, j] = A[i, j] + B[i, j];
                return result;
            }
            else return null;
        }
        public static double[,] matrixMultiplicationByScalar(double[,] A, double k)
        {
            int Am = A.GetLength(0); // no of rows of A
            int An = A.GetLength(1); // no of columns of A
            double[,] result = new double[Am, An];

            for (int i = 0; i < Am; i++)
                for (int j = 0; j < An; j++)
                    result[i, j] = A[i, j] * k;

            return result;
        }
        public static double[,] matrixMultiplication(double[,] A, double[,] B)
        {
            int Am = A.GetLength(0); // no of rows of A, i - ndex
            int An = A.GetLength(1); // no of columns of A, j -index
            int Bm = B.GetLength(0); // no of rows of B, j- index
            int Bn = B.GetLength(1); // no of columns of B, k - index
            double temp;
            if (An == Bm)
            {
                double[,] result = new double[Am, Bn];
                for (int i = 0; i < Am; i++)
                    for (int k = 0; k < Bn; k++)
                    {
                        temp = 0;
                        for (int j = 0; j < An; j++)
                            temp += A[i, j] * B[j, k];
                        result[i, k] = temp;
                    }
                return result;
            }
            return null;

        }
    }
}
