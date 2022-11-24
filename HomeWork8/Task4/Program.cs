void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; ++i)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

// В примере из ДЗ массив выводится именно послойно, сначала условно "плоскость xy" при z = 0, потом при z = 1 и т.д.
void Show3DArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); ++k)
        for (int i = 0; i < array.GetLength(0); ++i)
        {
            for (int j = 0; j < array.GetLength(1); ++j)
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            Console.WriteLine();
        }
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Эта фц будет получать по ссылке* массив чисел от 10 до 99, далее будет "выхватывать" произвольный элемент из этого массива,
// а затем будет удалять этот элемент из массива. Таким образом реализуется уникальность содержимого каждого полученного элемента
// при итерациях. 
int ReceiveRandom2DigitElemAndRemoveItFromArray(ref int[] arr)
{
    int result = -1;    // флаг невозможности вернуть двухзначное число
    int index = 0;
    if (arr.Length > 0)
    {
        index = new Random().Next(0, arr.Length);
        result = arr[index];
        if (arr.Length != 1)
        {
            int[] tempArr = new int[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; ++i, ++j)
                if (i != index)
                    tempArr[j] = arr[i];
                else
                    --j;
            arr = tempArr;
            //ShowArray(arr);
        }
        else
        {
            arr = new int[0];
        }
        
    }
    return result;
}

bool Fill3DArrWithDiffElem(int[,,] arr)
{
    if (arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2) <= 90)
    {
        int[] assistantArr = new int[90];
        for (int i = 0; i < assistantArr.Length; ++i)
            assistantArr[i] = i + 10;
        for (int i = 0; i < arr.GetLength(0); ++i)
            for (int j = 0; j < arr.GetLength(1); ++j)
                for (int k = 0; k < arr.GetLength(2); ++k)
                    arr[i, j, k] = ReceiveRandom2DigitElemAndRemoveItFromArray(ref assistantArr);
        return true;
    }
    return false;
}


Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of layers: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,,] myArr = new int[m, n, l];

if (Fill3DArrWithDiffElem(myArr))
    Show3DArray(myArr);
else
    Console.WriteLine("It is impossible to fill this array with different values exclusively"); 