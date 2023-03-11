// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOfOddElm(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    return sum;
}


Console.WriteLine("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон значения:");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон значения:");
int maxArr = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(arraySize, minArr, maxArr);
PrintArray(array);
int sumOfOddElm = SumOfOddElm(array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях = {sumOfOddElm}");