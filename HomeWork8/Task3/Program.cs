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

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int[,] resMatr = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < resMatr.GetLength(0); ++i)
            for (int j = 0; j < resMatr.GetLength(1); ++j)
            {
                resMatr[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); ++k)
                {
                    resMatr[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
            return resMatr;
    }
    else
    {
        return null;
    }
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
В виду того, что умножение 2-х матриц возможно только при определенных условиях, а так же возможно в результате перемножения двух матриц получить 
как нулевую матрицу, так и единичную(причем элементами обеих матриц при этом могут быть целые числа), то имеет смыл в качестве маркера
невозможности перемножения использовать возвращаемое значение null
*/

Console.Write("Input a number of rows of first matrix: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns of first matrix: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value for first matrix: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value for first matrix: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix1 = CreateRandom2dArray(m1, n1, min1, max1);
Show2dArray(myMatrix1);

Console.Write("Input a number of rows of second matrix: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns of second matrix: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value for second matrix: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value for second matrix: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix2 = CreateRandom2dArray(m2, n2, min2, max2);
Show2dArray(myMatrix2);

int[,] multMatr = MultiplyMatrices(myMatrix1, myMatrix2);
if (multMatr != null)
{
    Show2dArray(multMatr);
} else {
    Console.WriteLine("Multiplying these matrices is impossible.");  
}