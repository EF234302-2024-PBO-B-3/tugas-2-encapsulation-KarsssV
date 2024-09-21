using System;
using System.Diagnostics;

namespace Encapsulation.Invoicing
{
    public class Invoice
    {
        private string _partNumber;
        private string _partDescription;
        private int _quantity;
        private double _price;

        public Invoice (string partNumber, string partDescription, int quantity, double price)
        {
            _partNumber = partNumber;
            _partDescription = partDescription;
            Quantity = quantity; // Memanggil properti Quantity untuk memvalidasi
            Price = price; // Memanggil properti Price untuk memvalidasi
        }

        // Properti PartNumber dengan get dan set
        public string PartNumber
        {
            get 
            { 
                return _partNumber; 
            }
            set 
            { 
                _partNumber = value; 
            }
        }

        // Properti PartDescription dengan get dan set
        public string PartDescription
        {
            get 
            { 
                return _partDescription; 
            }
            set 
            { 
                _partDescription = value; 
            }
        }

        // Properti Quantity dengan validasi set
        public int Quantity
        {
            get 
            { 
                return _quantity; 
            }
            set 
            {
                if (value < 0)
                {
                    _quantity = 0;
                }
                else
                {
                    _quantity = value;
                }
            }
        }

        // Properti Price dengan validasi set
        public double Price
        {
            get { return _price; }
            set 
            {
                if (value < 0)
                {
                    _price = 0.0;
                }
                else
                {
                    _price = value;
                }
            }
        }

        // Metode untuk menghitung total jumlah faktur
        public double GetInvoiceAmount()
        {
            return _quantity * _price;
        }
    }
}