Console.WriteLine("Enter a number to check if it is positive, negative, or zero, and to display its times table up to 12:");
long number = Convert.ToInt64(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("The number is negative.");
}
else if (number == 0)
{
    Console.WriteLine("The number is zero.");
}
else
{
    Console.WriteLine("The number is positive.");
}

if (number > 0)
{
    for (int n = 1; n <= 12; n++)
    {
        int result = number * n;
        Console.WriteLine($"{number} x {n} = {result}");
    }
}

