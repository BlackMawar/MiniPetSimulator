namespace MiniPetSimulator { 
    public class Dog : Pet
    {
        public Dog(string name) : base(name) { }
        public override void speak()
        {
            Console.WriteLine($"{Name} says: woof woof!");
        }
    }
}