// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] NewArray(int[] arr)
{
    int arrSize = 0;
    if (arr.Length % 2 == 0) arrSize = arr.Length / 2;
    else arrSize = (arr.Length / 2) + 1;
    int[] arr1 = new int[arrSize];
    int count = arr.Length;
    for (int i = 0; i < arrSize; i++)
    {
        arr1[i] = arr[i] * arr[count - 1];
        count--;
    }
    if (arr.Length % 2 != 0)
        arr1[arrSize - 1] = arr[arrSize];
    return arr1;
}


Console.WriteLine("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон значения:");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон значения:");
int maxArr = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(arraySize, minArr, maxArr);
PrintArray(array);
int[] newArray = NewArray(array);
PrintArray(newArray);