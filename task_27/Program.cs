// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int sumDigits (int S)
{
    int sum = 0;
    int div = 0;
    while (S > 0)
    {
        div = S % 10;
        sum = sum + div;
        S = S/10;
    }
    return sum;
}
try
{
    Console.WriteLine("Enter an integer number N");
    int N = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine($"Sum of all digits of {N} is {sumDigits(N)}");
}
catch
{
    Console.WriteLine("You've entered not an integer number N");
}
