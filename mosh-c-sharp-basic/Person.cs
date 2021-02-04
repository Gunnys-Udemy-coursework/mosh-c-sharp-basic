using System;

namespace mosh_c_sharp_basic
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("Hello, I am " + firstName + " " + lastName + "\n");
        }

       
    }

}
