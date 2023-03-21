// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[,,] Create3DArrayInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] arr3d = new int[rows, columns, depth]; // 0, 1


    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k < arr3d.GetLength(2); k++)
            {
            arr3d[i, j, k] = min++;
            }
        
        }
    }
    return arr3d;
}

void Print3DArray(int[,,] arr3d)
{
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k < arr3d.GetLength(2); k++)
            {
            Console.Write($"{arr3d[i, j, k]} {(i, j, k)}  ");
            }
        Console.WriteLine();
        }
    }
}

int [,,] array3d = Create3DArrayInt(2, 2, 2, 10, 100);
Print3DArray(array3d);