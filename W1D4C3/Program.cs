using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D4C3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that takes two strings from the user and outputs a string.

            NamesStrings namesStrings = new NamesStrings();

            Console.WriteLine("Hello. My name is Skippy, what is your name?");

            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");

            string lastName = Console.ReadLine();

            Console.WriteLine($"It's Nice to meet you {namesStrings.YourName(firstName, lastName)}");

            Console.ReadLine();
            
           
           

        }


    }
}
