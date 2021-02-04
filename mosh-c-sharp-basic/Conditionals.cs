using System;

namespace mosh_c_sharp_basic
{
    public class Conditionals
    {
        public static void Exercise1()
        {
            Console.WriteLine("Please enter a number between 1 and 10: ");
            var input = Console.ReadLine();
            var answer = Convert.ToInt32(input);
            var message = (answer >= 1 && answer <= 10) ? "Valid" : "Invalid";

            Console.WriteLine(message);
        }

        public static void Exercise2()
        {
            Console.WriteLine("Please enter a number: ");
            var inputA = Console.ReadLine();

            Console.WriteLine("\n Another number please: ");
            var inputB = Console.ReadLine();

            var num1 = Convert.ToInt32(inputA);
            var num2 = Convert.ToInt32(inputB);

            var greater = (num1 > num2) ? num1 : num2;
            Console.WriteLine(String.Format("\n{0} is the greater number.", greater));
        }

        public static void Exercise3()
        {
            Console.WriteLine("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine(String.Format("Image is in {0} mode.", orientation));

        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        public static void Exercise4()
        {
            Console.WriteLine("Speed limit: ");
            var limitado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vehicle speed: ");
            var vehiculo = Convert.ToInt32(Console.ReadLine());

            if(limitado > vehiculo)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var demerits = (vehiculo - limitado) / 5;
                if(demerits <= 12)
                {
                    Console.WriteLine("Total demerits: " + demerits);
                }
                else
                {
                    Console.WriteLine("License suspended");
                }
            }
        }
    }
}
