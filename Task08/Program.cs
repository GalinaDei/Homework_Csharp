﻿// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Enter a number");
int N = int.Parse(Console.ReadLine()??"");
Console.Write($"{N} -> ");
for (int count=1; count<N; count++)
{
 if (count%2 == 0)
 {
    Console.Write($"{count}, ");
 }
}

