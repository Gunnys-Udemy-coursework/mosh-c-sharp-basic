using System;
using System.Collections.Generic;

namespace mosh_c_sharp_basic
{
    public class ArraysLists
    {
        public static void ArrayExercise1()
        {
            var friends = new List<string>();
            var reprompt = true;
            do
            {
                Console.WriteLine("Enter a name or leave blank to end: ");
                var friendName = Console.ReadLine();
                if (string.IsNullOrEmpty(friendName))
                {
                    reprompt = false;
                    break;
                }
                else
                {
                    friends.Add(friendName);
                }
            } while (reprompt);

            var message = "";
            switch (friends.Count)
            {
                case 0:
                    break;
                case 1:
                    message = string.Format("{0} likes your post.", friends[0]);
                    break;
                case 2:
                    message = string.Format("{0} and {1} like your post.", friends[0], friends[1]);
                    break;
                default:
                    message = string.Format("{0}, {1} and {2} others like your post.", friends[0], friends[1], friends.Count - 2);
                    break;
            }

            Console.WriteLine(message);
        }

        public static void ArrayExercise2()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var nameArray = new char[name.Length];
            var j = 0;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                nameArray[j] = name[i];
                j++;
            }

            var reversed = new string(nameArray);
            Console.WriteLine(reversed);
        }

        public static void ArrayExercise3()
        {
            var numbers = new int[5];
            var count = 0;
            int choice;

            while (count < 5)
            {
                Console.WriteLine("Enter a number: ");
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {

                    choice = Convert.ToInt32(input);

                    if (Array.IndexOf(numbers, choice) == -1)
                    {
                        numbers[count] = choice;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }

            Array.Sort(numbers);

            for (var i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        public static void ArrayExercise4()
        {
            var numbers = new List<int>();
            var uniqueNums = new List<int>();
            var carryOn = true;

            while (carryOn)
            {
                Console.WriteLine("Enter a number or Quit: ");
                var input = Console.ReadLine();
                if (input.Equals("Quit"))
                {
                    carryOn = false; ;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                }
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                if (uniqueNums.IndexOf(numbers[i]) == -1)
                {
                    uniqueNums.Add(numbers[i]);
                }
            }

            for (var j = 0; j < uniqueNums.Count; j++)
            {
                Console.Write(uniqueNums[j] + " ");
            }
        }

        public static void ArrayExercise5()
        {
            string[] elements;

            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                    {
                        break;
                    }
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();

            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var smallest = new List<int>();
            while (smallest.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallest.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallest)
                Console.WriteLine(number);
        }
    }
}
