using System;
namespace mosh_c_sharp_basic
{
    public class Loops
    {
        public static void Exercise1()
        {
            var modulus3 = 0;

            for (var anL = 1; anL <= 100; anL++)
            {
                if (anL % 3 == 0)
                {
                    modulus3++;
                }
            }
            Console.WriteLine("Mod3 count = " + modulus3);
        }

        public static void Exercise2()
        {
            var sum = 0;

            while (true)
            {
                Console.Write("Enter a number or ok to quit: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    Console.WriteLine("Sum total: " + sum);
                    break;
                }
                sum += Convert.ToInt32(input);
                
            }
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var choice = input;
            var factorized = 1;

            do
            {
                factorized *= input;
                input--;

            } while (input != 0);

            Console.WriteLine(String.Format("{0}! = {1}", choice, factorized));
        }

        public static void Exercise4()
        {
            const int chances = 4;
            var guesses = 1;
            var random = new Random();
            var winner = random.Next(1, 10);
            var input = 0;

            do
            {
                Console.WriteLine("Pick a number between 1 and 10: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == winner)
                {
                    Console.WriteLine("You won!");
                    break;
                }else if(guesses == chances)
                {
                    Console.WriteLine("You Lost!");
                    Console.WriteLine("The number was " + winner);
                    break;
                }

                guesses += 1;

            } while (guesses <= chances);

        }
    }
}
