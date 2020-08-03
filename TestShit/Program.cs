using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShit
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mountainName = "Mauna Kea";

            // foreach (string character in mountainName)

            // {

            ///   Console.WriteLine(character);

            //}

            //What would be the Console output of this if else statement ?

            int age = 23;

            if (age <= 18)

            {

                Console.WriteLine($"You are: {age}.");

            }

            else if (age > 18 && age <= 35)

            {

                Console.WriteLine($"How are you? You are: {age}.");

            }

            else

            {

                Console.WriteLine("...");

            }
            Console.ReadLine();
        }
    }
}
