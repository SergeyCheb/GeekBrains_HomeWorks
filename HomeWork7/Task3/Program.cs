// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; ++i)
        for (int j = 0; j < columns; ++j)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] EvaluateAverageOfEveryColumn(int[,] arr)
{
    double[] resultArray = new double[arr.GetLength(1)];
    for (int i = 0; i < resultArray.Length; ++i)
    {
        double sumOfColElem = 0;
        for(int j = 0; j < arr.GetLength(0); ++j)
        sumOfColElem += arr[j, i];
        resultArray[i] = sumOfColElem / arr.GetLength(0);
    }
    return resultArray;
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; ++i)
        Console.Write(Math.Round(array[i], 3) + "\t");
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

ShowDoubleArray(EvaluateAverageOfEveryColumn(myArray));