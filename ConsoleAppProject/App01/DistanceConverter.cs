using System;
using System.Security.Cryptography;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {

        const int Miles_To_Feet = 5280;
        const int Feet_To_Miles = 5280;
        const double Miles_To_Metres = 1609.34;
        public double Miles;
        public double Feets;
        public double Metres;
        public string From_distance;
        public string To_distance;

        public void run()
        {
            Console.WriteLine("Enter the from distance: ");
            From_distance = UnitMenu();
            Console.WriteLine("Enter the to distance: ");
            To_distance = UnitMenu();

            if (From_distance == "Miles")
            {
                Miles = input("miles");

                if (To_distance == "Feets")
                {
                    Feets = Miles * Miles_To_Feet;
                    Console.WriteLine(Miles + " miles is equal to " + Feets + " feets.");
                }
                else if (To_distance == "Metres")
                {
                    Metres = Miles * Miles_To_Metres;
                    Console.WriteLine(Miles + " miles is equal to " + Metres + " metres.");
                }
            }
            else if (From_distance == "Feets")
            {
                Feets = input("feets");

                if (To_distance == "Miles")
                {
                    Miles = Feets / Feet_To_Miles;
                    Console.WriteLine(Feets + " Feets is equal to " + Miles + " Miles.");
                }
            }

            string UnitMenu()
            {
                Console.WriteLine("Choose the unit for the conversion process!");
                Console.WriteLine("1. Miles");
                Console.WriteLine("2. Feets");
                Console.WriteLine("3. Metres");

                string choice = Console.ReadLine();

                Console.WriteLine("Enter the number to convert a unit from one distance to another:");
                if (choice == "1")
                {
                    return "Miles";
                }
                else if (choice == "2")
                {
                    return "Feets";
                }
                else if (choice == "3")
                {
                    return "Miles";
                }
                return null;
            }

             int input(string prompt)
            {
                Console.WriteLine("Please, enter the number of  " + prompt);
                return Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}
