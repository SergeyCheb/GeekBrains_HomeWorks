//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Enter a first integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a second integer number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a third integer number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a < b ? (b > c ? b : c) : (a > c ? a : c);    //скобки излишни. Добавлены для читабельности    
Console.WriteLine($"max = {max}");