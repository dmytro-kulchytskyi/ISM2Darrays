using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM2DArrays
{
    class Program
    {
        static void Generate2DArray(double[,] arr, int cols, int lines, int min, int max,int prec)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)                    
                    arr[i, j] = Math.Round((rand.NextDouble() * (max - min) + min), prec);
        }
        static double[,] Mult(double[,] arr, double[,] arr1)
        {
            if (arr.GetLength(1) != arr1.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            double[,] res = new double[arr.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr1.GetLength(1); j++)
                    for (int k = 0; k < arr.GetLength(1); k++)
                        res[i, j] += arr[i, k] * arr1[k, j];
            return res;
        }

        static void WriteMatrix(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }
        


        static void Main(string[] args)
        {
            Console.WriteLine("Matrix 1  cols:");
            int cols = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Matrix 1  lines:");
            int lines = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Matrix 2  cols:");
            int cols1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Matrix 2  lines:");
            int lines1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            
            Console.WriteLine("Min Value:");
            int min = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Max Value:");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prec:");
            int prec = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            double[,] array = new double[lines,cols];
            double[,] array1 = new double[lines1, cols1];
            Generate2DArray(array, cols, lines, min, max, prec);
            Console.WriteLine();
            WriteMatrix(array);
            Console.WriteLine();
           // Console.ReadKey();
            Generate2DArray(array1, cols1, lines1, min, max, prec);
            WriteMatrix(array1);
            Console.WriteLine();
           // Console.ReadKey();
            double[,] result = Mult(array, array1);
            WriteMatrix(result);

            Console.ReadKey();
        }
    }
}
