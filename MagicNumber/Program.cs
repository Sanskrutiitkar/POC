using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    internal class Program
    {
        private const double TAX_RATE = 0.07; 
        private const double DISCOUNT_RATE = 0.10; 
        private const double SHIPPING_COST = 5.99; 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter product price to calculate final price : ");
            double productPrice = double.Parse(Console.ReadLine());

            double totalPrice = CalculateTotalPrice(productPrice);
            Console.WriteLine($"Total price: {totalPrice}");
        }
        static double CalculateTotalPrice(double price)
        {
            double tax = price * TAX_RATE;
            double discount = price * DISCOUNT_RATE;
            double shipping = SHIPPING_COST;

            // Total price calculation
            return price + tax - discount + shipping;
        }
    }
}
