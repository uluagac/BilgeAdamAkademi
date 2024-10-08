using _19_Class_Study_.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_Study_.Data
{
    public class Product
    {
        // Fields
        private static int _id = 0;
        private string _name;

        // Constructor
        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
            _id++;
            Id = _id;
        }

        // Properties
        public int Id { get; private set; }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value.Trim().Substring(0, 1).ToUpper() + value.Trim().Substring(1).ToLower();
                }
            }
        }
        public double Price { get; private set; }
        public int Stock { get; private set; }
        public StatusProduct Status
        {
            get
            {
                if (Stock <= 0)
                    return StatusProduct.SoldOut;
                else
                    return StatusProduct.InStock;
            }
        }

        // Override Method
        public override string ToString()
        {
            string priceUSD = Price.ToString("C", new CultureInfo("en-US"));
            if (Stock <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return $"Id: {Id}\t Name: {Name}\t Price: {priceUSD}\t Stock: {Stock}\t Status: {Status}";
            }
            else if (Stock <= 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return $"Id: {Id}\t Name: {Name}\t Price: {priceUSD}\t Stock: {Stock}\t Status: {Status}";
            }
            else
            {
                Console.ResetColor();
                return $"Id: {Id}\t Name: {Name}\t Price: {priceUSD}\t Stock: {Stock}\t Status: {Status}";
            }
        }
    }
}
