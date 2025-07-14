

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the two number");
        int a = Convert.ToInt32(Console.ReadLine());
         int b = Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine(a == b);  // false
         Console.WriteLine(a != b);  // true
         Console.WriteLine(a > b);   // true
         Console.WriteLine(a < b);   // false
         Console.WriteLine(a >= 10); // true
         Console.WriteLine(b <= 5);  // true
         
          /*
          <=== Output ===>
         Enter the two number
            10
            5
            False
            True
            True
            False
            True
            True
        */
    }
}
