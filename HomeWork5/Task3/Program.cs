
double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; ++i)
        Console.Write(Math.Round(array[i], 3) + " ");
    Console.WriteLine();
}

double MaxVal(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; ++i)
        if (max < arr[i])
            max = arr[i];
    return max;
}

double MinVal(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; ++i)
        if (min > arr[i])
            min = arr[i];
    return min;
}
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value (integer value, inclusive): ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value (integer value, not inclusive): ");
int max = Convert.ToInt32(Console.ReadLine());
if (max > min)
{
double[] myArr = CreateRandomDoubleArray(n, min, max);
ShowArray(myArr);
double minVal = MinVal(myArr);
double maxVal = MaxVal(myArr);
Console.WriteLine($"Min value is {Math.Round(minVal, 3)}, max value is {Math.Round(maxVal, 3)}.\nDifference between them is {Math.Round(maxVal - minVal, 3)}");
} else {
    Console.WriteLine("The incorrect range is entered.");
}