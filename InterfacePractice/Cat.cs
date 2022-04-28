using System;
namespace InterfacePractice
{
    // Create the IFeedable interface
    // Follow the book to see what methods to put into the IFeedable interface
    // Have the Cat class implement the IFeedable interface
    // Implement the necessary methods defined in the interface
    public class Cat : IFeedable
    {
        // This is an empty constructor, can be ignored for now
        // EDIT: Let's fill in the constructor and create an instance Cat to see
        // what we have accomplished with this IFeedable interface

        public string Name { get; set; }
        public string Color { get; set; }
        public int Snuggleability { get; set; }
        public bool IsChonk { get; set; }

        public Cat(string name, string color, int snuggle, bool isChonk)
        {
            Name = name;
            Color = color;
            Snuggleability = snuggle;
            IsChonk = isChonk;
        }

        // Implementing IFeedable.Eat() to satisfy the requirements
        // of the IFeedable interface
        public void Eat()
        {
            Console.WriteLine("scrounge crompch nya nya nya (Cat eating noises lol)");
        }
    }
}
