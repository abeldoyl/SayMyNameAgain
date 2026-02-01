/*
Abel Doyle
2265
Spring Semester 2026
SayMyName
https://github.com/abeldoyl/SayMyName.git
*/

namespace SayMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "name";

            Console.WriteLine("What's your Name");
            userInput = Console.ReadLine();
            Console.WriteLine($"Hello {userInput}");

            Console.Read();
        }
    }
}