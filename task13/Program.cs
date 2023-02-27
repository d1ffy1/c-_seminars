// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

while(number > 1000)
{
    number /= 10;
}
if(number > 99)
{
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine($"Третья цифра = {thirdDigit}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}




int ThirdDigit(int num)
{
    int thirdNum = num % 10;
    return thirdNum;
}