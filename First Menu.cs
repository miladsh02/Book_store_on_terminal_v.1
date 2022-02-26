using System;
using System.Collections.Generic;
using System.Text;


public static class FirstMenu
    {

    public static void ShowMenu()
    {
        secondChance://If user entered a wrong argument
        Console.WriteLine("Hello wellcome to Green Page Store\n" +
            "If you want to buy or rent the books you must make account.\n" +
            "---------------------------------------------\n" +
            "Please enter the number of menu you want to go:\n" +
            "1.sign in or Sign up\n" +
            "2.Books List (New books)\n" +
            "3.Second Hand Books List\n" +
            "4.Rental Books List\n" +
            "5.Exit");
        Console.Write("Enter Here: ");

        string CheckNumber = Console.ReadLine();
        switch (CheckNumber)
        { case"1":
                Console.Clear();
                var FirrstMenu = new Login();
                FirrstMenu.FirrstMenu();
          break;//End of number 1

          case"2":
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
                Console.Clear();
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine($"************* You entered the wrong argument *************");
                goto secondChance;
        }//End of Switch

    
        }//End of static void Show_Menu 

    public static void SellerShowMenu()
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
                Console.Clear();
                var GotoAddBook = new AddBook();
                GotoAddBook.FirstMenu();
                break;
            case "6":
                Console.Clear();
                var GetOrders = new OrderList();
                GetOrders.SellerOrderList();
                Console.Clear();
                break;
            case "7":
                Console.Clear();                
                Report.GetReport();
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

    public static void CustomerShowMenu()
    {
    secondChance://If user entered a wrong argument
        Console.WriteLine("Hello wellcome to Green Page Store\n" +
            "If you want to buy or rent the books you must make account.\n" +
            "---------------------------------------------\n" +
            "Please enter the number of menu you want to go:\n" +
            "1.Sign out\n" +
            "2.Order List\n" +
            "3.Books List (New books)\n" +
            "4.Second Hand Books List\n" +
            "5.Rental Books List\n" +
            "6.Report\n" +
            "7.Exit");
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
                var GetOrders = new OrderList();
                GetOrders.CustomerOrderList();                
                break;//End of number 2
            case "3":
                Console.Clear();
                var ShowList = new BookList();
                ShowList.ShowNewBook();
                break;//End of number 3

            case "4":
                Console.Clear();
                var ShowSecondHandBookList = new SecondHandBookList();
                ShowSecondHandBookList.ShowNewBook();
                break;//End of number 4

            case "5":
                Console.Clear();
                var RentalBookList = new RentalBookList();
                RentalBookList.ShowNewBook();
                break;//End of number 5
            case "6":
                Console.Clear();                
                Report.GetReport();
                break;//End of number 6
            case "7":
                Console.Clear();
                Environment.Exit(0);
                break;//End of number 7
            default:
                Console.Clear();
                Console.WriteLine($"************* You entered the wrong argument *************");
                goto secondChance;
        }//End of Switch

    }//End of CustomerShowMenu
    public static void AdminShowMenu() 
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
            "5.Users\n" +
            "6.Orders\n" +
            "7.See The Reports\n" +
            "8.Exit");
        Console.Write("Enter Here: ");

        string CheckNumber = Console.ReadLine();
        switch (CheckNumber)
        {
            case "1":
                Console.Clear();
                var login = new Login();
                login.FirrstMenu();
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
                Console.WriteLine("This feature is not available");////////////////////////////////////////////////////////////
                break;
            case "6":
                Console.Clear();
                var GetOrders = new OrderList();
                GetOrders.AdminOrderList();
                break;
            case "7":
                Console.Clear();
                Report.ShowReports();
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
    }//End of AdminShowMenu

}//End of class First_Menu




