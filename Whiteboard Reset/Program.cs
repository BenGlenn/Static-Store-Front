using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moneyIn = true;

            while (moneyIn)
            {
                Console.WriteLine("How much money do you have in the back now?");
                int yearSalary = int.Parse(Console.ReadLine());

                if (yearSalary >= 1000 && yearSalary <= 10000)
                {
                    Console.WriteLine("That's not bad, but it's not enough to buy that new deluxe LEGO... You're goiong to need at least 11k.");
                }
                else
                {
                    if ((yearSalary >= 11000 && yearSalary <= 50000))
                    {
                        Console.WriteLine("That's a nice chunk of change... You want to take me on a vacation?");
                    }
                    if ((yearSalary >= 51000 && yearSalary <= 100000))
                    {
                        Console.WriteLine("Can I barrow 50 bucks?");
                    }
                    else
                    {
                        Console.WriteLine("You might want to get a job");
                    }
                }
           
                if (yearSalary > 0)
                {
                    continue;
                }
                break;
            }
            Console.ReadLine();



        }
    }
}
