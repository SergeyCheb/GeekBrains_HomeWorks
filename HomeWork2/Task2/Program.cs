//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int func(int val)
{
    int absVal = Math.Abs(val);// Функция Math.Abs() нужна для охвата отрицательного диапазона входных значений
    if (absVal / 100 > 0)
    {
        int count = 1;
        //идея в том, чтобы посчитать разрядность числа, затем поделить исходное число на [количество разрядов - 3],
        //что даст трехзначное число, в разряде единиц которого будет находиться искомая цифра
        for (int temp = absVal; (temp /= 10) > 0; ++count) ; //тело цикла намерено пустое, потому что все необходимые действия выполнены внутри круглых скобок
        return absVal / (int)Math.Pow(10, (count - 3)) % 10; //поскольку фц Math возвращает тип double, я использую явное приведение типа к int
    }
    else
        return -1;
}

Console.Write("Insert a integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (func(num) != -1)
    Console.WriteLine($"The third digit in this number is {func(num)}");
else
    Console.WriteLine("There isn't third digit in this number.");
