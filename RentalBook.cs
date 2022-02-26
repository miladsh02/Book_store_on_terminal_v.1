using System;
using System.Collections.Generic;
using System.Text;


    class RentalBook:Book
    {
    public RentalBook(string Name_Of_The_Book, string author, string publishers,
            string translator, string genre, string language, int numberOfPages, string bookCondition, int rentTime, int price,
            int procuct_code, int inventory, int deliveryTime, string userNameOfSeller)
    {
        NameOfTheBook = Name_Of_The_Book;
        Author = author;
        Publishers = publishers;
        Translator = translator;
        Genre = genre;
        Language = language;
        NumberOfPages = numberOfPages;
        BookCondition = bookCondition;
        RentTime = rentTime;
        Price = price;
        BookType = "Rental Book";
        Product_Code = procuct_code;
        Inventory = inventory;
        DeliveryTime = deliveryTime;
        UsernameOfTheSeller = userNameOfSeller;
    }//End of public RentalBook

    //To String Report
    public override string ToString() =>
    $"{NameOfTheBook,-25}{Author,-16}{Publishers,-25}{Genre,-10}{RentTime,-4} Days   {Price + " Toman",-18}{Product_Code,-6} ";

    }//End of class

