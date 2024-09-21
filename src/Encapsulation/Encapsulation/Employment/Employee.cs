using System;

namespace Encapsulation.Employment
{
    public class Employee
    {
        // Atribut private
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;

        // Properti untuk FirstName
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _firstName = "Unknown";
                }
                else
                {
                    _firstName = value;
                }
            }
        }

        // Properti untuk LastName
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _lastName = "Unknown";
                }
                else
                {
                    _lastName = value;
                }
            }
        }

        // Properti untuk MonthlySalary
        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value >= 0)
                {
                    _monthlySalary = value;
                }
            }
        }

        // Konstruktor yang menginisialisasi atribut
        public Employee(string firstName, string lastName, double monthlySalary)
        {
            FirstName = firstName; // Validasi dilakukan di properti
            LastName = lastName;   // Validasi dilakukan di properti

            //kalau ini beda sendiri karena ada syaratnya, jadi validasi di konstruktor
            if (monthlySalary < 0)
            {
                MonthlySalary = 0.0;
            }
            else
            {
                MonthlySalary = monthlySalary;
            }
        }

        // Metode untuk menaikkan gaji (maksimal 20%)
        public void RaiseSalary(int raisePercentage)
        {
            if (raisePercentage > 0 && raisePercentage <= 20)
            {
                _monthlySalary += _monthlySalary * raisePercentage / 100;
            }
        }

        // Metode untuk mendapatkan gaji tahunan
        public double GetYearlySalary()
        {
            return _monthlySalary * 12;
        }
    }
}
