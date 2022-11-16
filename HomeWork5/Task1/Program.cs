

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; ++i)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int EvenCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; ++i)
        if (arr[i] % 2 == 0) ++count;
    return count;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] targetArray = CreateRandomArray(n, 100, 999);
ShowArray(targetArray);
Console.WriteLine($"This array includes {EvenCount(targetArray)} even number(s)");
