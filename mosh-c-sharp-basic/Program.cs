using System;

namespace mosh_c_sharp_basic
{
    //Enum: collection of constants; ints unless cast otherwise ex. : byte
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisterAirMail = 2,
        Express = 3,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //primitive types
            var number = 1;
            var count = 10;
            var totalPrice = 20.95f;
            //Non-primitive types
            var character = 'a';
            var fName = "That";
            var fact = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(fName);
            Console.WriteLine(fact);

            //Using string formatter
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //Conversion examples
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            //Try-Catch example
            try
            {
                var num = "1234";
                int j = Convert.ToInt32(num);
                Console.WriteLine(j);

                //var num converted will exceed the max value for byte (255)
                byte aByte = Convert.ToByte(num);
            }
            //aByte will trigger this catch and the resulting message
            catch(Exception)
            {
                Console.WriteLine("Number no good for byte.");
            }

            //Operators
            var m = 6;
            var n = 9;
            var p = 12;

            //Arithmetic
            Console.WriteLine(m + n);
            Console.WriteLine(m - n);
            Console.WriteLine((float)m / (float)n);
            Console.WriteLine(m*n);

            //Order of Precedence
            Console.WriteLine(p - n * m);
            Console.WriteLine((p - n) * m);

            //Comparison operators; boolean result
            Console.WriteLine(m > n);
            Console.WriteLine(n != p);
            Console.WriteLine(!(m != n));
            Console.WriteLine(p > n && n > m);
            Console.WriteLine(n > m && n == p);
            Console.WriteLine(n != p || p > m);

            //Single comment

            /*
             Multi-line comment
            */

            //Instance of person class
            var ryan = new Person();
            ryan.firstName = "Ryan";
            ryan.lastName = "Kendall";
            ryan.Age = 20;
            ryan.Introduce();

            MakeOld(ryan);
            Console.WriteLine(ryan.Age + "\n");

            //Arrays
            var flags = new bool[3] { true, false, true };
            var names = new string[3] { "Larry", "Moe", "Curly" };


            /*
            Important! When setting a variable that is non-primitive,
            it is a reference type and is a class (vs structure).
            The allocated memory address will hold the actual values.
            The value stored for the variable will be an allocated memory address.
            So if you set a non-primitive (reference type) variable to equal another,
            they will hold the same value; the allocated memory address.
            Therefore if you change the the contents within that address, it
            changes it for both variables!
            */
            var numbers = new int[3] { 1, 2, 3 };
            var moreNumbers = numbers;
            
            /*
             This will change the value for index position 0 to zero in 
             both moreNumbers and numbers!
             */ 
            moreNumbers[0] = 0;

            

            //Strings
            var marineBase = "Camp Pendleton";
            var lName = "Guy";

            var aName = string.Format("{0} {1}", fName, lName);
            var sameName = fName + " " + lName;

            //Joining elements of an array
            var theFellas = string.Join(", ", names);

            Console.WriteLine(theFellas);

            //Concat and newline escape characters
            var message = "At " + marineBase + " is " + aName + ".\nHe is stationed with: \n" + theFellas + ".";
            //Same result as above using different format
  
            //Verbatim string
            var anotherMessage = @"Check this out.
No escape character needed.
To go to a new line.";

            Console.WriteLine(message + "\n");
            Console.WriteLine(string.Format("At {0} is {1}.\nHe is stationed with:\n{2}", marineBase, aName, theFellas));
            Console.WriteLine("\n");
            Console.WriteLine(anotherMessage);

            //Enums
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            Console.WriteLine(method.ToString());

            var setMethod = 2;
            Console.WriteLine((ShippingMethod)setMethod);

            var anotherMethod = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), anotherMethod);


        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }

}
