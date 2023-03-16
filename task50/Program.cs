// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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




int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
Console.WriteLine("Введите номер строки: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int columnIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();
if (rowIndex <= array2d.GetLength(0) && columnIndex <= array2d.GetLength(1) && rowIndex > 0 && columnIndex > 0)
{
    Console.WriteLine($"Элемент массива с координатами [{rowIndex}, {columnIndex}] = {array2d[rowIndex - 1, columnIndex - 1]}");
}
else Console.WriteLine("Такого элемента в массиве нет! ");
