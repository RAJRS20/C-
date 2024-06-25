using System;

namespace ReflectionTask
{
    public class EmployeeDemo
    {
        // Properties
        public double Salary { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // Constructors
        public EmployeeDemo()
        {
            // Default constructor
        }

        public EmployeeDemo(double salary, string name, string address)
        {
            Salary = salary;
            Name = name;
            Address = address;
        }

        public EmployeeDemo(string name)
        {
            Name = name;
        }

        // Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary:C}, Address: {Address}");
        }

        public void UpdateAddress(string newAddress)
        {
            Address = newAddress;
            Console.WriteLine($"Address updated to: {Address}");
        }

        public void CalculateBonus(double bonusPercentage)
        {
            double bonusAmount = Salary * (bonusPercentage / 100);
            Console.WriteLine($"Bonus amount: {bonusAmount:C}");
        }
    }
}