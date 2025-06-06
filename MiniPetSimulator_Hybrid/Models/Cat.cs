namespace MiniPetSimulator_Hybrid.Models
{
    internal class Cat : Pet
    {
        public Cat(string name) : base(name) { }
        public override string Speak()
        {
            return $"{Name} says: Meow Meow!";
        }
    }
}
