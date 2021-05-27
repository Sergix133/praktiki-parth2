using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая 3 задание 1");
            int[] number = { 1, 2, 3, 4, -1, -4, -5 };

            int min = number[0];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < 0)
                {
                    number[i] *= -1;
                }
                if (min > number[i])
                {
                    min = number[i];
                }
            }
            Console.WriteLine(min);
            Console.WriteLine("Задание 2");
            int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Array.Clear(numbers, i, 1);
                        Array.Clear(numbers, j, 1);

                    }
                }
            }
            foreach (var j in numbers)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("Задание 3");
            Random random = new Random();
            int[] massiv = new int[20];
            for(int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = random.Next(-100, 100);
            }
            for(int j = 0; j < massiv.Length; j++)
            {
                if (massiv[j] < 0)
                {
                    Array.Clear(massiv, j, 1);
                }
            }
            foreach(var j in massiv)
            {
                Console.WriteLine(j);
            }
        }
    }
}
