// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Ackerman(int m, int n)
{
    if (m == 0 && n >= 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Ackerman(--m, 1);
    if (m > 0 && n > 0)
        return Ackerman(m - 1, Ackerman(m, --n));
    else
    {
        Console.WriteLine("Incorrect input!");
        return 0;   //флаг недопустимых знаечний m или n
    }
}

Console.Write("Input first argument (m >= 0): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second argument (n >= 0): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Ackerman(m, n));