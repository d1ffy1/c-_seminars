// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixSpiral(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    int value = 1;
    int rowStart = 0;
    int rowEnd = rows - 1;
    int columnStart = 0;
    int columnEnd = columns - 1;
    while (value <= (rows * columns))
    {
        for (int i = columnStart; i <= columnEnd; i++)
        {
            arr[rowStart, i] = value;
            value++;
        }

        for (int i = rowStart + 1; i <= rowEnd; i++)
        {
            arr[i, columnEnd] = value;
            value++;
        }

        for (int i = columnEnd - 1; i >= columnStart; i--)
        {
            arr[rowEnd, i] = value;
            value++;
        }

        for (int i = rowEnd - 1; i >= rowStart + 1; i--)
        {
            arr[i, columnStart] = value;
            value++;
        }

        rowStart++;
        rowEnd--;
        columnStart++;
        columnEnd--;
    }
    return arr;
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

int[,] array2d = CreateMatrixSpiral(4, 4);
PrintMatrix(array2d);