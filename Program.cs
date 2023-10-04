using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в создание двумерного массива!");
            Console.WriteLine("Введите количество строк:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение, до которого подбирать рандом:");
            int randy = int.Parse(Console.ReadLine());

            int[,] arrayA = new int[row, col];
            int[,] arrayB = new int[row, col];

            Random r = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arrayA[i, j] = r.Next(randy + 1);
                    Console.Write($"{arrayA[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arrayB[i, j] = r.Next(randy + 1);
                    Console.Write($"{arrayA[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{arrayA[i, j] + arrayB[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
