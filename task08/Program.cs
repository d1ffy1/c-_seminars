﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;
Console.WriteLine($"Чётные числа от 1 до {number}:");
while(count < (number - 1))
{
    count += 2;
    Console.WriteLine(count);
}