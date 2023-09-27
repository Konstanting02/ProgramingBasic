using System;

namespace ConcatenateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
           string sursname = Console.ReadLine();
            
            string age = Console.ReadLine();
            string town = Console.ReadLine();
            Console.WriteLine($"You are {name} {sursname}, a {age}-years old person from {town}. ");
        }
    }
}
