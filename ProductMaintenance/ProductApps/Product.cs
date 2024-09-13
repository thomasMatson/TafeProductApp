using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;
        public decimal totalCharge;
        public decimal wrapTotalCharge;
        private const decimal deliveryCharge = 25.0m;
        private const decimal wrapCharge = 5.0m;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //Calculate the total charge with delivery
        public void calTotalCharge()
        {
            calTotalPayment();
            totalCharge = totalPayment + deliveryCharge;
        }

        // Calculate the total charge with wrapping
        public void calWrapTotalCharge()
        {
            calTotalCharge();
            wrapTotalCharge = totalCharge + wrapCharge;
        }
    }
}
