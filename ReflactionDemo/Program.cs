using System;
using System.Reflection;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the assembly containing the Employee class
            Assembly assembly = Assembly.LoadFrom(@"E:\Project\TestReflaction\TestReflaction\bin\Debug\net6.0\TestReflaction.dll");

            // Get the type of the Employee class
            Type employeeType = assembly.GetType("EmployeeLibrary.Employee");

            // Create an instance of the Employee class
            object employeeInstance = Activator.CreateInstance(employeeType);

            // Set values for properties using reflection
            PropertyInfo nameProperty = employeeType.GetProperty("Name");
            nameProperty.SetValue(employeeInstance, "Rahul Roy");

            PropertyInfo ageProperty = employeeType.GetProperty("Age");
            ageProperty.SetValue(employeeInstance, 24);

            PropertyInfo genderProperty = employeeType.GetProperty("Gender");
            genderProperty.SetValue(employeeInstance, "Male");

            // Call the PrintDetails method using reflection
            MethodInfo printDetailsMethod = employeeType.GetMethod("PrintDetails");
            printDetailsMethod.Invoke(employeeInstance, null);
        }
    }
}
