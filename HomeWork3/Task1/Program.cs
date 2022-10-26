//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//эта функция считает разрядность числа
int digQuantity(int val)
{
    int absVal = Math.Abs(val);
    int count = 1;
    for (int temp = absVal; (temp /= 10) > 0; ++count) ;
    return count;
}

bool isPalindrome(int val)
{
    int reverseVal = 0;
    int cap = digQuantity(val);
    for (int i = cap - 1, j = 0; i >= 0; --i, j++)
    {
        int remainder = (val % (int)Math.Pow(10, j + 1)) / (int)Math.Pow(10, j);
        reverseVal += remainder * (int)Math.Pow(10, i);
    }
    Console.WriteLine($"Reverse value for {val} is {reverseVal}");
    return val == reverseVal;
}

Console.WriteLine("Enter an any integer number: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isPalindrome(input));