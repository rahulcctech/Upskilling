using System;

namespace EmployeeLibrary
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
        }
    }
}
