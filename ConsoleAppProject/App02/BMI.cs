using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Calculates BMI 
    /// </summary>
    /// <author>
    /// Ravleens version 0.1
    /// </author>

    public class BMI
    {
        public void run()
        {
            //Ask the user to enter the units they would like to use
            Console.WriteLine("Please enter the units you would like to use (imperial/metric): ");
            string units = Console.ReadLine();

            //Calculate BMI based on chosen units
            if (units == "imperial")
            {
                Console.WriteLine("Enter your weight (in stones and pounds): ");
                double stones = Convert.ToDouble(Console.ReadLine());
                double pounds = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your height (in feet and inches): ");
                double feet = Convert.ToDouble(Console.ReadLine());
                double inches = Convert.ToDouble(Console.ReadLine());

                double kg = (stones * 6.35029) + (pounds * 0.453592);
                double height = (feet * 0.3048) + (inches * 0.0254);

                double BMI_result = kg / (height * height);
                Console.WriteLine("The calculated BMI is " + BMI_result);

                // WHO Weight Status
                if (BMI_result < 18.5)
                {
                    Console.WriteLine("Underweight");
                }
                else if (BMI_result >= 18.5 && BMI_result <= 24.9)
                {
                    Console.WriteLine("Normal");
                }
                else if (BMI_result >= 25.0 && BMI_result <= 29.9)
                {
                    Console.WriteLine("Overweight");
                }
                else if (BMI_result >= 30.0 && BMI_result <= 34.9)

                {
                    Console.WriteLine("Obese Class I");
                }
                else if (BMI_result >= 35.0 && BMI_result <= 39.9)

                {
                    Console.WriteLine("Obese Class II");
                }
                else if (BMI_result >= 40.0)
                {
                    Console.WriteLine("Obese Class III");
                }
            }
            else
            {
                Console.WriteLine("Enter you weight (in Kg): ");
                
                double kg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your Height (in m): ");
                double height = Convert.ToDouble(Console.ReadLine());

                double BMI_result = kg / (height * height);
                Console.WriteLine("The calculated BMI is " + BMI_result);
            
                // WHO Weight Status
                if (BMI_result < 18.5)
                {
                    Console.WriteLine("Underweight");
                }
                else if (BMI_result >= 18.5 && BMI_result <= 24.9)
                {
                    Console.WriteLine("Normal");
                }
                else if (BMI_result >= 25.0 && BMI_result <= 29.9)
                {
                    Console.WriteLine("Overweight");
                }
                else if (BMI_result >= 30.0 && BMI_result <= 34.9)

                {
                    Console.WriteLine("Obese Class I");
                }
                else if (BMI_result >= 35.0 && BMI_result <= 39.9)

                {
                    Console.WriteLine("Obese Class II");
                }
                else if (BMI_result >= 40.0)
                {
                    Console.WriteLine("Obese Class III");
                }
            }

        }
    }
}
