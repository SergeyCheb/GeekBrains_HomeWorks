// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
double aToPowerB(double a, int b)
{
    if (b > 0)
    {
        double result = 1;
        for (int i = 1; i <= b; ++i)
        {
            result *= a;
        }
        return result;
    }
    return -1;
}

Console.Write("Enter a number: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a natural number: ");
int pow = Convert.ToInt32(Console.ReadLine());
double result = aToPowerB(num, pow);
if (result != -1)
    Console.WriteLine($"{num} ^ {pow} = {Math.Round(result,3)}");
else
    Console.WriteLine("Incorrect data are entered.");