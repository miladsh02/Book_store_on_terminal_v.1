using System;
using System.Collections.Generic;
using System.Text;
class Seller : Account
{
    public List<Seller> SellerList = new List<Seller>();
    public int BankCardAddress;
    public int IDCardCode;
    public void SetSeller()
    {
        SellerList.Add(new Seller { Username = "reza", Password = "reza123", AccessLevel = "Seller", FullName = "Reza Seyedi", EmailAddress = "r@gmail.com" }) ;
    }//End of SetSeller
}//End of class