﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

            //ArraysLists.ArrayExercise1();
            //ArraysLists.ArrayExercise2();
            //ArraysLists.ArrayExercise3();
            //ArraysLists.ArrayExercise4();
            //ArraysLists.ArrayExercise5();

            //Dates and Times
            //Creating
            //var dateTime = new DateTime(2021, 02, 09);
            //var now = DateTime.Now;
            //Console.WriteLine(now.Hour);
            //var today = DateTime.Today;

            //var tomorrow = now.AddDays(1);

            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.ToShortDateString());
            //Console.WriteLine(now.ToString());
            //Console.WriteLine(now.ToString("g"));

            //var timeSpan = new TimeSpan(1, 2, 3);
            //var diffTime = TimeSpan.FromHours(1);
            //var start = DateTime.Now;
            //var end = DateTime.Now.AddMinutes(2);
            //var duration = end - start;
            //Console.WriteLine("Duration: " + duration);

            ////Properties
            //Console.WriteLine("Minutes: " + timeSpan.Minutes);
            //Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);

            ////Add - Subtract
            //Console.WriteLine("Add: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            //Console.WriteLine("Subtract: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            ////To String
            //Console.WriteLine("To String: " + timeSpan.ToString());

            //String Methods
            //var fullName = "That Guy ";
            //Console.WriteLine("Trimmed: " + fullName.Trim());
            //Console.WriteLine("To Upper and trimmed: " + fullName.Trim().ToUpper());

            //var index = fullName.IndexOf(" ");
            //var firstName = fullName.Substring(0, index);
            //var lastName = fullName.Substring(index + 1);

            //var names = fullName.Split(' ');
            //var first = names[0];
            //var last = names[1];

            //var trimmedName = fullName.Replace(" ", "");
            //Console.WriteLine(trimmedName);

            //float price = 29.95f;
            //Console.WriteLine(price.ToString("C2"));

            ////Summarising text
            //var sentence = "Yadda, yadda, yadda and it goes on and on and on.";
            //var summary = StringsText.SummarizeText(sentence);
            //Console.WriteLine(summary);

            ////String Builder
            //var builder = new StringBuilder();
            //builder.Append('-', 10);
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('-', 10);
            //Console.WriteLine(builder);

            //builder.Replace('-', '+');
            //builder.Remove(0, 10); //index: 0, for 10 chars
            //builder.Insert(0, new string('*', 10));
            //Console.WriteLine(builder);

            //Console.WriteLine(builder[0]);

            //var cleanerBuild = new StringBuilder();
            //cleanerBuild
            //    .Append('-', 10)
            //    .AppendLine()
            //    .Append("Header")
            //    .AppendLine()
            //    .Append('-', 10);
            //Console.WriteLine(cleanerBuild);

            //System.IO
            //File.Copy("from where", "to where");
            //File.Delete("file path");
            //if(File.Exists("file path")) {
            //    //some code
            //}


        }

       

        
    

    public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }

}
