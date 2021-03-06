using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatenH1
{
    public class Product
    {
        //Properties
        #region Properties
        private int number;
        private string type;
        private string name;
        // Size in L/g
        private double size;
        // Price only in Kr
        private int price;

        public int Number
        {
            get
            {
                return number;
            }
            //set { type = value; }
        }
        public string Type
        {
            get
            {
                return type;
            }
            //set { type = value; }
        }
        public string Name
        {
            get
            {
                return name;
            }
            //set { name = value; }
        }
        public double Size
        {
            get
            {
                return size;
            }
            //set { size = value; }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set 
            { 
                value = price; 
            }
            
        }
        #endregion

        // Constructors
        #region Constuctors
        // Default constructor
        public Product()
        { }

        // constructor with the needed properties.
        public Product(int number,string type, string name, double size, int price)
        {
            this.number = number;
            this.type = type;
            this.name = name;
            this.size = size;
            this.price = price;
        }
        #endregion
        // Method for changing price
        public static void ChangePrice(Product product, int newPrice)
        {
            product.price = newPrice;
        }
    }
}
