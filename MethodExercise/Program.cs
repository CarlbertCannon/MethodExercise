using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("What is your favorite color?");
            //string favColor = Console.ReadLine();

            //Console.WriteLine("What is your favorite animal?");
            //string favAnimal = Console.ReadLine();

            //Console.WriteLine("What is your favorite band?");
            //string favBand = Console.ReadLine();

            //Console.WriteLine($"There once was a man named, {userName}, he was proud of his {favColor}, {favAnimal}.");
            //Console.WriteLine($"It was the same color as the mascot for his favorite band, {favBand}.");
            //Console.WriteLine($"{userName}, never missed an opportunity to see {favBand}.");
            //Console.WriteLine($"He would often take his {favAnimal} with him.");

            Console.WriteLine($"What number would you like me to add?");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"What other number would you like me to add to this?");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine($"What would you like me to multiply?");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"What other number would you like me to multiply by?");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

        }
        public static int Sum(params int[] list)
    {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
    }
        public static int Multiply(int x, int y) 
        {

            return x * y; 

        }
    }
}
