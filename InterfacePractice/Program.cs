using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat antonio = new Cat("Antonio Banderas", "ginger", 11, false);
            Console.WriteLine(antonio.Name);

            antonio.Eat();

            Dog max = new Dog("Max", "White with brown spots", "Jack Russell Terrier");
            Console.WriteLine(max.Name);

            max.Eat();
        }
    }
}
