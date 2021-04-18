using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print a message to the user that welcomes them to your application

            Console.WriteLine("Welcome to Tim's Vacation Budget Planner!\n");


            //Prompt the user for their name

            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();

            /*
            * Prompt the user with a welcome message that greets them by name 
            * and asks them from which of the two options would they like to travel
            */
            Console.WriteLine($"Hello {userName}!  Where would you like to go, Mexico or Japan?");

            //End of Week 1 steps.

            //Leave the console open
            Console.ReadLine();
        }
    }
}
