Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

bool checkDividing = CheckDividing(number);
Console.WriteLine(checkDividing ? "кратно" :  "некратно");


bool CheckDividing(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

