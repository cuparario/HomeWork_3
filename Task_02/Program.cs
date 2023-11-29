/* Задача 2: Задайте массив на 10 целых чисел. 
Напишите программу, которая определяет количество 
чётных чисел в массиве. */


using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int count = 0;
 
            for (int i = 0; i < 10; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
                if ((a[i] % 2) == 0)
                    count++;
            }
            Console.Write(count);
            Console.ReadKey();
        }
    }
}
    


