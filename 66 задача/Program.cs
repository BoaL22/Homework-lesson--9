/*
    Задача 66: Задайте значения M и N. Напишите программу, 
    которая найдёт сумму натуральных элементов в промежутке от M до N.

    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int A = M;
int sum = 0;

for (int i = M; i <= N; i++)
{
    sum = sum + M;
    M++;
}

Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов в промежутке от {A} до {N} = {sum}");
Console.WriteLine();
