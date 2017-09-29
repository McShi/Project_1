using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine().Trim();
            firstName = firstName.ToLower();

            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine().Trim();
            lastName = lastName.ToLower();

            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born? Two digits, please.");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Gimme your fav ROYGBIV.If you're confused, enter 'Help' for assistance.");
            string favColor = Console.ReadLine().Trim();
            favColor = favColor.ToLower();

            if (favColor == "help")
            {
                Console.WriteLine("ROYGBIV means Red, Orange, Yellow, Green, Blue, Indigo and Violet");
                Console.WriteLine("Please re-enter one of the listed colors.");
                favColor = Console.ReadLine().Trim().ToLower();

            }
            else
            {
                Console.WriteLine();
            }

            Console.WriteLine("How many siblings do you have?");
            int userSiblings = int.Parse(Console.ReadLine());

            string retirementYears;

            if (userAge / 2 == 0)
            {
                retirementYears = "7 years";
            }
            else
            {
                retirementYears = "8 years";
            }

            string retirementFunds;

            if (birthMonth <= 4)
            {
                retirementFunds = "$25";
            }
            else if (birthMonth > 4 && birthMonth < 9)
            {
                retirementFunds = "$5 million";
            }
            else if (birthMonth > 8 && birthMonth < 13)
            {
                retirementFunds = "$4,738";
            }
            else
            {
                retirementFunds = "$0.00";
            }


            string modeTransport;

            switch(favColor)
            {
                case "red":
                    modeTransport = "unicycle";
                    break;
                case "orange":
                    modeTransport = "zeppelin";
                    break;
                case "yellow":
                    modeTransport = "horse-drawn carriage";
                    break;
                case "green":
                    modeTransport = "steam engine";
                    break;
                case "blue":
                    modeTransport = "camel";
                    break;
                case "indigo":
                    modeTransport = "skateboard";
                    break;
                case "violet":
                    modeTransport = "dogsled";
                    break;
                default:
                    modeTransport = "canoe";
                    break;
            }

            string vacationHome;
            if (userSiblings == 0)
            {
                vacationHome = "Bali";
            }
            else if (userSiblings == 1)
            {
                vacationHome = "Taos";
            }
            else if (userSiblings == 2)
            {
                vacationHome = "New Zealand";
            }
            else if (userSiblings == 3)
            {
                vacationHome = "Buenos Aires";
            }    
            else if (userSiblings > 3)
            {
                vacationHome = "Tanzania";
            }
            else
            {
                vacationHome = "Scranton, PA";
            }

            Console.WriteLine(firstName + " " + lastName + " will retire in " + retirementYears + " with " + retirementFunds + " in the bank, a vacation home in " + vacationHome + " and a " + modeTransport + ".");
             
                    
            




        }
    }
}
