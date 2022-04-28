using System;
namespace InterfacePractice
{
    public interface IFeedable
    {
        // Any class that implements the IFeedable interface needs to
        // create its own Eat method with functionality
        void Eat();

        // This is a default Interface method, therefore any class that
        // implements the IFeedable interface will have access to this method
        void Nap()
        {
            Console.WriteLine("ZzzzZZzzzZzz");
        }
    }
}
