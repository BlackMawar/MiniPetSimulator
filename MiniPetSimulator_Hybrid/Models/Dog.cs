namespace MiniPetSimulator_Hybrid.Models { 
    public class Dog : Pet
    {
        public Dog(string name) : base(name) { }
        public override string Speak()
        {
            return $"{Name} says: woof woof!";
        }
    }
}