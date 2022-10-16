// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Insert first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1 > num2 ? num1 : num2;
Console.Write($"max = {max}");