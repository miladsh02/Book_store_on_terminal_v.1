using System;
using System.Collections.Generic;
using System.Text;


class Customer : Account
{
    public List<Customer> CustomerList = new List<Customer>();
    public void SetCustomer()
    {
        CustomerList.Add(new Customer { Username = "mohammad", Password = "mohammad123", AccessLevel = "Customer", FullName = "Mohammad Sadeghi" ,EmailAddress="m@gmail.com"});
    }//End of SetCustomer
}//End of class

