// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.

// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 3
// 6, 1, 33 -> [6, 1, 33]


int [] MassiveFromUser (int N, int number)
{
    int []array = new int [N];
    for (int i=0; i<N; i++)
    {
        Console.Write($"Enter {i}-element of your massive ");
        array [i] = Convert.ToInt32 (Console.ReadLine());
    }
    return array;
}
try
{
    int n = 0;
    System.Console.Write("Enter dimension of your massive = ");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(String.Join(",", MassiveFromUser(a, n)));
}
catch
{
    System.Console.Write("You've entered not a number, or you massive is too big");
}