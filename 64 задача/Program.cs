/*
    Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
    Выполнить с помощью рекурсии.

    N = 5 -> "4, 2"
    N = 8 -> "8, 6, 4, 2"
*/

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

AllEvenNumbers(N);
Console.WriteLine();

void AllEvenNumbers(int N)
{
    if (N > 1)
    {
        if (N % 2 == 0)      Console.Write($"{N}, ");
        AllEvenNumbers(N -1);
    }
}