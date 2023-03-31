using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers; 
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Ravleen kaur
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine("       Author Ravleen             ");
            Console.WriteLine(" =================================================");
            Console.WriteLine("      Which app would you like to run?");
            string App = Console.ReadLine();
            Console.WriteLine("   You can now work in the selected application. That is ");
            if (App == "1")
            {
                Console.WriteLine("Distance Converter");
                DistanceConverter converter = new DistanceConverter();
                converter.run();
            }
            else if (App == "2")
            {
                Console.WriteLine("BMI");
                BMI conversion = new BMI();
                conversion.run();
            } 
            else if (App == "3")
            {
                Console.WriteLine("Student Grades");
                StudentGrades converter = new StudentGrades();
                converter.run();
            }
            else if (App == "4")
            {
                Console.WriteLine("Social Network");
                NetworkApp convert = new NetworkApp();
                convert.DispalyMenu();


            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            } 


        }
    }
}

