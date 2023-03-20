// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[] FindMinIndexes(int[,] matrix)
{
    int[] minIndexes = new int[2];
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int min = matrix[row,column];
            if (matrix[i,j] < min) 
            {
            row = i;
            column = j;
            }   
        }
        minIndexes[0] = row;
        minIndexes[1] = column;
    }
    return minIndexes;
}
int[,] DeleteMinRowColumn(int[,] matrix, int rowDel, int columnDel)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int m = 0, n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == rowDel) m++; 
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n==columnDel) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return newMatrix;
}



int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);
int[] findMin = FindMinIndexes(array2d);
int[,] newArray2d = DeleteMinRowColumn(array2d, findMin[0], findMin[1]);
Console.WriteLine();
PrintMatrix(newArray2d);