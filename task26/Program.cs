﻿// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int digitCounter = DigitCounter(number);
Console.WriteLine($"Количество цифр в числе {number} -> {digitCounter}");




int DigitCounter(int num)
{
   while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}