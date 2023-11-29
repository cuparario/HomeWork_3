using System;

namespace Task_01
{
class Program
{
static void Main(string[] args)
    {
    Random random = new Random();

        int[] array = new int[10];
        
            for (int i = 0; i < 10; i++)
        {
            array[i] = random.Next(1, 101);
        }
        foreach (int num in array)
        {
        Console.Write($"{num} ");
        }
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 20 && array[i] <= 90)
            {
                count++;
            }
        }
    //Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine($"Количество элементов отрезка [20, 90]: {count}");
    }
}
}
