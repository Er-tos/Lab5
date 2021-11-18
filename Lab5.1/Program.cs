using System;

namespace Lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 7 элементов массива:");
            int[] array = new int[7];
            float S = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                S += array[i];
            }
            Console.WriteLine("Среднее арифметическое элементов: {0:f2}", S / 7);
            Console.ReadKey();
        }
    }
}
