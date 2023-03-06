// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


Console.WriteLine("Введите число элементов массива:");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
Console.WriteLine();

FillArray(array);
PrintArray(array);
Console.WriteLine("\n");



void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = rand.Next(0, 2);
    }
}

void PrintArray(int[] arr1)
{
    for (int index = 0; index < arr1.Length; index++)
    {
        Console.Write($"{arr1[index]} ");
        }
}



