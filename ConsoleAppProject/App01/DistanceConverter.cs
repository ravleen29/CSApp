using System;
using System.Security.Cryptography;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// converts three differentunit from one unit to another.
    /// </summary>
    /// <author>
    /// Ravleens version 0.1
    /// </author>
    public class DistanceConverter
    {

        const int Miles_To_Feet = 5280;
        const int Feet_To_Miles = 5280;
        const double Miles_To_Metres = 1609.34;
        const double Metres_In_Miles = 0.000621371;
        const double Feets_To_Meters = 0.3048;
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
                else if (To_distance == "Meters")
                {
                    Metres = Feets * Feets_To_Meters;
                    Console.WriteLine(Feets + " Feets is equal to  " + Metres + " metres.");
                }
            }
            else if (From_distance == "Meters")
            {
                Metres = input("metres");

                if (To_distance == "Miles")
                {
                    Miles = Metres * Metres_In_Miles;
                    Console.WriteLine(Metres + " Metres is equal to " + Miles + " Miles.");
                }
                else if (To_distance == "Feets")
                {
                    Feets = Metres / Feets_To_Meters;
                    Console.WriteLine(Metres + " Metres is equal to " + Feets + " Feets.");
                }
            }
        }
             static string UnitMenu()
            {
                Console.WriteLine("Choose the unit for the conversion process!");
                Console.WriteLine("1. Miles");
                Console.WriteLine("2. Feets");
                Console.WriteLine("3. Metres");

                string choice = Console.ReadLine();

                if (choice != "1" && choice != "2" && choice != "3")
                {
                    throw new Exception("Invalid Choice");
                }
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
                    return "Meters";
                }
                return null;
            }

            Double input(string prompt)
            {
                Console.WriteLine("Please, enter the number of  " + prompt);
                return Convert.ToDouble(Console.ReadLine());
            }


        
    }
}
