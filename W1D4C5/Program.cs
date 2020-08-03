using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D4C5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an if else statement that uses a boolean to check if the user is happy. You can start off with something like: bool happy = true;


            Console.WriteLine("Are you happy to be learning C# Ben, yes or no?");
            bool feelings = true;
            string benFeelings = feelings.ToString();
            benFeelings = Console.ReadLine();
            //Console.WriteLine(benFeelings);

            if (benFeelings == "yes")
            {
                Console.WriteLine("That's good, cuz you got a long way to go bro!");
            }
            else
            {
                Console.WriteLine("You better pull your head of of your ass and start liking is cuz you got a long way to go bro!");
            }

            Console.WriteLine("On a scale from 1 to 5. 5 being the best, how are you feeling today Ben?");
            string feelingScale = Console.ReadLine();

            if (feelingScale == "1")
            {
                Console.WriteLine("Dang bro you must be trying to learn how to code at the ripe old age of 47!");
            }

            if (feelingScale == "2")
            {
                Console.WriteLine("Do you need and Annie hug. She is the bestest hugger ever!");
            }
            if (feelingScale == "3")
            {
                Console.WriteLine("There is nothing wrong with a 3. You just need to keep moving forward bro.");
            }
            if (feelingScale == "4")
            {
                Console.WriteLine("4 is not bad... Maybe you will get lucky this weekend and jump to a 5!");
            }
            if (feelingScale == "5")
            {
                Console.WriteLine("Did you wife promise you some action this weekend... Well done Mr. Man!");
            }
            else
            {
                Console.WriteLine("I am speachless... I hope you have a great day!");
            }


        }
    }
}
