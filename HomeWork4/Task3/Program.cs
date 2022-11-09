// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
void printArr(int[] arr)
{
    Console.Write("[");
    int i;
    for (i = 0; i < arr.Length - 1; ++i)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[i] + "]");
}

Console.Write("Enter the number of elements of array: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arrInt = new int[num];
if (num != 0)
{
    Console.Write("Enter the first element of array: ");
    for (int i = 0; i < arrInt.Length - 1; ++i)
    {
        arrInt[i] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the next element of array: ");
    }
    arrInt[arrInt.Length - 1] = Convert.ToInt32(Console.ReadLine());
    printArr(arrInt);
} else {
    Console.WriteLine("No elements");
}