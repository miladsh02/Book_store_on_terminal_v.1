using System;
using System.Collections.Generic;
using System.Text;


public class Report
{
    public static List<Report> Reports = new List<Report>();
    public string ReportMassage;
    public string UsernameOfSender;
    public string FullNameOfSender;
    public string SenderAccessLevel;
    public Report(string reportMassage, string usernameOfSender, string fullNameOfSender, string senderAccessLevel)
    {
        ReportMassage = reportMassage;
        UsernameOfSender = usernameOfSender;
        FullNameOfSender = fullNameOfSender;
        SenderAccessLevel = senderAccessLevel;
    }//end of report

    public static void GetReport()
    {
        Console.WriteLine("Here you can enter you massage down blow just dont forget\n" +
                          "to mention the name of things.\n" +
                          "enter your report downblow:");
        string reportMassage = Console.ReadLine();


        Reports.Add(new Report(reportMassage, Situation.U_Name, Situation.Full_Name, Situation.U_Situation));
        


        switch (Situation.U_Situation)
        {
            case "Seller":
                Console.Clear();
            tryagain:
                Console.WriteLine("Your report succussfuly sended \n" +
                                  "1.First Menu\n" +
                                  "2.Exit");
                Console.Write("Enter Here:");
                string WhereGo = Console.ReadLine();
                switch (WhereGo)
                {
                    case "1":
                        FirstMenu.SellerShowMenu();
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong Argument try again");
                        goto tryagain;
                }

                break;
            case "Customer":
                Console.Clear();
            trryagain:
                Console.WriteLine("Your report succussfuly sended \n" +
                                  "1.First Menu\n" +
                                  "2.Exit");
                Console.Write("Enter Here:");
                string WwhereGo = Console.ReadLine();
                switch (WwhereGo)
                {
                    case "1":
                        Console.Clear();
                        FirstMenu.CustomerShowMenu();
                        break;
                    case "2":
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong Argument try again");
                        goto trryagain;
                }
                break;
        }//end of switch
    }// end of get report
    public static void ShowReports()
    {
    //i-1
    trryagain:
        Int32 length = Reports.Count;
        for (int i = 0; i < Reports.Count; i++)
        {
            Console.WriteLine($"******************************************\n" +
                              $"Name of sender:{Reports[i].FullNameOfSender}\n" +
                              $"Username of sender:{Reports[i].UsernameOfSender}\n" +
                              $"Sender Access Level:{Reports[i].SenderAccessLevel}\n" +
                              $"The Massge:\n" +
                              $"{Reports[i].ReportMassage}\n" +
                              $"******************************************\n");
        }//end of for
            Console.WriteLine("1.First Menu\n" +
                                  "2.Exit");
            Console.Write("Enter here:");
            string WhereToGo = Console.ReadLine();
            switch (WhereToGo)
            {
                case "1":
                    Console.Clear();
                    FirstMenu.AdminShowMenu();
                    break;
                case "2":
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong Argument try again");
                    goto trryagain;

            }//End of switch




        }//end of ShowReports

    
}//end of class

