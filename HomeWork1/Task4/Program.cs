//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Insert a positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= num; ++i)
    if (i % 2 == 0)
        Console.Write($"{i} ");