using System;
using System.Collections.Generic;
using System.Text;
    class BookOrder
    {
    public string NameOfReciver { get; set; }
    public string AddressOfReciver { get; set; }
    public string NameOfTheBook { get; set; }
    public override string ToString() =>
        $"NameOfReciver:{NameOfReciver}\nAddress Of Reciver: {AddressOfReciver}\nName Of The Book:{NameOfTheBook}";
    }//class BookOrder

