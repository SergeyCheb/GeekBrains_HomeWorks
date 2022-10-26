void cubes(int n)
{
    if (n > 0)
        for (int i = 1; i <= n; ++i)
            Console.Write($"{Math.Pow(i, 3)} ");
    else
        Console.WriteLine("This number doesn't belong to range [1; +infinity]");
}

Console.Write("Enter a positive integer number: ");
cubes(Convert.ToInt32(Console.ReadLine()));