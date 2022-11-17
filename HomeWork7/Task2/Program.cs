// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

double[,] CreateRandom2dDoubleArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; ++i)
        for (int j = 0; j < columns; ++j)
            array[i, j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 2) + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void isElement(double[,] arr, int i, int j)
{
    if (i >= 0 && i < arr.GetLength(0) && j >= 0 && j < arr.GetLength(1))
    Console.WriteLine($"Element in position [{i}, {j}] is {Math.Round(arr[i, j], 2)}");
    else
    Console.WriteLine($"There is no such element.");
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dDoubleArray(m, n, min, max);
Show2dArray(myArray);

Console.Write("Enter the first index: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second index: ");
int j = Convert.ToInt32(Console.ReadLine());

isElement(myArray, i, j);
