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
            string choice;
        }

        public string UnitMenu()
        {
            Console.WriteLine("Choose the unit for the conversion process!");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feets");
            Console.WriteLine("3. Metres");

            string choice = Console.ReadLine();

            Console.WriteLine("Enter the number to convert a unit from one distance to another:");
            if (choice == "1" )
            {
                return  "Miles";
            }
            else if (choice == "2")
            {
                return  "Feets";
            }
            else if (choice == "3")
            {
                return  "Miles";
            }
            return  null;
        }

        public int input(string prompt)
        {
            Console.WriteLine("Please, enter the number of  " +prompt );
            return Convert.ToInt32(Console.ReadLine()); 
        }
        public void MilesToFeet()
        {
            //step 1
            Console.WriteLine("Enter the number of miles: ");
            Miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Miles entered is: " + Miles);

            //step 2 

            Feets = Miles * Miles_To_Feet;

            //step 3
            Console.WriteLine(Miles + "miles is " + Feets + "feet.");

        }

        public void FeetToMiles()
        {
            //step 4
            Console.WriteLine("Enter the number of feet: ");
            int feets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Feet entered is: " + feets);

            //step 5
            Miles = Feets / Feet_To_Miles;

            //step 6
            Console.WriteLine(Feets + "feets is " + Miles + "miles.");
        }

        public void MilesToMetres()
        {
            //step 7
            Console.WriteLine("Enter the number of miles: ");
            double metres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Miles entered is: ");

            //step 8
            Metres = Miles * Miles_To_Metres;

            //step 9
            Console.WriteLine(Miles + "miles is " + Metres + "metres.");

        }
    }
}
