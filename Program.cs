using System;

namespace DoYouLikePizza
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            bool pizzaOrNot;
            string pizzaResponse;
                        
            Console.WriteLine("What is your name? ");
            userName = Console.ReadLine();

            Console.WriteLine("Do you like pizza? ");
            pizzaResponse = Console.ReadLine();

            if (pizzaResponse == "yes")
            {
                pizzaOrNot = true;
                Console.WriteLine(userName + " likes pizza!");
            }
            else
            {
                Console.WriteLine(userName + " does not like pizza!");
            }
        }
    }
}
