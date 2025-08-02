// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("LOOPS IN C SHARP");
        Console.WriteLine ("");
        Console.WriteLine ("");
        Console.WriteLine ("FOR LOOPS ");
        Console.WriteLine ("");
        
        for (int i=1; i<=5; i++)
        {
            Console.WriteLine ("For LOOPS : " +i);
        }
        
        Console.WriteLine ("");
        Console.WriteLine ("WHILE LOOPS ");
        Console.WriteLine ("");
        
        int j=2;
        while (j<=7)
        {
            Console.WriteLine ("While Loop : " +j);
            j++;
        }
        
            Console.WriteLine ("");
        Console.WriteLine ("Do-WHILE LOOPS ");
        Console.WriteLine ("");
        
        int a = 3;
        do{
            Console.WriteLine("Do-While Loop : " +a);
            a++;
        }
        while (a<=9);
        
                Console.WriteLine ("");
        Console.WriteLine ("FOR_EACH LOOPS ");
        Console.WriteLine ("");
        
        string[] names = {"Ram", "Shyam", "Hari"};
        foreach (string name in names)
        {
            Console.WriteLine("Name: " +name );
        }
        
        
//         <====== OUTPUT =====>
//         LOOPS IN C SHARP


                // FOR LOOPS 
                
                // For LOOPS : 1
                // For LOOPS : 2
                // For LOOPS : 3
                // For LOOPS : 4
                // For LOOPS : 5
                
                // WHILE LOOPS 
                
                // While Loop : 2
                // While Loop : 3
                // While Loop : 4
                // While Loop : 5
                // While Loop : 6
                // While Loop : 7
                
                // Do-WHILE LOOPS 
                
                // Do-While Loop : 3
                // Do-While Loop : 4
                // Do-While Loop : 5
                // Do-While Loop : 6
                // Do-While Loop : 7
                // Do-While Loop : 8
                // Do-While Loop : 9
                
                // FOR_EACH LOOPS 
                
                // Name: Ram
                // Name: Shyam
                // Name: Hari
    }
}
