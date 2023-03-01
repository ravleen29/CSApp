using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    
     public class BMI
    {  
             public void run()
            {
                Console.WriteLine("Enter you weight (in Kg): ");
                double kg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your Height (in m): ");
                double height= Convert.ToDouble(Console.ReadLine());

                double BMI_result = kg/(height*height);
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
