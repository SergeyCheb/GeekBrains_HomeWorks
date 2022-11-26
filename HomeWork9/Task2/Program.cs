//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// в реализации не имеет значения, какая величина больше (M > N или N > M, или M = N);
// более того, метод работает для целых чисел, не только натуральных
int SumValuesFromMToN(int m, int n)
{
    if (m < n)
        return m + SumValuesFromMToN(++m, n);
    if (n < m)
        return n + SumValuesFromMToN(++n, m);
    return m;
}

Console.Write("Enter the first value: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second value: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumValuesFromMToN(m, n));
