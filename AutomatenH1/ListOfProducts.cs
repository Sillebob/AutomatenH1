using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatenH1
{
    public class ListOfProducts
    {   // Class not used. Should have been used to control the list of products.
        // Should have been possible to change the selection of items in the vending machine from Main (for the owner of the machine - not the user)
        // by calling the add or remove method from the logiclayer which then calls this class.
        #region Properties.
        private static List<Product> products = new List<Product>();

        public List<Product> Products
        {
            get { return products; }
            set { value = products; }
        }
        #endregion Properties.

        #region Constructors.
        public  ListOfProducts() { }
        #endregion Constructors.

        #region Methods.
        // Method to add a new product to the list of available products.
        public static void AddProduct(Product p)
        {
            products.Add(p);
        }
        // Method for removing a product from the list if it is no longer going to be sold in the machine.
        public static void RemoveProduct(Product p)
        {
            products.Remove(p);
        }
        #endregion

    }




}
