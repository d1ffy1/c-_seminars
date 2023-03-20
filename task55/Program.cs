// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

void ReplaceRowsToColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }

}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);
if (array2d.GetLength(0) == array2d.GetLength(1))
{
    ReplaceRowsToColumns(array2d);
    Console.WriteLine();
    PrintMatrix(array2d);
}
else Console.WriteLine("Замена невозможна!");