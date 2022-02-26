using System;
using System.Collections.Generic;
using System.Text;


    class SellersMenu
    {
        public  void SellerShowMenu()
        {
        secondChance://If user entered a wrong argument
            Console.WriteLine("Hello wellcome to Green Page Store\n" +
                "If you want to buy or rent the books you must make account.\n" +
                "---------------------------------------------\n" +
                "Please enter the number of menu you want to go:\n" +
                "1.Sign out\n" +
                "2.Books List (New books)\n" +
                "3.Second Hand Books List\n" +
                "4.Rental Books List\n" +
                "5.Add Book\n" +
                "6.Orders\n" +
                "7.Report\n" +
                "8.Exit");
            Console.Write("Enter Here: ");

            string CheckNumber = Console.ReadLine();
            switch (CheckNumber)
            {
                case "1":
                    Console.Clear();
                    Situation.U_Situation = "Viewer";
                    FirstMenu.ShowMenu();
                    break;//End of number 1

                case "2":
                    Console.Clear();
                    var ShowList = new BookList();
                    ShowList.ShowNewBook();
                    break;//End of number 2

                case "3":
                    Console.Clear();
                    var ShowSecondHandBookList = new SecondHandBookList();
                    ShowSecondHandBookList.ShowNewBook();
                    break;//End of number 3

                case "4":
                    Console.Clear();
                    var RentalBookList = new RentalBookList();
                    RentalBookList.ShowNewBook();
                    break;//End of number 4
                case "5":
                    /////////////////////////////////////////////////////////////////
                    break;
                case "6":
                    var GetOrders = new OrderList();
                    GetOrders.SellerOrderList();
                    Console.Clear();
                    break;
                case "7":
                    /////////////////////////////////////////////////////////////////
                    break;
                case "8":
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"************* You entered the wrong argument *************");
                    goto secondChance;
            }//End of Switch
        }//End of SellerShowMenu

    }

