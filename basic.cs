using System;

namespace Practice
{
    class Basic
    {
        public static void Main(string[] args)
        {
            /* 
             * ==========================================
             * BASIC C# CONCEPTS FOR GITHUB REPOSITORY
             * ==========================================
             *
             * 1. Write vs WriteLine:
             *     - Write: Prints on the same line
             *     - WriteLine: Prints and adds a new line
             *
             * 2. Escape Sequences:
             *     - \t : Inserts a tab (usually 4 spaces)
             *     - \n : Inserts a new line
             *     - \" : Prints double quotes
            */

            //Variables :
            string name = "Kamruzzaman Tuhin";
            string university = "Guizhou University"; 
            string major = "Computer Science and Technology";
            string semester = "5th Semester";
            long studentId = 2053081188; 
            char section = 'A';
            int totalCredit = 13;
            double cgpa = 3.78;
            bool isActive = true;

            Console.WriteLine("===============================================");
            Console.WriteLine("\t\"STUDENT INFORMATION DOCUMENT\"");
            Console.WriteLine("===============================================\n");

            Console.Write("Name\t\t: ");
            Console.WriteLine(name);

            Console.Write("Student ID\t: ");
            Console.WriteLine(studentId);

            Console.Write("Section\t\t: ");
            Console.WriteLine(section);

            Console.Write("University\t: ");
            Console.WriteLine(university);

            Console.Write("Department\t: ");
            Console.WriteLine(major);

            Console.Write("Semester\t: ");
            Console.WriteLine(semester);

            Console.Write("Total Credit\t: ");
            Console.WriteLine(totalCredit);

            Console.Write("CGPA\t\t: ");
            Console.WriteLine(cgpa);
            
            Console.Write("Active Status\t: ");
            Console.WriteLine(isActive);

            Console.WriteLine("\n===============================================");
            Console.WriteLine("End of Document.");
        }
    }
}