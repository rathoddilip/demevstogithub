using System;

namespace controlStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whether number is greater or less than 10");
            int number1, number2;
            Console.WriteLine("Enter a number1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number2");
            number2 = Convert.ToInt32(Console.ReadLine());
           
            if (number1 + number2 > 10)
            {
                Console.WriteLine("The number is greater than 10");
            }
            else
            {
                Console.WriteLine("The number is not greater than 10");
            }

        }
    }
}
