using System;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int sum = Add(5, 3);
        Console.WriteLine("Sum = " + sum);
    }
}
