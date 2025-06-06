using MiniPetSimulator;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🐾 Welcome to Mini Pet Simulator!");
        Console.WriteLine("Choose a pet (dog/cat): ");
        string choice = Console.ReadLine().ToLower() ;

        Console.WriteLine("What is your name of your pet? ");
        string name = Console.ReadLine();

        Pet myPet;

        if (choice == "dog")
        {
            myPet = new Dog(name);
        }
        else if (choice == "cat")
        {
            myPet = new Cat(name);
        }
        else {
            Console.WriteLine("Unkown pet. Existing...");
            return;
        }

        Console.WriteLine($"\n🎉 You adopted {myPet.Name}!");

        while (true) {
            Console.WriteLine("\nWhat do you want you pet to do");
            Console.WriteLine("1. Speak");
            Console.WriteLine("2. Eat");
            Console.WriteLine("3. Exit");

            Console.WriteLine("Choice: ");
            string action = Console.ReadLine();

            switch (action)
            {
                case "1": 
                    myPet.speak(); 
                    break;
                case "2":
                    myPet.eat(); 
                    break;
                case "3":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}