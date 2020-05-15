using System;

namespace SkaraItseyChallenge1 {
    class Program {
        static void Main(string[] args) {
            var name = "";


            while (name != "itsey") {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();

                if (name != "itsey") {
                    Console.WriteLine("You are not authorised {0}", name);
                }
            }
            Console.WriteLine("Welcome back {0}", name);
        }
    }
}
