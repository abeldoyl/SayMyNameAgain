/*
Abel Doyle
2265
Spring Semester 2026
SayMyName
https://github.com/abeldoyl/SayMyNameAgain.git
*/

using System;

namespace SayMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.WriteLine("What's your name?");
            userInput = Console.ReadLine();

            if (userInput == "Emily" || userInput == "Joe")
            {
                Console.WriteLine($"Hello, {userInput}!");
            }
            else if (userInput == "Abel")
            {
                Console.WriteLine("Hey Abel!");
                Console.Beep(293, 150);
                Console.Beep(293, 150);
                Console.Beep(587, 250);
                Console.Beep(440, 360);
                Console.Beep(415, 250);
                Console.Beep(392, 250);
                Console.Beep(349, 250);
                Console.Beep(293, 130);
                Console.Beep(349, 130);
                Console.Beep(392, 130);
                Console.Beep(261, 140);
                Console.Beep(261, 120);
                Console.Beep(587, 250);
                Console.Beep(440, 370);
                Console.Beep(415, 250);
                Console.Beep(392, 250);
                Console.Beep(349, 250);
                Console.Beep(293, 130);
                Console.Beep(349, 130);
                Console.Beep(392, 130);
            }
            else if (userInput == "Tim")
            {
                Console.WriteLine($"Hello Great Wizard \"{userInput}\"");
                Console.Write("Enjoy");
                Console.Beep(1000, 700);
                Console.Beep(500, 1500);
            }

            else
            {
                Console.WriteLine($"Hello there! \"{userInput}\" Nice to meet you.");
            }

            Console.Read();
        }
    }
}
