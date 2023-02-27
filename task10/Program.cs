// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber = SecondNumber(number);
   Console.WriteLine($"Вторая цифра: {secondNumber}");


int SecondNumber(int num)
{
    int secondNum1step = num / 10;
    int secondNum2step = secondNum1step % 10;
    return secondNum2step;
}