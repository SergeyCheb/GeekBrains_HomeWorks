//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int func(int val)
{
    if (val / 100 > 0 && val / 100 < 10)
        return val / 10 % 10;
    else
        return -1;  //добавлено как флаг на случай передачи функции не трёхзначного числа
}

Console.Write("Insert a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The second digit in this number is {func(num)}");   // значение -1 отдельно не обрабатано, т.к. такой задачи не стояло