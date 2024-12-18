using System;
using System.Linq;

namespace EFCodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2000, 1, 1)
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save the changes to the database
                context.SaveChanges();
                Console.WriteLine("Student has been added to the database.");

                // Display the student
                var savedStudent = context.Students.FirstOrDefault();
                Console.WriteLine($"Student ID: {savedStudent.Id}, Name: {savedStudent.FirstName} {savedStudent.LastName}");
            }
        }
    }
}