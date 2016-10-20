using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMMatrix
{
    public static class Dimas
    {
        public static void WriteMatrix(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }


        public static void Draw(double[,] x, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(x[i, j] + " ");
                Console.Write("\n");
            }
        }

        public static double[,] InputMatrix(int n, int m)
        {
            double[,] x = new double[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Clear();
                    Draw(x, n, m);
                    Console.Write("Next element [{0},{1}]: ", i + 1, j + 1);
                    x[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            Console.Clear();
            return x;
        }

        public static int first(double[,] x)
        {
            int count = 0, nulls;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                nulls = 0;
                for (int j = 0; j < x.GetLength(1); j++)
                    if (x[i, j] == 0) nulls++;
                if (nulls == 0) count++;
            }
            return count;
        }
        public static double second(double[,] x)
        {
            double max = 0;
            int k = 0;
            int n = x.GetLength(0);
            int m = x.GetLength(1);
            double[] y = new double[n * m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    for (int ii = 0; ii < n; ii++)
                        for (int jj = 0; jj < m; jj++)
                            if (Math.Abs(x[i, j] - x[ii, jj]) < 1e-10 && (i != ii || j != jj))
                            {
                                if (k == 0) max = x[i, j];
                                if (x[i, j] > max) max = x[i, j];
                                k++;
                                ii = n;
                                break;
                            }
            return max;
        }
        public static int third(double[,] x)
        {
            int count = 0;
            for (int i = 0; i < x.GetLength(1); i++)
                for (int j = 0; j < x.GetLength(0); j++)
                    if (Math.Abs(x[j, i]) < 1e-10)
                    {
                        count++;
                        break;
                    }
            return count;
        }

        public static int task4(double[,] x)
        {
            int count;
            int[] ar = new int[x.GetLength(0)];


            for (int i = 0; i < x.GetLength(0); i++)
            {
                count = 0;
                for (int j = 0; j < x.GetLength(1) - 1; j++)
                {
                    if (Math.Abs(x[i, j] - x[i, j + 1]) < 1e-8)
                    {
                        count++;
                        ar[i] = count;
                    }
                }
            }

            int maxi = -1;
            int max = int.MinValue;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                    maxi = i;
                }
            }
            return maxi;
        }

        public static double task5(double[,] x)
        {
            int[] ar = new int[x.GetLength(0)];


            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1) - 1; j++)
                {
                    if (Math.Abs(x[i, j]) < 1e-8)
                    {
                        ar[i] = 1;
                    }
                }
            }

          double sum = 1;
          for(int i = 0; i< x.GetLength(0);i++)
            for (int j = 0; j < x.GetLength(1); j++)
            {
                if (ar[i] !=1)
                {
                        sum *= x[i, j];
                }
            }
            return sum;
        }






    }
}
