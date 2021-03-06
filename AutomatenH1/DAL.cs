using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatenH1
{
    public static class DAL
    {   // The DataAccessLayer
       

        // Method that sends the product corresponding to the users choice to the logic layer
        // Maybe a List would have been better in terms of changing products without having to do it at the DAL.
        // As it is now it is not possible to call a method and change a products name, price etc.
        // With a list it would be possible to make Methods for adding, deleting and changing products by calling 
        // a method from the main to the logiclayer which calls a methods here or from the ListOfProducts class.
        #region Switch Products.
        public static Product GetProduct(int productNumber)
        {
            #region SwitchReturningProduct
            switch (productNumber)
            {
                case 1:
                    Product water = new Product(1, "Vand", "Egekilde", 0.5, 15);
                    return water;

                case 2:
                    Product waterCitrus = new Product(2, "Vand", "Egekilde, citrus", 0.5, 15);
                    return waterCitrus;

                case 3:
                    Product fanta = new Product(3, "Sodavand", "Fanta", 0.5, 20);
                    return fanta;

                case 4:
                    Product sprite = new Product(4, "Sodavand", "Sprite", 0.5, 20);
                    return sprite;

                case 5:
                    Product cola = new Product(5, "Sodavand", "Coca-Cola", 0.5, 20);
                    return cola;

                case 6:
                    Product colaZero = new Product(6, "Sodavand", "Coca-cola Zero", 0.5, 20);
                    return colaZero;

                case 7:
                    Product mars = new Product(7, "Chokoladebar", "Mars", 45, 10);
                    return mars;

                case 8:
                    Product snickers = new Product(8, "Chokoladebar", "Snickers", 45, 10);
                    return snickers;

                case 9:
                    Product twix = new Product(9, "Chokoladebar", "Twix", 45, 10);
                    return twix;

                default:
                    Environment.Exit(0);
                    Product defaultProduct = new Product();
                    return defaultProduct;
            }
            #endregion
        }
        #endregion Switch Products.
       

    }
}
