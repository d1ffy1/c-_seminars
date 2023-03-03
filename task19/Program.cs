// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 9999 && number <100000)
{
int reverseNumber = Reverse(number);
bool palindrome = Palindrome(number, reverseNumber);
Console.WriteLine(palindrome ? "Палиндром" : "Не палиндром" );
}
else
{
    Console.WriteLine("Введите пятизначное число!");
}



bool Palindrome(int num, int reverseNum)
{   
    return num == reverseNum;
}
int Reverse(int num)
{   
    int reverseNum = 0;
    while(num > 0)
    {
    int lastD = num % 10;
    num = num / 10;
    reverseNum = reverseNum * 10;
    reverseNum = reverseNum + lastD;
    }
    return reverseNum;
}