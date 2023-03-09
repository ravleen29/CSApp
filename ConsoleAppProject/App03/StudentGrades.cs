using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public string FullName;
        public string LastName;
        public int Grades;
        public string A, B, C, D, F;
        public const int Max_St = 10;
        public void run()
        {
            Console.WriteLine("Student Grades application!");
            Result();
            Name();
        }

        public string Result()
        {
            if (Grades >= 70)
            {
                return A;
            }
            else if (Grades >= 60)
            {
                return B;
            }
            else if (Grades >= 50)
            {
                return C;
            }
            else if (Grades >= 40)
            {
                return D;
            }
            else if (Grades >= 0)
            {
                return F;
            }
            return null;
        }

        public string Name()
        {
            return $"{FullName}{LastName}";
        }
    }
}
