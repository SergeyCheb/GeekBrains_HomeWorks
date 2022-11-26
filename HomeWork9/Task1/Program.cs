//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowValuesFromNTo1(int val)
{
    if (val >= 1)
    {
        Console.Write(val + " ");
        ShowValuesFromNTo1(--val);
    }
    return;
}

Console.Write("Enter a wished value (>=1): ");
int val = Convert.ToInt32(Console.ReadLine());
if (val > 0)
    ShowValuesFromNTo1(val);
else
    Console.Write("An incorrect value has been entered.");