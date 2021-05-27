using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rim
{
    class Program
    {
        static void Main(string[] args)
        {
            a: 
            string a = Convert.ToString(Console.ReadLine());
            int S = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 'M' || a[i] != 'D' || a[i] != 'C' || a[i] != 'L' || a[i] != 'X' || a[i] != 'V' || a[i] != 'I')
                {
                    Console.WriteLine("Вы ввели недопустимый символ");
                    break;
                }
                if (a[i] == 'M')
                {
                    S += 1000;
                }
                if (a[i] == 'D')
                {
                    S += 500;
                }
                if (a[i] == 'C')
                {
                    S += 100;
                }
                if (a[i] == 'L')
                {
                    S += 50;
                }
                if (a[i] == 'X')
                {
                    S += 10;
                }
                if (a[i] == 'V')
                {
                    S += 5;
                }
                if (a[i] == 'I')
                {
                    S += 1;
                }
            }
            if (S > 0)
            {
                Console.WriteLine(S);
            }
            Console.ReadLine();
            goto a;
        }
    }
}
