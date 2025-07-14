using System;

class Program
{
    static void Main()
    {
      string name = "Yubraj Dhakal";
        Console.WriteLine(name.Length);  
        Console.WriteLine(name.Trim());            
        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());  
        Console.WriteLine(name.Substring(1, 10)); 
        Console.WriteLine(name.Replace("Yubraj", "Upamanyu"));
        Console.WriteLine(name.Contains("Yubraj"));
         Console.WriteLine(name.IndexOf("j"));  
         
         <=== Output ===>
        13
        Yubraj Dhakal
        YUBRAJ DHAKAL
        yubraj dhakal
        ubraj Dhak
        Upamanyu Dhakal
        True
        5
    }
}
