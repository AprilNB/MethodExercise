﻿using System;

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

        }
    }
}