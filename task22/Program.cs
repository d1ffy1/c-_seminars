// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
    SqrTable(number);
}
else
{
    Console.WriteLine("Число должно быть натуральным!");
}



void SqrTable(int num)
{
    
    int count = 1;
        while(count <= num)
    {
        Console.WriteLine($"{count, 4} -> {count * count, 4}");
        count++;
    }
}

