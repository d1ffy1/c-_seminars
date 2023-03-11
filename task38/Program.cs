﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


double MaxMinusMin(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    Console.WriteLine($"Максимальный элемент = {max}");
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    Console.WriteLine($"Минимальный элемент = {min}");

    double diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементами = {diff}");
    return diff;
}


Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите минимальный диапазон значения: ");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите максимальный диапазон значения: ");
int maxArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[] array = CreateArrayRndDouble(arraySize, minArr, maxArr);
Console.WriteLine("Массив: ");
PrintArrayDouble(array);
Console.WriteLine();
MaxMinusMin(array);