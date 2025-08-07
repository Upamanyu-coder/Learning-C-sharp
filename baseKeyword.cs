using System;

// Base class
public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine("Animal constructor called.");
    }

    public void Display()
    {
        Console.WriteLine("I am an animal named " + Name);
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Generic animal sound");
    }
}

// Derived class
public class Dog : Animal
{
    public Dog(string name) : base(name) // Calling the base class constructor
    {
        Console.WriteLine("Dog constructor called.");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    public void ShowDetails()
    {
        base.Display(); // Calling a base class method
    }
}

public class Program
{
    public static void Main()
    {
        Dog myDog = new Dog("Buddy");
        myDog.ShowDetails();
        myDog.MakeSound();
    }
}
