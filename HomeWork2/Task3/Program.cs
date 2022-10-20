void isWeekend(int day)
{
    if (day >= 1 && day <= 7)
        if (day == 6 || day == 7)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    else
        Console.WriteLine("An incorrect value.");
}

Console.Write("Enter a number in range from 1 to 7 including the both bounds: ");
int temp = Convert.ToInt32(Console.ReadLine());
isWeekend(temp);