using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ISMMatrix;

namespace ISMMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());
                double[,] mat = Dimas.InputMatrix(n, m);
                int first = Dimas.first(mat);
                double second = Dimas.second(mat);
                int third = Dimas.third(mat);
                int task4 = Dimas.task4(mat);
                double task5 = Dimas.task5(mat);
                double task6 = 0;
                double task8 = 0;
                if (mat.GetLength(0) == mat.GetLength(1))
                {
                    task6 = Dimas.task6(mat);
                    task8 = Dimas.task8(mat);
                }
                Console.WriteLine("1) {0}\n2) {1}\n3) {2}\n4) {3}\n5) {4}\n6) {5}\n8){6}", first, second, third, task4 + 1/*отсчет с 1*/, /*task5*/"в процессе..", task6,task8);
                Console.WriteLine("Транспонированая матрица: \n");
                Dimas.WriteMatrix(Dimas.tr(mat));
                Console.WriteLine("Oбратная матрица:\n");
                if (mat.GetLength(0) == mat.GetLength(1))
                    Dimas.WriteMatrix(Dimas.task11(mat));
                else Console.WriteLine("Только для кв. матрици\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(@"Что-то пошло не так :/ "+ e + "\n");
            }
            Console.ReadKey();
        }
    }
}

