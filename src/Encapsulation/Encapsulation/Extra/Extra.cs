using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Extra


/*
 * Tuliskan spesifikasi soal Anda disini. 
 * Kelas yang dibuat, atribut apa saja yang dibutuhkan, metode apa saja yang dibutuhkan, validasi atau aturan apa yang harus dilakukan.
 * 
 */


// Tulis disini
/*
 * Kelas : EmployeeExtra
 * Atribut : _isTerminated (private bool) -> cek karyawan sudah dipecat atau belum
 *           _loanAmount (private double) -> pinjaman yang diajukan karyawan
 *           _maxLoanLimit (constant double = 5 * MonthlySalary) -> batas maksimum pinjam itu 5x gaji bulanan
 * Metode : Terminate() -> setelah terminate tidak boleh melakukan pinjaman lagi
 *          ApplyForLoan(double amount) -> Menambahkan pinjaman ke karyawan, pastikan pinjaman tidak lebih dari 5*gaji bulanan
 *          RepayLoan(double amount) -> Mengurangi jumlah loan, pembayaran tidak boleh melebihi loan
 *          GetLoanStatus -> mengeluarkan status pinjaman termasuk karyawan dipecat atau tidak
 * Validasi : Kalau dipecat tidak bisa loan
 *            Pinjaman tidak boleh melebihi 5 * gaji bulanan
 *            Karyawan yg udh dipecat masih bisa bayar loan tp tidak bisa loan.

 */


/*
 * Implementasikan solusi kelas dari soal Anda disini dan eksekusi implementasinya di Program.cs
 */

// Tulis disini

{
    public class EmployeeExtra
    {
        // Atribut private
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;
        private bool _isTerminated;
        private double _loanAmount;
        private const double LoanMultiplier = 5.0;

        // Properti untuk FirstName
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = string.IsNullOrEmpty(value) ? "Unknown" : value; }
        }

        // Properti untuk LastName
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = string.IsNullOrEmpty(value) ? "Unknown" : value; }
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

        // Properti untuk IsTerminated
        public bool IsTerminated
        {
            get { return _isTerminated; }
        }

        // Properti untuk LoanAmount
        public double LoanAmount
        {
            get { return _loanAmount; }
        }

        // Konstruktor
        public EmployeeExtra(string firstName, string lastName, double monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
            _isTerminated = false;
            _loanAmount = 0.0;
        }

        // Metode untuk memecat karyawan
        public void Terminate()
        {
            _isTerminated = true;
        }

        // Metode untuk mengajukan pinjaman
        public void ApplyForLoan(double amount)
        {
            if (_isTerminated)
            {
                Console.WriteLine($"{FirstName} {LastName} has been terminated and cannot apply for a loan.");
                return;
            }

            double maxLoanLimit = MonthlySalary * LoanMultiplier;
            if (amount > 0 && _loanAmount + amount <= maxLoanLimit)
            {
                _loanAmount += amount;
                Console.WriteLine($"{FirstName} {LastName} successfully applied for a loan of {amount:C}. Total loan: {_loanAmount:C}");
            }
            else
            {
                Console.WriteLine($"Loan application failed. Max loan limit is {maxLoanLimit:C}. Current loan: {_loanAmount:C}");
            }
        }

        // Metode untuk membayar pinjaman
        public void RepayLoan(double amount)
        {
            if (amount > 0 && amount <= _loanAmount)
            {
                _loanAmount = _loanAmount - amount;
                Console.WriteLine($"{FirstName} {LastName} has repaid {amount:C}. Remaining loan: {_loanAmount:C}");
            }
            else
            {
                Console.WriteLine($"Repayment failed. Current loan is {_loanAmount:C}");
            }
        }

        // Metode untuk mendapatkan status pinjaman
        public string GetLoanStatus()
        {
            return $"{FirstName} {LastName} - Loan: {_loanAmount:C}, Terminated: {_isTerminated}";
        }
    }
}

