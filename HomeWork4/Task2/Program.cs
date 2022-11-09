//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sumDigitsInNumber(int num) 
{
    int sum = 0;
    num = Math.Abs(num); //для корректной обработки отрицательных чисел
    while (num != 0)
    {
        sum +=(num % 10);
        num /= 10;
    }
    return sum;
}

Console.Write("Enter an integer number: ");
int val = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of digits of number {val} is {sumDigitsInNumber(val)}");