using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] massiv = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    massiv[i,j] += rnd.Next(0, 10);
                    Console.Write(massiv[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            int a = 0;
            long sum = massiv[0,0];
            for (int i = 0; i < 10; i++)
            {
                if (sum < massiv[i,a])
                {
                    sum = massiv[i,a];
                }
                a++;
            }
            int b = 0;
            for (int i = 0; i < 10; i++)
            {
                if (massiv[i, b] == sum)
                {
                    Console.WriteLine(massiv[i,b]);
                    Console.WriteLine("Максимальный элемент главной диагонали находится по координатам = " + "{" + i + ";" + b + "}");
                    break;
                }
                b++;
            }
            int g = 0;
            long SUM = massiv[0, 9];
            for (int i = 9; i > 0; i--)
            {
                if (SUM < massiv[g, i])
                {
                    SUM = massiv[g, i];
                }
                g++;
            }
            int k = 0;
            for (int i = 9; i > 0; i--)
            {
                if (massiv[k,i] == SUM)
                {
                    Console.WriteLine(SUM);
                    Console.WriteLine("Максимальный элемент побочной диагонали находится по координатам = " + "{" + k+ ";" + i + "}");
                    break;
                }
                k++;
            }
            Console.ReadLine();
            int c = 0;
            int sum1 = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sum1 += massiv[j, i];
                }
                Console.WriteLine("Сумма столбца = " + sum1);
                sum1 = 0;
            }
            Console.ReadLine();
        }
    }
}
