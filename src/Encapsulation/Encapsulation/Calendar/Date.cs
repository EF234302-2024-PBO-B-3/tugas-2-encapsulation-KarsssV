using System;

namespace Encapsulation.Calendar
{
    public class Date
    {
        public int Month { get; private set; }
        public int Day { get; private set; }
        public int Year { get; private set; }

        public Date(int month, int day, int year)
        {
            // Validasi Month (harus antara 1-12), Day (harus antara 1-31)
            if (month < 1 || month > 12 || day < 1 || day > 31)
            {
                Month = 1;
                Day = 1;
                Year = 1970;
            }
            else
            {
                Month = month;
                Day = day;
                Year = year;
            }
        }

        // Metode untuk menampilkan tanggal dalam format MM/DD/YYYY
        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}
