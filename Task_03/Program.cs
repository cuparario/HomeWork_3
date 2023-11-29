/* Задача 3. Задайте массив из вещественных чисел с 
ненулевой дробной частью. Найдите разницу между 
максимальным и минимальным элементов массива. */

using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args) 
            { double maxi, mini; int i, n; 
            Console.WriteLine("Введите массив:"); 
            var line = Console.ReadLine().Split(" "); 
            n = line.Length; double [] A = new double[n]; 
            A[0] = maxi = mini = double.Parse(line[0]); 
            for (i = 1; i < n; i++) 
                { A[i] = double.Parse(line[i]); 
                if (A[i] < mini) mini = A[i]; 
                if (A[i] > maxi) maxi = A[i]; 
                } 
Console.WriteLine("max-min="+(maxi-mini)); 
            } 
    } 
}
