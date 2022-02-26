using System;
using System.Collections.Generic;
using System.Text;


class Book
{
    //program initialize ProductCode
    protected int ProductCode { get; set; }
    //User Must Enter
    public string BookCondition { get; set; }
    public string NameOfTheBook { get; set; }
    public string Author { get; set; }
    public string Publishers { get; set; }
    public string Translator { get; set; }
    public string Genre { get; set; }
    public string Language { get; set; }
    public int NumberOfPages { get; set; }
    //Its Good to Enter
    public int YearOfPublication { get; set; }
    public string CoverMaterial { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public string BookType { get; set; }
    public double Product_Code { get; set; }
    //Just for NewBooks
    public int Price { get; set; }
    public int Inventory { get; set; }
    public int RentTime { get; set; }
    public int DeliveryTime;
    public string UsernameOfTheSeller;

    public override string ToString() =>
        $"ProductCode:{ProductCode}\nNameOfTheBook={NameOfTheBook}\nAuthor={Author}\nPublishers={Publishers}" +
        $"\nTranslator={Translator}\nGenre={Genre}\nLanguage={Language}\nNumberOfPages{NumberOfPages}" +
        $"\nYearOfPublication={YearOfPublication}\nCoverMaterial={CoverMaterial}\nLength={Length}\nHeight={Height}" +
        $"\nWeight={Weight}\nBookType={BookType}\nProduct_Code={Product_Code}\nPrice={Price}\nInventory={Inventory}";






}


