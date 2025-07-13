

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      
        Console.WriteLine("Enter Your Name:"); //Printing as it is
        string name = Console.ReadLine();  // read from the user
        Console.WriteLine("Hello " + name); // concract the strings
        
        Console.WriteLine("In Which Class do you read ?");  //Printing as it is
        Console.WriteLine("Note Bachelors 1st=13, 2nd 14 vise sersa");  //Printing as it is
        string x = Console.ReadLine();  // read from the user
        
        Console.WriteLine("May Be " +name + " Age is " + (Convert.ToInt32(x) + 8) + " years old."); 
      /* concract the strings.
      (Convert.ToInt32(x) + 8)--> This convert the strings x int int */



    }
}
