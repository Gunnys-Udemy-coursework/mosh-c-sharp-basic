using System;
using System.Collections.Generic;

namespace mosh_c_sharp_basic
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.Clear();
            //Console.WriteLine("Hello World!");

            ////primitive types
            //var number = 1;
            //var count = 10;
            //var totalPrice = 20.95f;
            ////Non-primitive types
            //var character = 'a';
            //var fName = "That";
            //var fact = true;

            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(fName);
            //Console.WriteLine(fact);

            ////Using string formatter
            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            ////Conversion examples
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            ////Try-Catch example
            //try
            //{
            //    var num = "1234";
            //    int j = Convert.ToInt32(num);
            //    Console.WriteLine(j);

            //    //var num converted will exceed the max value for byte (255)
            //    byte aByte = Convert.ToByte(num);
            //}
            ////aByte will trigger this catch and the resulting message
            //catch (Exception)
            //{
            //    Console.WriteLine("Number no good for byte.");
            //}

            ////Operators
            //var m = 6;
            //var n = 9;
            //var p = 12;

            ////Arithmetic
            //Console.WriteLine(m + n);
            //Console.WriteLine(m - n);
            //Console.WriteLine((float)m / (float)n);
            //Console.WriteLine(m * n);

            ////Order of Precedence
            //Console.WriteLine(p - n * m);
            //Console.WriteLine((p - n) * m);

            ////Comparison operators; boolean result
            //Console.WriteLine(m > n);
            //Console.WriteLine(n != p);
            //Console.WriteLine(!(m != n));
            //Console.WriteLine(p > n && n > m);
            //Console.WriteLine(n > m && n == p);
            //Console.WriteLine(n != p || p > m);

            ////Single comment

            ///*
            // Multi-line comment
            //*/

            ////Instance of person class
            //var ryan = new Person();
            //ryan.firstName = "Ryan";
            //ryan.lastName = "Kendall";
            //ryan.Age = 20;
            //ryan.Introduce();

            //MakeOld(ryan);
            //Console.WriteLine(ryan.Age + "\n");

            ////Arrays
            //var flags = new bool[3] { true, false, true };
            //var names = new string[3] { "Larry", "Moe", "Curly" };


            ///*
            //Important! When setting a variable that is non-primitive,
            //it is a reference type and is a class (vs structure).
            //The allocated memory address will hold the actual values.
            //The value stored for the variable will be said allocated memory address.
            //So if you set a non-primitive (reference type) variable to equal another,
            //they will hold the same value; the allocated memory address.
            //Therefore if you change the contents within that address, it
            //changes it for both variables!
            //*/
            //var numbers = new int[3] { 1, 2, 3 };
            //var moreNumbers = numbers;

            ///*
            // This will change the value of index position 0 to zero for 
            // both moreNumbers and numbers!
            // */
            //moreNumbers[0] = 0;

            ////Strings
            //var marineBase = "Camp Pendleton";
            //var lName = "Guy";

            //var aName = string.Format("{0} {1}", fName, lName);
            //var sameName = fName + " " + lName;

            ////Joining elements of an array
            //var theFellas = string.Join(", ", names);

            //Console.WriteLine(theFellas);

            ////Concat and newline escape characters
            //var message = "At " + marineBase + " is " + aName + ".\nHe is stationed with: \n" + theFellas + ".";
            ////Same result as above using different format

            ////Verbatim string
            //var anotherMessage = @"Check this out.
            //No escape character needed.
            //To go to a new line.";

            //Console.WriteLine(message + "\n");
            //Console.WriteLine(string.Format("At {0} is {1}.\nHe is stationed with:\n{2}", marineBase, aName, theFellas));
            //Console.WriteLine("\n");
            //Console.WriteLine(anotherMessage);

            ////Enums
            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);
            //Console.WriteLine(method.ToString());

            //var setMethod = 2;
            //Console.WriteLine((ShippingMethod)setMethod);

            //var anotherMethod = "Express";
            //var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), anotherMethod);

            ////if-else
            //int hour = 10;

            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("Buenos dias");
            //}
            //else if (hour > 12 && hour < 18)
            //{
            //    Console.WriteLine("Buenas tardes");
            //}
            //else
            //{
            //    Console.WriteLine("Buenas noches");
            //}

            //bool isGoldCustomer = true;
            //float price;

            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}
            //Console.WriteLine("Price: $" + price);

            ////Conditional operator
            //float cost = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine("Cost: $" + cost);

            ////Switch
            //var season = Season.Fall;

            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("Flowers are blooming!");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("Time to BBQ and go for a swim!");
            //        break;
            //    case Season.Fall:
            //        Console.WriteLine("All the leaves are brown..");
            //        break;
            //    default:
            //        Console.WriteLine("Old man winter is upon us.");
            //        break;
            //}

            //switch (season)
            //{
            //    case Season.Fall:
            //    case Season.Winter:
            //        Console.WriteLine("Don't forget your coat and hat!");
            //        break;
            //    case Season.Spring:
            //        Console.WriteLine("Might need an umbrella.");
            //        break;
            //    default:
            //        Console.WriteLine("Grab some sunscreen!");
            //        break;
            //}


            //Conditionals.Exercise1();
            //Conditionals.Exercise2();
            //Conditionals.Exercise3();
            //Conditionals.Exercise4();

            ////Loops

            ////For
            //for (var anI = 1; anI <= 10; anI++)
            //{
            //    if (anI % 2 == 0)
            //    {
            //        Console.WriteLine(anI);
            //    }
            //}

            ////Foreach
            //var title = "Gunnery Sergeant";

            //foreach (var letter in title)
            //{
            //    Console.WriteLine(letter);
            //}

            //var nums = new int[] { 1, 2, 3, 4 };
            //foreach (var num in nums)
            //{
            //    Console.WriteLine(num);
            //}

            ////While
            //var counter = 0;
            //while (counter <= 10)
            //{
            //    if (!(counter % 2 == 0))
            //    {
            //        Console.WriteLine(counter);
            //        counter++;
            //    }
            //    else
            //    {
            //        counter++;
            //    }
            //}

            //while (true)
            //{
            //    Console.Write("Enter name: ");
            //    var input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("Welcome " + input);
            //    break;
            //}

            //var random = new Random();

            //const int bufferLength = 10;

            //var buffer = new char[bufferLength];

            //for (var aK = 0; aK < bufferLength; aK++)
            //{
            //    buffer[aK] = (char)('a' + random.Next(0, 26));
            //}

            //var password = new string(buffer);

            //Console.WriteLine(password);

            //Loops.Exercise1();
            //Loops.Exercise2();
            //Loops.Exercise3();
            //Loops.Exercise4();

            ////Arrays
            //var numbers2 = new int[] { 3, 7, 9, 2, 14, 6 };

            ////Indexof (ex = 2)
            //var index = Array.IndexOf(numbers2, 9);

            ////Clear (ex will set the first two indices to zero
            //Array.Clear(numbers2, 0, 2);

            ////Copy ( ex. will populate arrayTwo with the first 3 indices of numbers
            //var arrayTwo = new int[3];
            //Array.Copy(numbers2, arrayTwo, 3);

            ////Sort() (ex will sort the values in numbers; low to high)
            //Array.Sort(numbers2);

            ////Reverse (ex will reverse the values in the array)
            //Array.Reverse(numbers2);

            ////Lists
            //var nums2 = new List<int> { 1, 2, 3, 4 };

            ////Add
            //nums2.Add(1);

            ////Add a range of values
            //nums2.AddRange(new int[3] { 5, 6, 7 });

            ////IndexOf; only returns first index of a given value
            //Console.WriteLine(nums2.IndexOf(1)); // 0

            ////LastIndexOf
            //Console.WriteLine(nums2.LastIndexOf(1)); // 4

            ////Count; returns number of values in the list
            //Console.WriteLine(nums2.Count); // 8

            ////Remove; only removes first index of a given value
            //nums2.Remove(1); //Removes first 1; not all 1s

            ////To remove all indices of a certain value a for loop can be used;
            //// NOTE: foreach loop will throw an error!
            //for (var li = 0; i < nums2.Count; i++)
            //{
            //    if (nums2[li] == 1)
            //    {
            //        nums2.Remove(nums2[li]);
            //    }
            //}

            ////Clear; removes everything from the list
            //nums2.Clear();

            //ArrayExercise1();
            //ArrayExercise2();
            //ArrayExercise3();
            ArrayExercise4();
        }

       

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
                else {
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

            for(int i = name.Length -1; i >= 0; i--)
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

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }

}
