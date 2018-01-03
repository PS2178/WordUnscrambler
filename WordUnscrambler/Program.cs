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
            bool continueWordUnscramble = true;
            do
            {
                Console.WriteLine("Please enter the option - F for File and M for Manual");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words file name: ");
                        ExecuteScrambledWordsInFileScenario();
                        break;
                    case "M":
                        Console.Write("Enter scrambled words manually: ");
                        ExecuteScrambledWordsManuallyEntryScenario();
                        break;
                    default:
                        Console.Write("Option was not recognized.");
                        break;
                }

            } while{ };
        }

        private static void ExecuteScrambledWordsInFileScenario()
        {
            throw new NotImplementedException();
        }
    }
}
