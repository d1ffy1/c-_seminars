// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int size = matrix.Length;
    int[] arr = new int[size];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[count++] = matrix[i,j];      
        }
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

void CounterOfDigits(int[] arr)
{
    int count = 0;
    int digit = arr[0];
    Array.Sort(arr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == digit) 
        {
            count++;
        }
        else 
        {
            Console.WriteLine($"Число {digit} встречается в массиве {count} раз");
            digit = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {digit} встречается в массиве {count} раз");
}

int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);
int[] array = MatrixToArray(array2d);
// Array.Sort(array);
PrintArray(array);
CounterOfDigits(array);