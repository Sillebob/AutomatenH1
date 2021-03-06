using System;
using System.Collections.Generic;

namespace AutomatenH1
{      // + rigt billede der beskriver automaten med funktionalitet i PDF
    class Program
    {
        static void Main(string[] args)
        {
            string answerBack = "y";

            // Not used list of products, should have been used instead of the switch in DAL
            #region Not used List of products.
            Product water = new Product(1, "Vand", "Egekilde", 0.5, 15);
            Product waterCitrus = new Product(2, "Vand", "Egekilde, citrus", 0.5, 15);
            Product fanta = new Product(3, "Sodavand", "Fanta", 0.5, 20);
            Product sprite = new Product(4, "Sodavand", "Sprite", 0.5, 20);
            Product cola = new Product(5, "Sodavand", "Coca-Cola", 0.5, 20);
            Product colaZero = new Product(6, "Sodavand", "Coca-cola Zero", 0.5, 20);
            Product mars = new Product(7, "Chokoladebar", "Mars", 45, 10);
            Product snickers = new Product(8, "Chokoladebar", "Snickers", 45, 10);
            Product twix = new Product(9, "Chokoladebar", "Twix", 45, 10);

            ListOfProducts listOfProducts = new ListOfProducts();

            LogicLayer.AddProduct(water);
            LogicLayer.AddProduct(waterCitrus);
            LogicLayer.AddProduct(fanta);
            LogicLayer.AddProduct(sprite);
            LogicLayer.AddProduct(cola);
            LogicLayer.AddProduct(colaZero);
            LogicLayer.AddProduct(mars);
            LogicLayer.AddProduct(snickers);
            LogicLayer.AddProduct(twix);
            #endregion Not used List of products.

            // Instantiating a new stack for each product through the method call from the StockControl
            // And filling it with 5 items through the method call.
            #region Making stacks and fill up stock qty.
            StockControl productOne = new StockControl();
            LogicLayer.FillStock(productOne.ItemsInStock);
                      
            StockControl productTwo = new StockControl(); 
            LogicLayer.FillStock(productTwo.ItemsInStock);

            StockControl productThree = new StockControl();
            LogicLayer.FillStock(productThree.ItemsInStock);

            StockControl productFour = new StockControl();
            LogicLayer.FillStock(productFour.ItemsInStock);

            StockControl productFive = new StockControl();
            LogicLayer.FillStock(productFive.ItemsInStock);

            StockControl productSix = new StockControl();
            LogicLayer.FillStock(productSix.ItemsInStock);

            StockControl productSeven = new StockControl();
            LogicLayer.FillStock(productSeven.ItemsInStock);

            StockControl productEight = new StockControl();
            LogicLayer.FillStock(productEight.ItemsInStock);

            StockControl productNine = new StockControl();
            LogicLayer.FillStock(productNine.ItemsInStock);
            #endregion Making stacks and fill up stock qty.
          
            while (answerBack == "y")
            {
                
                // Calling the method that prints the menu.
                ShowMenu();

                // Declaring a variabel to hold the users choice of product.
                // Calling the method that gets the users input and checks if it is an integer.
                int productNumber = GetMenuChoice("Enter the number of the item you wish to buy");
                
                int itemsLeft = 5;
                // Inserting an switch statement to check if the chosen product is in stock and removing a piece from the stack if sold.
                #region SwitchRemovingProduct
                switch (productNumber)
                {
                    case 1:
                        itemsLeft = LogicLayer.StockControlRemove(productNumber, productOne.ItemsInStock);
                        break;

                    case 2:
                        itemsLeft = LogicLayer.StockControlRemove(productNumber, productTwo.ItemsInStock);
                        break;

                    case 3:
                        itemsLeft = LogicLayer.StockControlRemove(productNumber, productThree.ItemsInStock);
                        break;

                    case 4:
                        itemsLeft = LogicLayer.StockControlRemove(productNumber, productFour.ItemsInStock);
                        break;

                    case 5:
                        itemsLeft = LogicLayer.StockControlRemove(productNumber, productFive.ItemsInStock);
                        break;

                    case 6:
                        itemsLeft = LogicLayer.StockControlRemove(productNumber, productSix.ItemsInStock);
                        break;

                    case 7:
                        itemsLeft = LogicLayer.StockControlRemove(productNumber, productSeven.ItemsInStock);
                        break;

                    case 8:
                        itemsLeft = LogicLayer.StockControlRemove(productNumber, productEight.ItemsInStock);
                        break;

                    case 9:
                        itemsLeft = LogicLayer.StockControlRemove(productNumber, productNine.ItemsInStock);
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
                #endregion Switch Removing Product.
                
                if (itemsLeft >0)
                {
                    // Declaring a string to hold the answer from the user the method returns if the user wishes to proceed.
                    string answer = ExecuteOrder(LogicLayer.GetProduct(productNumber));

                    // Using a switch to determine if the order should be proceeded with or terminated.
                    #region Switch
                    switch (answer)
                    {
                        case "y":

                            // Calling the method to print price to be payed
                            // at the same time returns the value to be used as length in the forloop.
                            int amountToPay = InsertCoins(LogicLayer.GetProduct(productNumber));
                            
                            // waits  one second before printing.
                            System.Threading.Thread.Sleep(750);
                            PrintChangeColour("Counting the coins, please wait.");

                            //For loop which counts up to the price needed to be payed
                            // There is no detection for what has been inserted.
                            for (int i = 1; i <= amountToPay; i++)
                            {
                                // waits ½ a second before printingthe next number.
                                System.Threading.Thread.Sleep(500);
                                Console.Write(i + " ");
                            }
                            PrintChangeColour("\nCorrect amount inserted, please take your product, goodbye an have a nice day!");                                                     
                            break;

                            default:
                            PrintChangeColour("Operation terminated");
                            break;
                    }
                    #endregion Switch.
                }
                else
                {
                    Console.WriteLine("Sorry, the product you chose is sold out");
                }

                // Prompting the user to get back to the menu or exit the program.
                PrintChangeColour("Back to the menu (y/n)");
              
                answerBack = Console.ReadLine().ToLower();
            }
        }
        // Methods.
        // Method for stock control, making a stck for each item
        public static void MakeStock()
        { }
        // Method Menu.
        #region Method menu
        public static void ShowMenu()
        {
            Console.Clear();
            PrintChangeColour("The vending machine".ToUpper());
            // Calling the method from the logic layer to get the product information to fill into the menu.
            Console.WriteLine($"1) {LogicLayer.GetProduct(1).Name}, {LogicLayer.GetProduct(1).Price} kr.");
            Console.WriteLine($"2) {LogicLayer.GetProduct(2).Name}, {LogicLayer.GetProduct(2).Price} kr.");
            Console.WriteLine($"3) {LogicLayer.GetProduct(3).Name}, {LogicLayer.GetProduct(3).Price} kr.");
            Console.WriteLine($"4) {LogicLayer.GetProduct(4).Name}, {LogicLayer.GetProduct(4).Price} kr.");
            Console.WriteLine($"5) {LogicLayer.GetProduct(5).Name}, {LogicLayer.GetProduct(5).Price} kr.");
            Console.WriteLine($"6) {LogicLayer.GetProduct(6).Name}, {LogicLayer.GetProduct(6).Price} kr.");
            Console.WriteLine($"7) {LogicLayer.GetProduct(7).Name}, {LogicLayer.GetProduct(7).Price} kr.");
            Console.WriteLine($"8) {LogicLayer.GetProduct(8).Name}, {LogicLayer.GetProduct(8).Price} kr.");
            Console.WriteLine($"9) {LogicLayer.GetProduct(9).Name}, {LogicLayer.GetProduct(9).Price} kr.");
            Console.WriteLine("10) Exit");
            //PrintChangeColour("\r\nChoose an item: ");

        }
        #endregion

        // Method Getting the users choice.
        #region GetMenuChoice
        public static int GetMenuChoice(string question)
        {
            PrintChangeColour(question);
            int output;//Erklærer en variabel der skal bruges til at indeholde brugerens svar
            while (!int.TryParse(Console.ReadLine(), out output))/*Brugerens indtastning gemmes i output og 
                                                                 * der testes for om der er indtastet et heltal.
                                                                 * whileløkken kører indtil det er et tal der er indtastet*/
            {
                PrintChangeColour("Invalid input, try again");
            }
            return output;
        }
        #endregion

        // Method for printing and changing colour.
        #region ChangeColour.
        public static void PrintChangeColour(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        #endregion Changecolour.

        //Method Execute order.
        #region ExecuteOrder
        public static string ExecuteOrder(Product product)
        {
            string answer;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You chose {0} for {1} kr, do you wish to proceed y/n?", product.Name, product.Price);
            Console.ResetColor();
            answer = Console.ReadLine().ToLower();

            return answer;

        }
        #endregion

        // Method InsertCoins
        // Returns the amout to pay to count up in Main and give the user the chosen product.
        #region InsertCoins
        public static int InsertCoins(Product product)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please insert {0} kr., the machine can not give change.", product.Price);
            Console.ResetColor();
            return product.Price;
        }
        #endregion           
    }
}
