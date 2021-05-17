using System;

namespace MethodExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;
        }

        public static int Modulus(int num1, int num2)
        {
            var answer = num1 % num2;
            return answer;
        }

        static void Main(string[] args)
        {

            var amountOfPowerups = Sum(2, 6);
            var amountOfSun = Subtract(3, 12);
            var amountOfZombies = Multiply(60, 2, 4);
            var amountOfPlants = Divide(4, 14);
            var amountOfCoins = Modulus(3, 30);

            //----------------------Exercise 1--------------------------------------------------

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

            //-----------------------Exercise 2-------------------------------------------------


        }
    }
}
