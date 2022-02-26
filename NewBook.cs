using System;
using System.Collections.Generic;
using System.Text;


    class NewBook:Book
    {    
    public NewBook(string Name_Of_The_Book, string author, string publishers,
            string translator, string genre, string language, int numberOfPages,int price,int procuct_code, int inventory,int deliveryTime,string userNameOfSeller) 
    {
        NameOfTheBook = Name_Of_The_Book;
        Author = author;
        Publishers = publishers;
        Translator = translator;
        Genre = genre;
        Language = language;
        NumberOfPages = numberOfPages;
        Price = price;
        BookType = "NewBook";
        Product_Code = procuct_code;
        Inventory=inventory;
        DeliveryTime = deliveryTime;
        UsernameOfTheSeller = userNameOfSeller;
    }//End of public AddNewBook

        //To String Report
        public override string ToString() =>
        $"{NameOfTheBook,-20}{Author,-16}{Publishers,-25}{Genre,-10}{Price +" Toman",-18}{Product_Code,-6} ";
    }//End Of The Class

