using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}, what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is my favorite as well!  What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Awesome! What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Congratulations, {userName}!");
            Console.WriteLine("You have been selected to be the FIRST to recieve a brand");
            Console.WriteLine("new Intergalactic Travel Portal.");
            Console.WriteLine($"Your brand new portal will be in your favorite color, {color}.");
            Console.WriteLine($"We will even throw in a free {animal} costume.");
            Console.WriteLine("Also, for your first trip we will be sending you to");
            Console.WriteLine($"see {band} play the first live concert on Mars!");
        }
    }
}
