using System;

class Program
{
    static void Main()
    {
        int A = 10;
        int B = 20;
        int beginA;

        beginA = A;
        A = B;
        B = beginA;
        Console.WriteLine("Vaue of A: " + A);
        Console.WriteLine("Value of B: " + B);

    }
}