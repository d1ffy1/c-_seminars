// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2) ); 
}



Console.WriteLine("Введите координаты точки  А:");
Console.Write("X для А: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y для А: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z для А: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки X от B:");
Console.Write("X для В: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y для B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z для B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double length = Distance(xA, xB, yA, yB, zA, zB);

Console.WriteLine($"Расстояние между точками А и В = {Math.Round(length, 2, MidpointRounding.ToZero)}");
