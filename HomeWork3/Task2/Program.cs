//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double length(double x1, double y1, double z1, double y2, double x2, double z2)
{
    double lengthIn2D = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    double lengthIn3D = Math.Sqrt((z2 - z1) * (z2 - z1) + lengthIn2D * lengthIn2D);
    return Math.Round(lengthIn3D, 2);
}

Console.Write("Enter the coordinate of x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate of y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate of z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the coordinate of x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate of y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate of z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(length(x1, y1, z1, x2, y2, z2));