// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Insert a quantity of numbers you want to handle: ");
int count = Convert.ToInt32(Console.ReadLine());
if (count > 0)
{
    int tempVal = 0;
    int biggerThanZeroCount = 0;
    for (int i = 0; i < count; ++i)
    {
        Console.Write("Insert the value: ");
        tempVal = Convert.ToInt32(Console.ReadLine());
        if (tempVal > 0)
            ++biggerThanZeroCount;
    }
    Console.WriteLine($"The number of positive values is {biggerThanZeroCount}");
} else {
    Console.Write("The incorrect value is entered.");
}