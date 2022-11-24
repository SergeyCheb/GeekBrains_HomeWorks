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

int GetNumberRowWithMinSumOfElem(int[,] arr)
{
    int rowWithMinSum = 0;
    int minSum = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); ++i)
    {
        int tempSum = 0;
        for (int j = 0; j < arr.GetLength(1); ++j)
            tempSum += arr[i, j];
        if (minSum > tempSum)
        {
            minSum = tempSum;
            rowWithMinSum = i;
        }
    }
    return rowWithMinSum;
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

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Нумерация строк для пользователя так же от нуля
Console.WriteLine($"The row with min sum of elements is {GetNumberRowWithMinSumOfElem(myArray)}");