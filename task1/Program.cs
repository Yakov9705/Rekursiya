//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
using System;

class Program
{
    static void PrintNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.WriteLine(M);
            PrintNumbers(M + 1, N);
        }
    }

    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        if (M > N)
        {
            // Если M больше N, меняем их местами
            int temp = M;
            M = N;
            N = temp;
        }

        PrintNumbers(M, N);
    }
}