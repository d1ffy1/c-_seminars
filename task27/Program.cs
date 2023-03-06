// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if(number < 0) number *= -1;
int sumDigits = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sumDigits}");


int SumDigits(int num)
{
    int sumD = 0;
    while(num > 0)
    {
        int digit = num % 10;
        num /= 10;
        sumD += digit;
    } 
    return sumD;   
}