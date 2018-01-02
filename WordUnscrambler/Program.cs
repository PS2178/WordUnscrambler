using System;
using System.Collections.Generic;
using System.Text;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("John", "Smith");

            Person person = new Person("John", "Smith");

            // ?? null coalescing operator
            Person newPerson = person ?? new Person("Default", "Person");

            //ChangeName(person);

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);

            Console.ReadLine();
        }

        static void ChangeName(Person personToChange)
        {
            personToChange.FirstName = "Jane";
            personToChange.LastName = "Doe";
        }

        // demonstrating ref types
        static void ChangeNumber(ref int a)
        {
            a = 90;
        }
    }
}
