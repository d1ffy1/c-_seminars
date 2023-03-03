// // Задача 20: Напишите программу, которая
// // принимает на вход координаты двух точек и
// // находит расстояние между ними в 2D
// // пространстве.
// // A (3,6); B (2,1) -> 5,09
// // A (7,-5); B (1,-1) -> 7,21

// Math.Sqrt(5);
// double d = 5.09987354;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound);



double Distance(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); 
}



Console.WriteLine("Введите координаты точки  А:");
Console.Write("X для А: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y для А: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки X от B:");
Console.Write("X для В: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y для B: ");
int yB = Convert.ToInt32(Console.ReadLine());

double length = Distance(xA, xB, yA, yB);

Console.WriteLine($"Расстояние между точками А и В = {Math.Round(length, 2, MidpointRounding.ToZero)}");
