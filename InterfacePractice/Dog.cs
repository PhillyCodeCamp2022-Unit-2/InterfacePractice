using System;
namespace InterfacePractice
{
    public class Dog : IFeedable
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Breed { get; set; }

        public Dog(string name, string color, string breed)
        {
            Name = name;
            Color = color;
            Breed = breed;
        }

        public void Eat()
        {
            Console.WriteLine("scarf (eating noises intensify)");
        }
    }
}
