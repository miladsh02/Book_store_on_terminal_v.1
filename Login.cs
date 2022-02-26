using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Login
{
    public void FirrstMenu(){
        secondChance:
        Console.Write("Please enter the menu you want" +
            "\n----------------------\n" +
            "1.Sign in\n" +
            "2.Sign up\n" +            
            "3.Exit\n" +
            "Enter here:");
        string CheckNumber = Console.ReadLine();        

        switch (CheckNumber)
        {
            case "1":
                Console.Clear();
                var Login = new Login();
                Login.LoginMenu();                
                break;//End of number 1
            case "2":
                Console.Clear();
                var Signup = new Signup();
                Signup.ShowSignupMenu();
                break;//End of number 2          
            case "3":
                Console.Clear();
                Environment.Exit(0);
                break;//End of number 3
            default:
                Console.Clear();
                Console.WriteLine($"************* You entered the wrong argument *************");
                goto secondChance;
        }//End of switch
    }//End of FirstMenu  
     
    public void LoginMenu() {
        //Get lists of Accounts
        List<Account> Cheek = new List<Account>();                                  //Creat Cheek List
        Admin AGetList = new Admin();                                               //Creat Admin Object
        AGetList.SetAdmin();                                                        //Active AdminList    
        Customer CGetList = new Customer();                                         //Creat Customer Object
        CGetList.SetCustomer();                                                     //Active CustomerList 
        Seller SGetList = new Seller();                                             //Creat Seller Object
        SGetList.SetSeller();                                                       //Active SellerList 
        Cheek.AddRange(Signup.NewCustomerList);                                     //Add new Customers  
        Cheek.AddRange(Signup.NewSellerList);                                       //Add new SellerList 
        Cheek.AddRange(AGetList.AdminList);                                         //Add Admin List To Cheek List
        Cheek.AddRange(CGetList.CustomerList);                                      //Add Customer List To Cheek List
        Cheek.AddRange(SGetList.SellerList);                                        //Add Seller List To Cheek List

        loginSeconChance:
        //Get Username and PassWord from user
        Console.Write("Username:");
        string CheckUsername = Console.ReadLine();
        Console.Write("Password:");
        string CheckPassword = Console.ReadLine();

        //Cheek the Username and Password
        int NumberList;
        bool Result=false;
        string accessLevel="";
        for(int i=0;i<Cheek.Count; i++)
        {
            if(Cheek[i].Username== CheckUsername&& Cheek[i].Password== CheckPassword)
            {
                NumberList = i;
                accessLevel = Cheek[i].AccessLevel;
                Result = true;
                Situation.U_Name = Cheek[i].Username;
                Situation.Full_Name = Cheek[i].FullName;
                Situation.U_Situation = Cheek[i].AccessLevel;
                break;
            }//end of if
        }//end of for
        

        if (Result == true)
        { 
            switch (accessLevel)
            {
                case "Admin":
                    Console.Clear();
                    FirstMenu.AdminShowMenu();
                    break;
                case "Customer":
                    Console.Clear();
                    FirstMenu.CustomerShowMenu();
                    break;
                case "Seller":
                    Console.Clear();
                    FirstMenu.SellerShowMenu();
                    break;               
            }//End of switch
        }//End of if
        else 
        {
            Console.Clear();
            Console.WriteLine("*********** Your Username or Password is wrong ***********");
            goto loginSeconChance;
        }//End of else
    }//End of LoginMenu
    }//End of class

