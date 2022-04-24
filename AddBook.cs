using System;
using System.Collections.Generic;
using System.Text;


    class AddBook
    {
    public static List<RentalBook> AddNewRentalBook = new List<RentalBook>();
    public static List<SecondHandBooks> AddNewSecondHandBooks = new List<SecondHandBooks>();
    public static List<NewBook> AddNewBook = new List<NewBook>();
    public void FirstMenu()
    {
        secondChance:
        Console.WriteLine("Please declear what kind of book do you want to sell\n" +
                          "1.New Book\n" +
                          "2.Second Hand Book\n" +
                          "3.Rental Book");
        Console.Write("Please enter here:");
        string WhereToGo = Console.ReadLine();
        switch (WhereToGo)
        {
            case "1":
                Console.Clear();
                AddBook GoToAddBook = new AddBook();
                GoToAddBook.AddBookNew();
                break;
            case "2":
                Console.Clear();                
                AddBook GoToAddSecondHandBook = new AddBook();
                GoToAddSecondHandBook.AddSecondHandBook();
                break;
            case "3":
                Console.Clear();
                AddBook GoToAddRentalBook = new AddBook();
                GoToAddRentalBook.AddRentalBook();
                break;            
            default:
                Console.Clear();
                Console.WriteLine($"************* You entered the wrong argument *************");
                goto secondChance;

        }//End of switch
    }//End of FirstMenu
    public void AddRentalBook()
    {   string name_Of_The_Book ;
        Console.Write("Name Of The Book:");
        name_Of_The_Book = Console.ReadLine();
        Console.Write("Author:");
        string author = Console.ReadLine();
        Console.Write("Publishers:");
        string publishers = Console.ReadLine();
        Console.Write("Translator:");
        string translator = Console.ReadLine();
        Console.Write("Genre:");
        string genre = Console.ReadLine();
        Console.Write("Language:");
        string language = Console.ReadLine();
        Console.Write("Book Condition");
        string bookCondition = Console.ReadLine();
        Console.Write("RentTime(days):");
        int rentTime= int.Parse(Console.ReadLine());
        Console.Write("Number Of Pages:");
        int numberOfPages = int.Parse(Console.ReadLine());
        Console.Write("Price:");
        int price = int.Parse(Console.ReadLine());

        Console.Write("Inventory:");
        int inventory = int.Parse(Console.ReadLine());
        int deliveryTime = int.Parse(Console.ReadLine());
        var GetCode = new BookList();
        //////////////////////////////////////////
        /*var code = new RentalBookList();
        code.RentalBookList[].;*/
        int procuct_code = GetCode.Plus_I(ref GetCode.i);
        AddNewRentalBook.Add(new RentalBook(name_Of_The_Book, author, publishers, translator, genre, language, numberOfPages
           , bookCondition,rentTime, price, procuct_code, inventory, deliveryTime, Situation.U_Name));
    secondChance:
        Console.Clear();
        Console.WriteLine("Your Book Successfully added now wher do you want to go:\n" +
                          "1.First Menu\n" +
                          "2.Exit");
        Console.Write("Please enter here:");
        string WhereToGo = Console.ReadLine();
        switch (WhereToGo)
        {
            case "1":
                var GoTo = new SellersMenu();
                GoTo.SellerShowMenu();
                break;
            case "2":
                Console.Clear();
                Environment.Exit(0);

                break;
            default:
                Console.Clear();
                Console.WriteLine($"************* You entered the wrong argument *************");
                goto secondChance;

        }//End of switch
    }//end of AddRentalBook

    public void AddSecondHandBook()
    {
        string name_Of_The_Book;
        Console.Write("Name Of The Book:");
        name_Of_The_Book = Console.ReadLine();
        Console.Write("Author:");
        string author = Console.ReadLine();
        Console.Write("Book Condition");
        string bookCondition = Console.ReadLine();
        Console.Write("Publishers:");
        string publishers = Console.ReadLine();
        Console.Write("Translator:");
        string translator = Console.ReadLine();
        Console.Write("Genre:");
        string genre = Console.ReadLine();
        Console.Write("Language:");
        string language = Console.ReadLine();
        Console.Write("Number Of Pages:");
        int numberOfPages = int.Parse(Console.ReadLine());
        Console.Write("Price:");
        int price = int.Parse(Console.ReadLine());
        Console.Write("Inventory:");
        int inventory = int.Parse(Console.ReadLine());
        Console.Write("Delivery Time:");
        int deliveryTime = int.Parse(Console.ReadLine());
        var GetCode = new BookList();
        int procuct_code = GetCode.Plus_I(ref GetCode.i);
        AddNewSecondHandBooks.Add(new SecondHandBooks(name_Of_The_Book, author, bookCondition, publishers, translator, genre, language, numberOfPages
            , price, procuct_code, inventory, deliveryTime, Situation.U_Name));
    secondChance:
        Console.Clear();
        Console.WriteLine("Your Book Successfully added now wher do you want to go:\n" +
                          "1.First Menu\n" +
                          "2.Exit");
        Console.Write("Please enter here:");
        string WhereToGo = Console.ReadLine();
        switch (WhereToGo)
        {
            case "1":
                var GoTo = new SellersMenu();
                GoTo.SellerShowMenu();
                break;
            case "2":
                Console.Clear();
                Environment.Exit(0);

                break;
            default:
                Console.Clear();
                Console.WriteLine($"************* You entered the wrong argument *************");
                goto secondChance;
        }//end of switch
    }//end of AddSecondHandBook
        public void AddBookNew()
        {
        string name_Of_The_Book = "";
        Console.Write("Name Of The Book:");
        name_Of_The_Book = Console.ReadLine();
        Console.Write("Author:");
        string author = Console.ReadLine();
        Console.Write("Publishers:");
        string publishers = Console.ReadLine();
        Console.Write("Translator:");
        string translator = Console.ReadLine();
        Console.Write("Genre:");
        string genre = Console.ReadLine();
        Console.Write("Language:");
        string language = Console.ReadLine();
        Console.Write("Number Of Pages:");
        int numberOfPages = int.Parse(Console.ReadLine());
        Console.Write("Price:");
        int price = int.Parse(Console.ReadLine());

        Console.Write("Inventory:");
        int inventory = int.Parse(Console.ReadLine());
        Console.Write("Delivery Time:");
        int deliveryTime = int.Parse(Console.ReadLine());
        var GetCode = new BookList();        
        int procuct_code = GetCode.Plus_I(ref GetCode.i);
        AddNewBook.Add(new NewBook(name_Of_The_Book, author, publishers, translator, genre, language, numberOfPages
            , price, procuct_code, inventory, deliveryTime, Situation.U_Name));
    secondChance:
        Console.Clear();
        Console.WriteLine("Your Book Successfully added now wher do you want to go:\n" +
                          "1.First Menu\n" +
                          "2.Exit");
        Console.Write("Please enter here:");
        string WhereToGo = Console.ReadLine();
        switch (WhereToGo)
        {
            case "1":
                var GoTo = new SellersMenu();
                GoTo.SellerShowMenu();
                break;
            case "2":
                Console.Clear();
                Environment.Exit(0);

                break;
            default:
                Console.Clear();
                Console.WriteLine($"************* You entered the wrong argument *************");
                goto secondChance;

        }//End of switch
    }//End of AddBookNew
}//End of class

