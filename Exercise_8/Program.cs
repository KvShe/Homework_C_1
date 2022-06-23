/*

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.Write("Введите положительное число: ");
double N = Convert.ToInt32(Console.ReadLine());

if (N < 0)
{
    Console.WriteLine("По-русски же написал - ПОЛОЖИТЕЛЬНОЕ");
}

if (N == 0)
{
    Console.WriteLine("Серьёзно? 0? Я викепедию специально открыл, чтоб узнать, что он не положителен");
}

if (N == 1)
{
    Console.WriteLine("А что делать с еденицей? Он вообще ничего не выводит");
}

double count = 1;

while (count <= N)
{
    double remainder = count % 2;
    if (remainder == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}