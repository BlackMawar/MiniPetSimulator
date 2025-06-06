namespace MiniPetSimulator_Hybrid.Models
{
    public class Pet
    {
        public string Name { get; set; }

        public Pet(string name)
        {
            Name = name;
        }

        public virtual string Speak()
        {
            return $"{Name} make a sound";
        }
        public string Eat()
        {
            return $"{Name} is eating...";
        }
    }
}
