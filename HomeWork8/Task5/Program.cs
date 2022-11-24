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

int[,] CreateRandom2dSquareArray(int side, int minValue, int maxValue)
{
    int[,] array = new int[side, side];

    for (int i = 0; i < side; ++i)
        for (int j = 0; j < side; ++j)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
Идея в том, чтобы заполнять массив начиная со внешнего квадрата (периметра) значений и продвигаться вглубь через заполнение внутренних квадратов
(периметров) значений и так до самого центра массива.

Метод будет работать корректно только для квадратной матрицы(любого размера) и для стартовой точки заполнения, лежащей на главной диагонали.
Таким образом, в контексте данной задачи метод работает

arr - квадратный массив
i, j = координаты начала заполнения массива
sideVal - длина стороны квадрата заполнения
initVal - начальное значение для заполнения квадрата
*/
void FillArrSpirally(int[,] arr, int i = 0, int j = 0, int sideVal = 0, int initVal = 1)
{
    if (sideVal > 0)
    {
        int tempI = i;
        int tempJ = j;
        int tempInitVal = initVal;
        for (; tempJ < j + sideVal; ++tempJ)
            arr[tempI, tempJ] = tempInitVal++;
        --tempJ;
        for (++tempI; tempI < i + sideVal; ++tempI)
            arr[tempI, tempJ] = tempInitVal++;
        --tempI;
        for (--tempJ; tempJ >= 0 + j; --tempJ)
            arr[tempI, tempJ] = tempInitVal++;
        ++tempJ;
        for (--tempI; tempI > 0 + i; --tempI)
            arr[tempI, tempJ] = tempInitVal++;
        ++tempI;

        FillArrSpirally(arr, tempI, ++tempJ, sideVal - 2, tempInitVal);
    }
    else
        return;
}

Console.Write("Введите количество строк/столбцов квадратной матрицы: ");
int matrixlength = Convert.ToInt32(Console.ReadLine());

// создаем квадратную матрицу с произвольным заполнением и 
// выводим её для наглядности
int[,] myArr = CreateRandom2dSquareArray(matrixlength, 0, 10);
Show2dArray(myArr);
// заполняем спирально и снова выводим 
FillArrSpirally(myArr, 0, 0, myArr.GetLength(0), 1);
Show2dArray(myArr);