using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello there, what's your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Hi, " + name);

            foreach (char letter in name)
            {
                if (System.Char.ToUpper(letter).Equals('A') || System.Char.ToUpper(letter).Equals('E') || System.Char.ToUpper(letter).Equals('I') || System.Char.ToUpper(letter).Equals('O') || System.Char.ToUpper(letter).Equals('U'))
                {
                    System.Console.WriteLine("Give me an " + letter);
                }
                else
                {
                    System.Console.WriteLine("Give me a " + letter);
                }
            }

            char capLetter = System.Char.ToUpper(name[0]);
            

            System.Console.WriteLine(capLetter + name.Substring(1) + " is Awesome!");

            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadLine();
        }
    }
}
