using System;

namespace MethodsAssignment
{
    class Program
    {
        public static void ShortStory()
        {
            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");

            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");

            var color = Console.ReadLine();

            Console.WriteLine("Who is your favorite relative?");

            var relative = Console.ReadLine();

            Console.WriteLine($"My name is {name} and my favorite animal is a {animal}. Especially a {color} {animal}." +
                $" I especially love it when my {color} {animal} chases my {relative} around the house.");
        }

        static void Main(string[] args)
        {
            ShortStory();

            Console.WriteLine(Add(6, 7));

            Console.WriteLine(Subtract(12, 8));

            Console.WriteLine(Multiply(17, 19));

            Console.WriteLine(Divide(15, 5));

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }



        

    }
}
