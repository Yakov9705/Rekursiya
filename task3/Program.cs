// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;
class Program
{
static void PrintArrayReverse(int[] array, int index)
{
if (index >= 0)
{
Console.WriteLine(array[index]);
PrintArrayReverse(array, index - 1);
}
}
static void Main()
{
int[] array = { 1, 2, 3, 4, 5 };
PrintArrayReverse(array, array.Length - 1);
}
}