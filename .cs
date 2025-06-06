using System;

public class Pet
{
    public string Name { get; set; }

    public string name()
    {
        Name = name;
    }

    public virtual void speak()
    {
        Console.WriteLine($"{Name} make a sound");
    }
    public void ead()
    {
        Console.WriteLine("${Name} is eating...");
    }
}