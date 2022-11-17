// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void AcrossCoordinates(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
        if (b1 == b2)
            Console.WriteLine("These straight lines are coincide");
        else
            Console.WriteLine("These straight lines are parallel");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"These straight lines are across in the point ({Math.Round(x, 3)};{Math.Round(y, 3)})");
    }
}

Console.Write("Insert b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

AcrossCoordinates(b1, k1, b2, k2);
