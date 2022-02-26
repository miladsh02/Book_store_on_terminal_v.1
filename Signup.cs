using System;
using System.Collections.Generic;
using System.Text;
class Signup
{
    public void ShowSignupMenu()
    {
        secondChance:
        Console.WriteLine("1.Sign up as a customer\n" +
                          "2.Sign up as a Seller\n" +
                          "3.First Menu\n" +
                          "4.Exit");
        Console.Write("Enter here :");
        string CheckNumber = Console.ReadLine();
        switch (CheckNumber)
        {
            case "1":
                Console.Clear();
                var GoTocustomerSignupMenu = new Signup();
                GoTocustomerSignupMenu.CustomerSignupMenu();
                break;//End of number 1

            case "2":
                Console.Clear();
                var GoToSellerMenu = new Signup();
                GoToSellerMenu.SellerSignupMenu();
                break;//End of number 2

            case "3":
                Console.Clear();
                FirstMenu.ShowMenu();
                break;//End of number 3

            case "4":
                Console.Clear();
                Environment.Exit(0);
                break;//End of number 4

            default:
                Console.Clear();
                Console.WriteLine($"************* You entered the wrong argument *************");
                goto secondChance;


        }//End of switch
    }//End of ShowSignupMenu

    //Sign up for Customers
    public static List<Customer> NewCustomerList = new List<Customer>();
    public void CustomerSignupMenu()
    {
        Console.WriteLine("If you want to sign up as a customer you shoud fill this filds\n" +
                          "First Name - Last Name - E-Mail - Password -Password(for make sure its right)\n" +
                          "-Username.Now fill the items :");
        Console.Write("First Name:");
        string FName = Console.ReadLine();
        Console.Write("Last Name:");
        string LName = Console.ReadLine();
        Console.Write("E-Mail:");
        string EMail = Console.ReadLine();
        Console.Write("Username:");
        string Uname = Console.ReadLine();
    SecondpasswordChance:
        Console.Write("Password:");        
        string Password = Console.ReadLine();
        Console.Write("re-Password:");
        string RePassWord = Console.ReadLine();
        if(Password!= RePassWord)
        {
            Console.Clear();
            Console.WriteLine("********Sorry you Password and re-Password aren't same.Please try again.********");
            goto SecondpasswordChance;
        }//End of if
        NewCustomerList.Add(new Customer { Username = Uname, Password = Password, AccessLevel = "Customer", FullName = FName + " " + LName, EmailAddress = EMail });
        Console.Clear();
        secondChance:
        Console.WriteLine("You successfully signed up \n" +
                          "1.First Menu\n" +
                          "2.Exit");
        Console.Write("Enter Here:");
        string CheckNumber = Console.ReadLine();
        switch (CheckNumber)
        {
            case "1":
                Console.Clear();
                FirstMenu.ShowMenu();
                break;//end of number 1
            case "2":
                Console.Clear();
                Environment.Exit(0);
                break;//end of number 1
            
            default:
                Console.Clear();
                Console.WriteLine($"************* You entered the wrong argument *************");
                goto secondChance;
        }//End of switch
        }//End of customer Signup Menu


    //Sign up for Sellers
    public static List<Seller> NewSellerList = new List<Seller>();
    public void SellerSignupMenu()
    {
        Console.WriteLine("If you want to sign up as a Seller you shoud fill this filds\n" +
                  "First Name - Last Name -Bank Card Address -ID Card Code- E-Mail - Password \n" +
                  "-Password(for make sure its right)-Username.Now fill the items :");
        Console.Write("First Name:");
        string FName = Console.ReadLine();
        Console.Write("Last Name:");
        string LName = Console.ReadLine();               
        Console.Write("Bank Card Address:");
        int BankCardAddress = int.Parse(Console.ReadLine());
        Console.Write("ID Card Code:");
        int IDCardCode = int.Parse(Console.ReadLine());        
        Console.Write("E-Mail:");
        string EMail = Console.ReadLine();
        Console.Write("Username:");
        string Uname = Console.ReadLine();
    SecondpasswordChance:
        Console.Write("Password:");    
        string Password = Console.ReadLine();
        Console.Write("re-Password:");
        string RePassWord = Console.ReadLine();
        if (Password != RePassWord)
        {
            Console.Clear();
            Console.WriteLine("********Sorry you Password and re-Password aren't same.Please try again.********");
            goto SecondpasswordChance;
        }//End of if
        NewSellerList.Add(new Seller { Username = Uname, Password = Password, AccessLevel = "Seller", FullName = FName + " " + LName
            , EmailAddress = EMail,IDCardCode= IDCardCode,BankCardAddress= BankCardAddress});
        Console.Clear();
    secondChance:
        Console.WriteLine("You successfully signed up \n" +
                          "1.First Menu\n" +
                          "2.Exit");
        Console.Write("Enter Here:");
        string CheckNumber = Console.ReadLine();
        switch (CheckNumber)
        {
            case "1":
                Console.Clear();
                FirstMenu.ShowMenu();
                break;//end of number 1
            case "2":
                Console.Clear();
                Environment.Exit(0);
                break;//end of number 1

            default:
                Console.Clear();
                Console.WriteLine($"************* You entered the wrong argument *************");
                goto secondChance;
        }//End of switch




    }//End of Seller Signup Menu
}//End of signup class
