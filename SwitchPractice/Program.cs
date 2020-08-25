using System;

namespace SwitchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "english":
                    Console.WriteLine("Ew why would you like that");
                    break;
                case "math":
                    Console.WriteLine("Ok math is tough but doable");
                    break;
                case "science":
                    Console.WriteLine("Yea science is pretty cool");
                    break;
                case "history":
                    Console.WriteLine("Yay that was my favorite subject as well");
                    break;
                case "gym":
                    Console.WriteLine("Yea thats not really a subject and you know it");
                    break;
                default:
                    Console.WriteLine("Is that even really a class?");
                    break;
            
            
            
            
            
            }
        }
    }
}
