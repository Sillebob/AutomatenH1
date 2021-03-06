using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatenH1
{
    public class StockControl
    {
        // Making a stack object to contain the numbers og items in stock.
        // Properties and access methods.
        #region Properties.
        private Stack<int> itemsInStock = new Stack<int>();
        public Stack<int> ItemsInStock
        {
            get { return itemsInStock; }
            set { value = itemsInStock; }
        }
        
        public StockControl(Stack<int> product)
        {
            this.itemsInStock = product;
        }
        #endregion Properties.

        // Default constructor
        #region Constructors.
        public StockControl()
        {

        }
        #endregion Constructors.

        // Methods.
        #region Methods.
        // Method to fill stack with items.
        // Could have been a loop that fills up the stack one at a time a certain number of times (the number of times should
        // then be a parameter which the methods takes with it when it is called).
        public static void FillStock(Stack<int> itemsInStock)
        {
            itemsInStock.Push(1);
            itemsInStock.Push(2);
            itemsInStock.Push(3);
            itemsInStock.Push(4);
            itemsInStock.Push(5);
        }
        // Method to remove item from the stocklist when sold
        // Returns the number of items left in stock.
        #region Switch method Remove from stack.
        public static int StockControlRemove(int productNumber, Stack<int> itemsInStock)
        {
            switch (productNumber)
            {
                case 1:
            
                   if (itemsInStock.Count > 0)
                    {
                        itemsInStock.Pop();
                    }
                   
                    return itemsInStock.Count;
                case 2:

                    if (itemsInStock.Count > 0)
                    {
                        itemsInStock.Pop();
                    }
                    return itemsInStock.Count;

                case 3:

                    if (itemsInStock.Count > 0)
                    {
                        itemsInStock.Pop();
                    }
                    return itemsInStock.Count;

                case 4:

                    if (itemsInStock.Count > 0)
                    {
                        itemsInStock.Pop();
                    }
                    return itemsInStock.Count;

                case 5:

                    if (itemsInStock.Count > 0)
                    {
                        itemsInStock.Pop();
                    }
                    return itemsInStock.Count;

                case 6:

                    if (itemsInStock.Count > 0)
                    {
                        itemsInStock.Pop();
                    }
                    return itemsInStock.Count;

                case 7:

                    if (itemsInStock.Count > 0)
                    {
                        itemsInStock.Pop();
                    }
                    return itemsInStock.Count;

                case 8:

                    if (itemsInStock.Count > 0)
                    {
                        itemsInStock.Pop();
                    }
                    return itemsInStock.Count;

                case 9:

                    if (itemsInStock.Count > 0)
                    {
                        itemsInStock.Pop();
                    }
                    return itemsInStock.Count;

                default:
                    return 0;
            }
        }
        #endregion Switch method Remove from stack.

        #endregion Methods.
    }
}
