// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the two number");
        int a = Convert.ToInt32(Console.ReadLine());
         int b = Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine (a>5 && b<10);
         Console.WriteLine (a>5 || b<10);
          Console.WriteLine (!(a>10));
          /*
          <=== Output ===>
          Enter the two number
            7
            12
            False
            True
            True
        */
    }
}
