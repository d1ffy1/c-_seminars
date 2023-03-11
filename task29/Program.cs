// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите количество элементов массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
Console.WriteLine();

FillArray(array);
PrintArray(array);
Console.WriteLine("\n"); 

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = rand.Next(1, 1000);
    }
}

void PrintArray(int[] array1)
{
    for (int ind = 0; ind < array1.Length; ind++)
    {
        Console.Write(array[ind] + "\t");
    }
}