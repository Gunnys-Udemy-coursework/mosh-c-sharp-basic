using System;

namespace mosh_c_sharp_basic
{
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
            var fName = "that";
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


        }
    }
}
