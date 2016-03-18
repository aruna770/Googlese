using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Googlese
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Googlese Translator...enter 'exit' to end");
            string input = Console.ReadLine();

            while (input.ToLower() != "exit")
            {
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a valid input string.");
                }
                else
                {
                    Translator translator = new Translator();
                    string output = translator.Translate(input);

                    Console.WriteLine(output);
                }
                input = Console.ReadLine();
            }

        }
    }
}
