// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a = 15;
        
        Console.WriteLine("Addition & assign :" + (a+=3));
        Console.WriteLine("Subtraction & assign  : " + (a-=4));
        Console.WriteLine("Multiplacation & assign  : " + (a*=5));
        Console.WriteLine("Division & assign  : " + (a/=3));
        Console.WriteLine("Modolus & assign  : " + (a%=2));
        
        
        /*
        <=== Output ===>
        Addition & assign :18
        Subtraction & assign  : 14
        Multiplacation & assign  : 70
        Division & assign  : 23
        Modolus & assign  : 1
        
        === Code Execution Successful ===
        
        */



    }
}
