int Cube (int A, int B)
{
    int cube = A;
    for (int i=2; i<=B; i++)
    {
        cube = cube * A;
    }
    return cube;
}
try
{
    Console.WriteLine("Enter number A");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter degree B");
    int degree = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Number {N} in degree {degree} is {Cube (N, degree)}");
}
catch
{
    Console.WriteLine("You've entered something wrong");
}

