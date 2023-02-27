int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное  трехзначное число -> {number}");


int DelSecondDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int delSecondDigit = firstDigit * 10 + lastDigit;
    return delSecondDigit;
}

int delSecondDigit = DelSecondDigit(number); 
Console.WriteLine($"Полученное двухзначное число -> {delSecondDigit}");
