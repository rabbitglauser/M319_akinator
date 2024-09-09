using System;

namespace SimpleAkinator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of an animal, and I will try to guess it!");
            Console.WriteLine("Answer with 'yes' or 'no'.");

            if (AskQuestion("Does it live in water?"))
            {
                if (AskQuestion("Is it a mammal?"))
                {
                    Console.WriteLine("Is it a dolphin?");
                }
                else
                {
                    Console.WriteLine("Is it a fish?");
                }
            }
            else
            {
                if (AskQuestion("Can it fly?"))
                {
                    Console.WriteLine("Is it a bird?");
                }
                else
                {
                    if (AskQuestion("Is it a pet?"))
                    {
                        if (AskQuestion("Does it bark?"))
                        {
                            Console.WriteLine("Is it a dog?");
                        }
                        else
                        {
                            Console.WriteLine("Is it a cat?");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Is it a lion?");
                    }
                }
            }

            Console.WriteLine("Thank you for playing!");
        }

        static bool AskQuestion(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine().ToLower();

            return response == "yes";
        }
    }
}