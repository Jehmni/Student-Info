using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessment1
{
    internal class Programd
    { 
        static void Main(string[] args)
        {
            // Prompt the user to enter the number of students
            Console.WriteLine("Enter the number of students: ");
            int arraySize = int.Parse(Console.ReadLine());

            // Create an array to store information for students
            Student[] AiStudents = new Student[arraySize];

            // Loop through the array and prompt the user to enter information for each student
            for (int i = 0; i < AiStudents.Length; i++)
            {
                Console.WriteLine("Enter information for student {0}", i + 1);

                // Prompt the user to enter the student's name
                Console.Write("Name: ");
                string name = Console.ReadLine();

                // Prompt the user to enter the student's age
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                // Prompt the user to enter the student's ID
                Console.Write("Student ID: ");
                string id = Console.ReadLine();

                // Create a new Student object with the input values and add it to the array
                AiStudents[i] = new Student { Name = name, Age = age, Id = id };
            }

            // Print out the information of each student in the array
            for (int i = 0; i < AiStudents.Length; i++)
            {
                AiStudents[i].GetInformation();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}
