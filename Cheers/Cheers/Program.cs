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

            foreach (char letter in name.ToLower())
            {
                string vowels = "halfnorsemix";

                if (Char.IsLetter(letter))
                {
                    if (vowels.Contains(letter) == false)
                    {
                        System.Console.WriteLine("Give me a " + letter);
                    }
                    else
                    {
                        System.Console.WriteLine("Give me an " + letter);
                    }
                }
            }
            char capLetter = System.Char.ToUpper(name[0]);
            System.Console.WriteLine(capLetter + name.Substring(1).ToUpper() + " is Awesome!");
            string formattedName = capLetter + name.Substring(1);
            System.Console.WriteLine("Hey " + formattedName + " What's your birthday? Enter as mm/dd");
            BirthdayCheer(formattedName);
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadLine();
        }

        private static void BirthdayCheer(string formattedName)
        {
            string userInput = System.Console.ReadLine();
            DateTime birthday = Convert.ToDateTime(userInput);
            DateTime now = DateTime.Now.Date;
            TimeSpan daysTo = birthday - now;
            int days = daysTo.Days;

            if (days < 0)
            {
                days = days + 365;
                System.Console.WriteLine("It is " + days + " days until your birthday");
            }
            else
            {
                System.Console.WriteLine("It is " + days + " days until your birthday");
            }

            if (birthday == now)
            {
                System.Console.WriteLine("Happy Birthday " + formattedName);
            }
        }
    }
}
