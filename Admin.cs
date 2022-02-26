using System;
using System.Collections.Generic;
using System.Text;

    class Admin:Account
    {
    public List<Admin> AdminList = new List<Admin>();
    public void SetAdmin()
    {
        AdminList.Add(new Admin { Username = "milad", Password = "milad123", AccessLevel = "Admin", FullName ="Milad Shafiei" });
        AdminList.Add(new Admin { Username = "nayebpor", Password = "nayebpor123", AccessLevel = "Admin", FullName = "- Noyebpor" });//Who learn me how to learn programming
    }//end of SetAdmin       
    }//End of class
