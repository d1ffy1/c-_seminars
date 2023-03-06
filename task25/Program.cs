// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int aPowerB = Power(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {aPowerB}");

int Power(int a, int b)
{   
    int pow = a;
    for (int i = 1; i < b; i++)
    {
        checked
        {
        pow *= a;
        }         
    }
    return pow;
}