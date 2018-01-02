using System;
using System.Collections.Generic;
using System.Text;

namespace WordUnscrambler
{
    public class Person
    {
        public Person(string argFirstName, string argLastName)
        {
            FirstName = argFirstName;
            LastName = argLastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
