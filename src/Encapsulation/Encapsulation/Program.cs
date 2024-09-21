using Encapsulation.Invoicing;
using Encapsulation.Employment;
using System;
using Encapsulation.Calendar;
using Encapsulation.Banking;
using Encapsulation.Extra;

namespace Encapsulation;

public class Program
{
    static void Main(string[] args)
    {
        // Invoicing
        Invoice invoice1 = new Invoice("001", "Hammer", 5, 75.0);
        Console.WriteLine($"Part Number: {invoice1.PartNumber}");
        Console.WriteLine($"Part Description: {invoice1.PartDescription}");
        Console.WriteLine($"Quantity: {invoice1.Quantity}");
        Console.WriteLine($"Price per item: {invoice1.Price}");
        Console.WriteLine($"Total Invoice Amount: {invoice1.GetInvoiceAmount()}");

        // Employee
        Employee employee1 = new Employee("John", "Doe", 3000.0);
        Employee employee2 = new Employee("Jane", "Doe", 3500.0);

        Console.WriteLine($"Yearly Salary of {employee1.FirstName} {employee1.LastName}: {employee1.GetYearlySalary()}");
        Console.WriteLine($"Yearly Salary of {employee2.FirstName} {employee2.LastName}: {employee2.GetYearlySalary()}");

        // Raise salary by 10%
        employee1.RaiseSalary(10);
        employee2.RaiseSalary(10);

        Console.WriteLine($"Yearly Salary after 10% raise for {employee1.FirstName} {employee1.LastName}: {employee1.GetYearlySalary()}");
        Console.WriteLine($"Yearly Salary after 10% raise for {employee2.FirstName} {employee2.LastName}: {employee2.GetYearlySalary()}");

        // Date
        Date validDate = new Date(12, 15, 2021);
        Date invalidDate = new Date(13, 32, 2021); // Ini akan diset ke 1/1/1970

        Console.WriteLine("Valid date:");
        validDate.DisplayDate();
        Console.WriteLine("Invalid date set to default:");
        invalidDate.DisplayDate();

        // Banking

        BankAccount account = new BankAccount("123456789", "John Doe", 1000.0);
        Console.WriteLine($"Initial balance: {account.GetBalance()}");

        account.Deposit(500.0);
        Console.WriteLine($"Balance after deposit: {account.GetBalance()}");

        account.Withdraw(200.0);
        Console.WriteLine($"Balance after withdrawal: {account.GetBalance()}");

        // Extra
        // Membuat dua objek EmployeeExtra
        EmployeeExtra employee3 = new EmployeeExtra("John", "Smith", 3000);
        EmployeeExtra employee4 = new EmployeeExtra("Jane", "Smith", 3500);

        // Mengajukan pinjaman
        employee3.ApplyForLoan(12000); // Diterima, 12000 adalah 4x dari 3000
        employee4.ApplyForLoan(20000); // Ditolak, batas pinjaman adalah 5x 3500

        // Menampilkan status pinjaman
        Console.WriteLine(employee3.GetLoanStatus());
        Console.WriteLine(employee4.GetLoanStatus());

        // Memecat karyawan pertama
        employee3.Terminate();
        Console.WriteLine(employee3.GetLoanStatus());

        // Coba mengajukan pinjaman setelah dipecat
        employee3.ApplyForLoan(1000); // Gagal karena sudah dipecat

        // Karyawan pertama mencoba membayar pinjaman
        employee3.RepayLoan(5000); // Sukses bayar
        Console.WriteLine(employee3.GetLoanStatus());
    }
}
