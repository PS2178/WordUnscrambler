using System;
using System.Collections.Generic;
using System.Text;

namespace WordUnscrambler
{
    class Program
    {
        public const string someText = "This is some text";

        public static readonly string someOtherText = "This is some other text";

        public static readonly Person someOtherPerson = new Person("A", "B");

        static void Main(string[] args)
        {
            Console.WriteLine(someText);
            Console.WriteLine(someOtherText);
        }

        //static void ChangeName(Person personToChange)
        //{
        //    personToChange.FirstName = "Jane";
        //    personToChange.LastName = "Doe";
        //}

    }
}
