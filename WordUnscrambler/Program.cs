using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a text file and saves all contents of the string array 
            string[] lines = { "This is the first line", "This is the second line", "This is the third line" };
            File.WriteAllLines("MyFirstFile.txt", lines);

            string[] fileContents = File.ReadAllLines("MyFirstTextFile.txt");

            foreach(string line in File.ReadLines("MyFirstFile.txt"))
            {
                Console.WriteLine(line);
            }
        }
    }
}
