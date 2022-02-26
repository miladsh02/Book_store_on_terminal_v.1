using System;
using System.Collections.Generic;
using System.Text;


    class OrderList
    {
    public string NameOfTheBook;
    public string NameOfSeller;
    public string NameOfReciver;
    public string Address;
    public int DeliveryTime;
    public int PriceOfTheBook;
    public static List<OrderList> Orders = new List<OrderList>();
    public void CustomerOrderList()
    {
        for (int i = 0; i < Orders.Count; i++)
        {
            if (Orders[i].NameOfSeller == Situation.U_Name)
            {
                Console.WriteLine($"-------------------------------\n" +
                              $"Name of the BooK:{Orders[i].NameOfTheBook}\n" +
                              $"DeliveryTime: {Orders[i].DeliveryTime} Days\n" +
                              $"Address: {Orders[i].Address}\n" +
                              $"-------------------------------");
            }//End of if
        }//End of for
                
    }//End of CustomerOrderList
    public void SellerOrderList()
    {
        for(int i=0;i< Orders.Count; i++) { 
        if(Orders[i].NameOfSeller== Situation.U_Name) { 
        Console.WriteLine($"-------------------------------\n" +
                          $"Name of the BooK:{Orders[i].NameOfTheBook}\n" +
                          $"Name Of Reciver: {Orders[i].NameOfReciver}\n" +
                          $"DeliveryTime: {Orders[i].DeliveryTime} Days\n" +
                          $"Address: {Orders[i].Address}\n" +
                          $"-------------------------------");
            }//End of if
        }//End of for 
    }//End of SellerOrderList
    public void AdminOrderList()
    {
        for (int i = 0; i < Orders.Count; i++)
        {
            Console.WriteLine($"-------------------------------\n" +
                          $"Name of the BooK:{Orders[i].NameOfTheBook}\n" +
                          $"Name Of Seller : {Orders[i].NameOfSeller}\n" +
                          $"Name of the BooK:{Orders[i].NameOfTheBook}\n" +
                          $"DeliveryTime: {Orders[i].DeliveryTime} Days\n" +
                          $"Price Of The Book:{Orders[i].PriceOfTheBook} Toman" +
                          $"Address: {Orders[i].Address}\n" +
                          $"-------------------------------");
        }//End of for
    }//End of AdminOrderList

}

