using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Entre your obtain marks less than 100"); 
       int a = Convert.ToInt32(Console.ReadLine()); 
       
       if (a>=90){
              Console.WriteLine("Grade IS A+"); 
       }
       else if (a>=60)
       {
              Console.WriteLine("Grade IS A"); 
       }
       else if (a>=40)
       {
              Console.WriteLine("Grade IS A-"); 
       }
       else{
              Console.WriteLine("Ramro Sanga Pad"); 
       }
       
       /*
       <=== Output ===>
       Entre your obtain marks less than 100
        65
        Grade IS A
        
        === Code Execution Successful ===
       */
    }
}
