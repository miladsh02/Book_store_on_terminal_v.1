using System;
using System.Collections.Generic;
using System.Text;


    class MoreDetailsNewBook: Book
{
    public void Detials(int Product_Code) {
        Console.WriteLine($"Book Name :{NameOfTheBook}\nAuthor:{Author}\nPrice:{Price} Toman\nInventory:{Inventory}\nTranslator:{Translator}");
    Console.WriteLine($"\nBookType:{BookType}\nNumberOfPages{NumberOfPages}\nPublishers:{Publishers}\nGenre:{Genre}\nLanguage{Language}");
            }
    public override string ToString() =>
        $"Book Name :{NameOfTheBook}\nAuthor:{Author}\nPrice:{Price} Toman\nInventory:{Inventory}\nTranslator:{Translator}" +
        $"\nBookType:{BookType}\nNumberOfPages{NumberOfPages}\nPublishers:{Publishers}\nGenre:{Genre}\nLanguage{Language}";
    }

