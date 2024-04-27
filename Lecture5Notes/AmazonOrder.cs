using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5Notes
{
    public class AmazonOrder
    {
        // Fields
        String _orderId;
        String _name;
        List<Product> _products;
        decimal _tax;

        //Constructor
        public AmazonOrder(string orderId, string name, decimal tax)
        {
            _orderId = orderId;
            _name = name;
            _tax = tax;
            _products = new List<Product>();
        }

        //Properties
        public string OrderId { get => _orderId; set => _orderId = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal Tax { get => _tax; set => _tax = value; }
        internal List<Product> Products { get => _products; set => _products = value; }

        //Methods
        public decimal TotalPrice()
        {
            decimal totalPrice = 0;

            //Loop through list and add to totalPrice
            foreach (Product product in _products)
            {
                totalPrice += product.Price;
            }

            totalPrice *= (1 + _tax);

            //Return totalPrice
            return totalPrice;
        }

    } //Class

} //Namespace
