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
                    if (x[i, j] < 0)
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

        public static double task9(double[,] x)
        {
            int[] ar = new int[x.GetLength(0)];


            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1) - 1; j++)
                {
                    if (x[i, j] < 0)
                    {
                        ar[i] = 1;
                    }
                }
            }

            double sum = 1;
            for (int i = 0; i < x.GetLength(0); i++)
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    if (ar[i] == 1)
                    {
                        sum += x[i, j];
                    }
                }
            return sum;
        }

        public static double task7(double[,] x)
        {
            int[] ar = new int[x.GetLength(0)];


            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1) - 1; j++)
                {
                    if (x[i, j] < 0)
                    {
                        ar[i] = 1;
                    }
                }
            }

            double sum = 1;
            for (int i = 0; i < x.GetLength(0); i++)
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    if (ar[i] != 1)
                    {
                        sum += x[i, j];
                    }
                }
            return sum;
        }



        public static double task6(double[,] x)
        {
            double res;
            if (x[0, x.GetLength(1) - 1] > x[x.GetLength(0) - 1, 0]) res = x[0, x.GetLength(1) - 1];
            else res = x[x.GetLength(0) - 1, 0];
            int j;
            double tmp;
            for (int k = 1; k < x.GetLength(1) - 1; k++)
            {
                tmp = 0;
                for (int i = k; i < x.GetLength(1); i++)
                {
                    j = i - k;
                    tmp += x[j, i];
                }
                if (res < tmp) res = tmp;
            }
            int q;
            double tmpp;
            for (int k = 1; k < x.GetLength(0) - 1; k++)
            {
                tmpp = 0;
                for (int i = k; i < x.GetLength(0); i++)
                {
                    q = i - k;
                    tmpp += x[i, q];
                }
                if (res < tmpp) res = tmpp;
            }
            return res;
        }


        public static double task8(double[,] x)
        {
            double res;
            if (x[0, x.GetLength(1) - 1] < x[x.GetLength(0) - 1, 0]) res = x[0, x.GetLength(1) - 1];
            else res = x[x.GetLength(0) - 1, 0];
            double tmp;
            int s;
            for (int k = x.GetLength(1) - 2; k > 0; k--)
            {
                tmp = 0;
                for (int j = k; j > -1; j--)
                {
                    s = k - j;
                    tmp += Math.Abs(x[s, j]);
                }
                if (res > tmp) res = tmp;
            }
            double tmpp;
            int q;
            for (int k = x.GetLength(0) - 2; k > 0; k--)
            {
                tmpp = 0;
                for (int i = k; i > -1; i--)
                {
                    q = k - i;
                    tmpp += Math.Abs(x[i, q]);
                }
                if (res > tmpp) res = tmpp;
            }

            return res;
        }

        public static double[,] task11(double[,] x)
        {
            double det = 1d / Dimas.det(x);
            double[,] x1 = tr(dop(x));
            for (int i = 0; i < x1.GetLength(0); i++)
                for (int j = 0; j < x1.GetLength(1); j++)
                    x1[i, j] *= det;
            return x1;
        }

        public static double[,] tr(double[,] x)
        {
            double[,] res = new double[x.GetLength(1), x.GetLength(0)];

            for (int i = 0; i < x.GetLength(0); i++)
                for (int j = 0; j < x.GetLength(1); j++)
                    res[j, i] = x[i, j];
            return res;
        }

        public static double[,] dop(double[,] x)
        {
            double[,] res = new double[x.GetLength(0), x.GetLength(1)];

            for (int i = 0; i < x.GetLength(0); i++)
                for (int j = 0; j < x.GetLength(1); j++)
                    res[i, j] = det(submat(x, i, j));

            return res;
        }

        public static double det(double[,] x)
        {
            int ii = x.GetLength(0);
            int jj = x.GetLength(1);
            if (ii == 1) return x[0, 0];           
            double res = 0;
            for (int j = 0; j < ii; j++)
            {
                double[,] sub = submat(x, 0, j);
                res += Math.Pow(-1, j + 2) * x[0, j] * det(sub);
            }
            return res;
        }

        static double[,] submat(double[,] x, int dli, int dlj)
        {
            int size = x.GetLength(0) - 1;
            double[,] res = new double[size, size];
            int k = 0, q = 0;

            for (int i = 0; i <= size; i++)
            {
                q = 0;
                if (i == dli) continue;
                for (int j = 0; j <= x.GetLength(0) - 1; j++)
                {
                    if (j != dlj)
                    {
                        res[k, q] = x[i, j];
                        q++;
                    }
                }
                k++;
            }
            return res;
        }

    }
}
