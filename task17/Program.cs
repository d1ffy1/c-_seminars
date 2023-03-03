// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int QuaterNumber(int numX, int numY)
{
    if(numX > 0 && numY > 0) return 1;
    if(numX < 0 && numY > 0) return 2;
    if(numX < 0 && numY < 0) return 3;
    if(numX > 0 && numY < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точки:");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quater = QuaterNumber(x, y);
string result = quater > 0
                ? $"Указанные координаты соответствуют четверти - {quater}"
                : "Введены некорректные координаты";

Console.WriteLine(result);
