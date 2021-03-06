using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatenH1
{
    public static class LogicLayer
    {
        // Method that should have been used to add/remove products to the list I should have made instead of the switch in DAL.
        #region Not used methods List.
        public static void AddProduct(Product p)
        {
            ListOfProducts.AddProduct(p);
        }
        public static void RemoveProduct(Product p)
        {
            ListOfProducts.RemoveProduct(p);
        }

        #endregion Not used methods List.


        // Method to be called from Main and calls a method from the DataAccessLayer.

        public static Product GetProduct(int productNumber)
        {
            return DAL.GetProduct(productNumber);
        }
         // Method which to be called from Main and calls a method from the Stocklayer.
         public static void FillStock(Stack<int> itemsInStock)
        {
            StockControl.FillStock(itemsInStock);
        }
        public static int StockControlRemove(int productNumber, Stack<int> itemsInStock)
        {
            return StockControl.StockControlRemove(productNumber, itemsInStock);

        }


    }
}
