//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Insert an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
    Console.Write("Yes, the number is even");
else
    Console.Write("No, the number isn't event. It is odd.");