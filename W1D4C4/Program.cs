using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D4C4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a switch case that asks the user if they are wearing clothes.
            Console.WriteLine("Ben, yes or no, are you wearing cloths today? I think I am seeing a little more than I would like...");

            String clothingOption = Console.ReadLine();

            switch (clothingOption)
            {
                case "Yes":
                    Console.WriteLine("I'm sorry my mistack.");
                    break;
                case "No":
                    Console.WriteLine("Do you mind putting on a towel or something?");
                    break;
                default:
                    Console.WriteLine("I don't understand.");
                    break;
            }

        }
    }
}
