using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
                string vowels = "halfnorsemix";

                if (vowels.IndexOf(letter) == -1) 
                {
                    System.Console.WriteLine("Give me a " + letter);
                }
                else
                {
                    System.Console.WriteLine("Give me an " + letter);
                }
            }

            char capLetter = System.Char.ToUpper(name[0]);
            

            System.Console.WriteLine(capLetter + name.Substring(1) + " is Awesome!");
            System.Console.WriteLine("Hey " + capLetter + name.Substring(1) + " What's your birthday? Enter as mm/dd");
            string userInput = System.Console.ReadLine();
            DateTime birthday = Convert.ToDateTime(userInput);
            DateTime now = DateTime.Now.Date;
            //System.Console.WriteLine("Your birthday is on " + birthday);
            //System.Console.WriteLine("Today's date is " + now);
            TimeSpan daysTo = birthday - now;
            int days = daysTo.Days;

            if (days < 0)
            {
                days = days + 365;
            }
           
            System.Console.WriteLine("It is " + days + " days until your birthday");

    

            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadLine();
        }
    }
}
