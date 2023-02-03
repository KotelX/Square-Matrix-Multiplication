using System;
public class Kata
{
    public static int[,] MatrixMultiplication(int[,] a, int[,] b)
    {
        var size = a.GetLength(0);
        int[,] res = new int[size,size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                var summ = 0;
                for (int k = 0; k < size; k++)
                {
                    summ += a[i, k] * b[k, j];
                }
                res[i, j] = summ;
            }
            
        }

        return res;
    }
}

