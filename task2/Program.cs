﻿// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;
class Program
{
static int Ackermann(int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if (n == 0)
{
return Ackermann(m - 1, 1);
}
else
{
return Ackermann(m - 1, Ackermann(m, n - 1));
}
}
static void Main()
{
Console.WriteLine(Ackermann(1, 4)); // Выводит 6
}
}