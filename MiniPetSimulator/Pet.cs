
public class Pet
{
    public string Name { get; set; }

    public Pet(string name)
    {
        Name = name;
    }

    public virtual void speak()
    {
        Console.WriteLine($"{Name} make a sound");
    }
    public void eat()
    {
        Console.WriteLine($"{Name} is eating...");
    }
}