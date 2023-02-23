// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 1)
{
    Console.WriteLine("понедельник");
}
else if (dayNumber == 2)
{
    Console.WriteLine("вторник");
}
else if (dayNumber == 3)
{
    Console.WriteLine("среда");
}
else if (dayNumber == 4)
{
    Console.WriteLine("четверг");
}
else if (dayNumber == 5)
{
    Console.WriteLine("пятница");
}
else if (dayNumber == 6)
{
    Console.WriteLine("суббота");
}
else if (dayNumber == 7)
{
    Console.WriteLine("воскресенье");
}
else 
{
    Console.WriteLine("Неправильный ввод числа");
}