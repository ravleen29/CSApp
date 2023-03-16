using System;
using System.Collections.Generic;
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
        public string FirstName;
        public string LastName;
        public int Grades;
        public string A, B, C, D, F;
        public const int Max_St = 10;
        public void run()
        {
            Console.WriteLine("    Student Grades application!   ");
            ConnvertToGrades();
            Name();
            GetStudentGrades();
        }

        public string ConnvertToGrades()
        {
            switch (Grades)
            {
                case int n when (n >= 70):
                    return "A";
                case int n when (n >= 60):
                    return "B";
                case int n when (n >= 50):
                    return "C";
                case int n when (n >= 40):
                    return "D";
                case int n when (n >= 0):
                    return "F";
                default:
                    return "Invalid grade";
            }
        }

        public string Name()
        {
            return $"{FirstName} {LastName}";
        }

        public void GetStudentGrades()
        {
            List<StudentGrades> studentGradesList = new List<StudentGrades>();
            for (int i = 0; i < Max_St; i++)
            {
                Console.WriteLine("Please enter student name: ");
                string name = Console.ReadLine();
                
                StudentGrades sg = new StudentGrades()
                {
                    FirstName = name,
                };
                Console.WriteLine("Please enter student grades: ");
                int grades = Convert.ToInt32(Console.ReadLine());
                sg.Grades = grades;
                studentGradesList.Add(sg);
            }
            foreach (StudentGrades sg in studentGradesList)
            {
                Console.WriteLine($"{sg.Name()} Grade: {sg.ConnvertToGrades()}");
            }
        }


    }
}
