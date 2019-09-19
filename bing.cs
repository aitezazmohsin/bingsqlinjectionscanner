Author : Etizaz Mohsin
Date : 2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.IO;

namespace SilentPoison
{
    class Program
    {
        static string AccountKey = "";
        static List<string> webs = new List<string>();
        static List<string> vulwebs = new List<string>();
        static void Main(string[] args)
        {
            mainmenu();

            Console.ReadKey();
        }

        static void header()
        {
            Console.Title = "Silent Poison";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t      ---------------------------------");
            Console.WriteLine("\t\t         --==[[ Silent Poison ]]==--\n");
            Console.WriteLine("\t\t\t        Coded By : SOG");
            Console.Write("\t\t      ---------------------------------\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t        --==[[ Bing Based SQL injection scanner ]]==--\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
        }

        static void mainmenu()
        {
 
                header();
                bugfinder();
             
        }

        static void bugfinder()
        {
            Console.Clear();
            header();

            Console.Write("\n");
            
            
            int skipx = 0;
            int lol = 0;
            string ip;
            string dork;
            try {
            Console.Write("\tEnter Website/ip : ");
            ip = Console.ReadLine();
            Console.Write("\n\tEnter Dork : ");
            dork = Console.ReadLine();

            IPHostEntry ipe = Dns.GetHostByName(ip);
            IPAddress address = ipe.AddressList[0];
            // This is the query expression.
            //182.50.146.128

            string query = "ip:" + address.ToString() + " " + dork;

            // Create a Bing container.
            Console.WriteLine("\n");
            string rootUrl = "https://api.datamarket.azure.com/Bing/SearchWeb/v1/Web";

            var bingContainer = new Bing.BingSearchContainer(new Uri(rootUrl));

            // The market to use.

            string market = "en-us";

            // Configure bingContainer to use your credentials.

            bingContainer.Credentials = new NetworkCredential(AccountKey, AccountKey);

            // Build the query, limiting to 10 results.
            for (int i = 0; i < 20; i++)
            {

                var webQuery =

                bingContainer.Web(query, null, null, market, null, null, null, null);

                webQuery = webQuery.AddQueryOption("$skip", skipx);
                webQuery = webQuery.AddQueryOption("$top", 50);
                skipx += 50;



                // Run the query and display the results.

                var webResults = webQuery.Execute();

                if (i == 1)
                {
                    Console.SetCursorPosition(21,13);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Server " + address.ToString() + " Under Scanning" );
                    Console.ResetColor();
                }

                if (i == 1)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 2)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 3)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 4)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 5)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 6)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 7)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 8)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 9)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 10)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 11)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 12)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 13)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 14)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 15)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 16)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 17)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 18)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 19)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }

                if (i == 20)
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Please Wait");
                    Console.ResetColor();
                }



                foreach (var result in webResults)
                {

                    string x = result.Url.ToString();
                    if (x.IndexOf("=") != -1)
                    {
                        webs.Add(x);

                    }
                    else
                    {
                        lol++;
                    }
                }
            }


            webs = webs.Distinct().ToList();


           
            Console.Clear();
            header();
            checkbug();
            
        }catch(Exception ex) {
            Console.Write("\t" + ex.Message + "\n");
            Thread.Sleep(3000);
            Console.Clear();
            bugfinder();
    }
            Console.WriteLine("Press Any Key to Go to Mainmenu !");
            Console.ReadKey();
            mainmenu();
        }

        static void checkbug()
        {
            

            
            string error1 = "You have an error in your SQL syntax";
            string error2 = "mysql_fetch_array()";
            string error3 = "execute query";
            string error4 = "mysql_fetch_object()";
            string error5 = "mysql_num_rows()";
            string error6 = "mysql_fetch_assoc()";
            string error7 = "mysql_fetch_row()";
            string error8 = "SELECT * FROM";
            string error9 = "supplied argument is not a valid MySQL";
            string error10 = "Syntax error";
            string error11 = "Fatal error";


            WebClient myclient = new WebClient();
            

            for (int i = 0; i < webs.Count; i++)
            {
                try
                {
                    Console.Write("\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tTotal Websites Checked : " + i + "/" + webs.Count + "\n\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tChecking => " + webs[i]);
                    Console.ResetColor();
                    string web = myclient.DownloadString(webs[i] + "'");

                    if (web.IndexOf(error1) != -1)
                    {
                        vulwebs.Add(webs[i]);
                    }

                    if (web.IndexOf(error2) != -1)
                    {
                        vulwebs.Add(webs[i]);
                    }

                    if (web.IndexOf(error3) != -1)
                    {
                        vulwebs.Add(webs[i]);
                    }

                    if (web.IndexOf(error4) != -1)
                    {
                        vulwebs.Add(webs[i]);
                    }

                    if (web.IndexOf(error5) != -1)
                    {
                        vulwebs.Add(webs[i]);
                    }

                    if (web.IndexOf(error6) != -1)
                    {
                        vulwebs.Add(webs[i]);
                    }

                    if (web.IndexOf(error7) != -1)
                    {
                        vulwebs.Add(webs[i]);
                    }

                    if (web.IndexOf(error8) != -1)
                    {
                        vulwebs.Add(webs[i]);
                    }

                    if (web.IndexOf(error9) != -1)
                    {
                        vulwebs.Add(webs[i]);
                    }

                    if (web.IndexOf(error10) != -1)
                    {
                        vulwebs.Add(webs[i]);
                    }

                    if (web.IndexOf(error11) != -1)
                    {
                        vulwebs.Add(webs[i]);
                    }


                    Thread.Sleep(100);
                    Console.Clear();
                    header();
                }
                catch (WebException ex)
                {
                    Console.Clear();
                }

            }
            vulwebs = vulwebs.Distinct().ToList();
            Console.Clear();
            header();
            Console.Write("\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\n\nVulnerable Websites\n\n");
            display();
            
        }

        static void display()
        {
            TextWriter write = new StreamWriter("sites.txt");
             
            foreach (string x in vulwebs)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(x + "\n");
                Console.ResetColor();
                write.WriteLine(x);
            }
            write.Close();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   \n Vulnerable Sites Saved to sites.txt");
            Console.WriteLine("   \n Press Any key to go to Mainmenu");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            mainmenu();
        }
       
    }

    
}
