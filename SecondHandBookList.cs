using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


class SecondHandBookList
    {
    public void ShowNewBook()
    {
        List<SecondHandBooks> SecondHandBookList = new List<SecondHandBooks>();

        SecondHandBookList.Add(new SecondHandBooks("Sherlock Holmes", "MICHEAL DIBDIN", "Just some scratchs on Cover","Oxford"
            ,"-", "Thriller", "English",72,20, Plus_I(ref i), 1,7, "reza"));
        SecondHandBookList.Add(new SecondHandBooks("American Crime", "JOHN ESCOTT ", "Nothing", "Oxford"
            , "-", "Thriller", "English", 120, 32, Plus_I(ref i),1,14, "reza"));
        SecondHandBookList.AddRange(AddBook.AddNewSecondHandBooks);
        for (int j = 0; j < SecondHandBookList.Count; j++)
        {
            SecondHandBookList[j].Product_Code = j;
        }



        Console.WriteLine($"{"Name Of The Book",-20}{"Author",-16}{"Publishers",-25}{"Genre",-10}{"Price",-18}{"Code",-6}");
        foreach (var element in SecondHandBookList)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine("\n----------------------------------------------------------\n" +
                          "Now if you want to buy or knew more detiels about book enter the code of\nthe book" +
                          " or if you want to go to the last menu enter (First Menu) or if \nyou want to exit" +
                          "enter (Exit).\n----------------------------------------------------------\n");
        Console.Write("Please enter what do you want :");
        string WhereUserWhatToGo = Console.ReadLine();
        var GetCode =
            from c in SecondHandBookList
            select c.Product_Code;

        bool CodeExist = false;
        foreach (var element in GetCode.Distinct())
        {
            if (WhereUserWhatToGo == element.ToString())
            {
                CodeExist = true;
                break;
            }//End of if
            else
            {
                CodeExist = false;
                continue;
            }//End of else
        }//End of foreach

        if (WhereUserWhatToGo != "Exit" && WhereUserWhatToGo != "First Menu" && CodeExist != true)
        { Console.WriteLine("Error: wrong argument"); }//End of if
        else
        {
            switch (WhereUserWhatToGo)
            {
                case "Exit":
                    Console.Clear();
                    Environment.Exit(0);
                    break;// End of exit

                case "First Menu":
                    Console.Clear();
                    FirstMenu.ShowMenu();
                    break;//End of First Menu

                default://If User Enter The Code Of The Book
                    Console.Clear();
                    //Covert to int and import it into arrayNumber
                    int arrayNumber = Int32.Parse(WhereUserWhatToGo);
                    //More Details About That Book User Wanted(Entered Code)
                    Console.WriteLine($"Book Name : {SecondHandBookList[arrayNumber].NameOfTheBook}\nAuthor: {SecondHandBookList[arrayNumber ].Author}" +
                        $"\nPrice:{SecondHandBookList[arrayNumber ].Price} Toman \nMaximum Delevry Time{SecondHandBookList[arrayNumber ].DeliveryTime} days" +
                        $"\nBookCondition: {SecondHandBookList[arrayNumber ].BookCondition}\nInventory: {SecondHandBookList[arrayNumber ].Inventory}" +
                        $"\nTranslator:{SecondHandBookList[arrayNumber ].Translator}\nBookType:{SecondHandBookList[arrayNumber ].BookType}" +
                        $"\nNumber Of Pages: {SecondHandBookList[arrayNumber ].NumberOfPages}\nPublishers: {SecondHandBookList[arrayNumber ].Publishers}" +
                        $"\nGenre: {SecondHandBookList[arrayNumber ].Genre}\nLanguage: {SecondHandBookList[arrayNumber ].Language}");
                    //Show Menu To User
                    Console.WriteLine("---------------------------------------------\nPlease enter the number of menu you want to go:");
                    Console.WriteLine("1.Buy The Book");
                    Console.WriteLine("2.Back To Second Hand Book List");
                    Console.WriteLine("3.First Menu");
                    Console.WriteLine("4.Exit");
                    secondchance:
                    Console.Write("Enter Here: ");
                    string CheckNumber = Console.ReadLine();
                    //Cheek the argument user entered 
                    if (CheckNumber != "1" || CheckNumber != "2" || CheckNumber != "3" || CheckNumber != "4")
                    {
                        Console.WriteLine($"You entered the wrong argument.Please try again");
                        goto secondchance;
                    }//End of if

                    if (Situation.U_Situation == "Customer"|| Situation.U_Situation=="Seller") { 
                        Console.Clear();
                        Console.WriteLine("Please Enter Your Address:\n");
                        string address = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Dear {Situation.Full_Name} you successfully ordered {SecondHandBookList[arrayNumber - 1].NameOfTheBook} book\n" +
                            $"and you going to recive your book at least {SecondHandBookList[arrayNumber - 1].DeliveryTime} days laster. ");
                        OrderList.Orders.Add(new OrderList { Address = address, DeliveryTime = SecondHandBookList[arrayNumber - 1].DeliveryTime,
                            NameOfReciver = Situation.Full_Name, NameOfTheBook = SecondHandBookList[arrayNumber - 1].NameOfTheBook, 
                            PriceOfTheBook = SecondHandBookList[arrayNumber - 1].Price,NameOfSeller= SecondHandBookList[arrayNumber - 1].UsernameOfTheSeller }) ;
                        SecondHandBookList[arrayNumber - 1].Inventory = SecondHandBookList[arrayNumber - 1].Inventory - 1;
                        seecondchance:
                        Console.WriteLine("Now Where do you want to go :" +
                                          "1.First Menu" +
                                          "2.Exit");
                        Console.Write("Enter here:");
                        WhereUserWhatToGo = Console.ReadLine();
                        switch (WhereUserWhatToGo)
                        {
                            case "1":
                                Console.Clear();
                                FirstMenu.ShowMenu();
                                break;
                            case "2":
                                Console.Clear();
                                Environment.Exit(0);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("****** Sorry Your Entered Wrong Argument Please Try Again");
                                goto seecondchance;
                        }



                    }//end of if
                    if (Situation.U_Situation == "Viewer")
                    {
                        switch (CheckNumber)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Sorry First You Must Make A Account To Buy A Book" +
                                    "\nNow , Please enter the number of menu you want to go:" +
                                    "\n1.Create Account (Sign up)" +
                                    "\n2.First Menu" +
                                    "\n3.Exit");
                                Console.Write("Enter Here: ");
                                CheckNumber = Console.ReadLine();
                                if (CheckNumber != "1" || CheckNumber != "2" || CheckNumber != "3" || CheckNumber != "4")
                                {
                                    Console.WriteLine($"You entered the wrong argument.");
                                }//End of if
                                switch (CheckNumber)
                                {
                                    case "1":
                                        Console.Clear();
                                        var GoToSignup = new Signup();
                                        GoToSignup.ShowSignupMenu();
                                        break;//End of number 1

                                    case "2":
                                        Console.Clear();
                                        FirstMenu.ShowMenu();
                                        break;//End of number 2

                                    case "3":
                                        Console.Clear();
                                        Environment.Exit(0);
                                        break;//End of number 3     
                                }//End of Switch

                                break;//End of number 1

                            case "2":
                                Console.Clear();
                                var ShowList = new SecondHandBookList();
                                ShowList.ShowNewBook();
                                break;//End of number 2

                            case "3":
                                Console.Clear();
                                FirstMenu.ShowMenu();
                                break;//End of number 3

                            case "4":
                                Console.Clear();
                                Environment.Exit(0);
                                break;//End of number 4      
                        }//End of Switch
                    }//End of if
                    break;//End of More Detiel Of Book Switch

            }//End of Switch
        }//End of else


    }//End of Show New Book 


    //Code Generator 
    int i = 0;
    public int Plus_I(ref int i)
    { return ++i; }
}//End of the Class

