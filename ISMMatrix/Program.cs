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
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            double[,] mat = Dimas.InputMatrix(n, m);
            int first = Dimas.first(mat);
            double second = Dimas.second(mat);
            int third = Dimas.third(mat);
            int task4 = Dimas.task4(mat);
            double task5 = Dimas.task5(mat);
            Console.WriteLine("1) {0}\n2) {1}\n3) {2}\n4) {3}\n5) {4}", first, second,third, task4 + 1/*отсчет с 1*/, task5);
            Console.ReadKey();
        }
    }
}
