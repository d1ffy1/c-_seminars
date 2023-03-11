﻿// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

bool CheckNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            return true;
    }
    return false;
}

Console.WriteLine("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон значения:");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон значения:");
int maxArr = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(arraySize, minArr, maxArr);
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintArray(array);
bool checkNumber = CheckNumber(array, number);
Console.Write("Число присуствует в массиве:  ");
Console.WriteLine(checkNumber ? "Да" : "Нет");

