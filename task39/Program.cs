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

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;

    }
}

Console.WriteLine("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон значения:");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон значения:");
int maxArr = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(arraySize, minArr, maxArr);
PrintArray(array);
ReverseArray(array);
PrintArray(array);

Array.Reverse(array);
PrintArray(array);