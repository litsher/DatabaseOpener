
using System;
using System.Data;
using System.Data.OleDb;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("-----------------------------");
                Console.WriteLine("| 0 0 0 0 0 0 0 0 0 0 0 0 0 | ");
                Console.WriteLine("| Nathan's database opener! | ");
                Console.WriteLine("| 0 0 0 0 0 0 0 0 0 0 0 0 0 | ");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();


            var myDataTable = new DataTable();
            using (var con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Nathan\\AppData\\Roaming\\Jaangle\\Storage\\Database\\music.mdb;Jet OLEDB:Database Password=DontMessWithIt"))
            {
            drLabel:
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                string help;
                Console.WriteLine("Put in help for a list of all functions.");
                Console.WriteLine();
                help = Console.ReadLine();
                if (help == "help")
                {
                    Console.WriteLine();
                    string number;
                    Console.WriteLine("put in the number of the function you want to use");
                    Console.WriteLine();
                    Console.WriteLine("1. Show what bands are in the database.");
                    Console.WriteLine("2. Show the full libary of one of the bands.");
                    Console.WriteLine("3. Show a specific subject of one of the bands.");
                    Console.WriteLine("4. Get back to the start.");
                    Console.WriteLine();
                    number = Console.ReadLine();

                    if (number == "1")
                    {
                        con.Open();
                        Console.WriteLine();
                        var query = "Select Name From Artists where ID > 3";
                        OleDbCommand command = new OleDbCommand(query, con);
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine(reader[0].ToString());
                        }
                        reader.Close();
                        Console.WriteLine();
                        String YRN;
                        lab:
                        Console.WriteLine("Do you want to close the program or get back to start?");
                        Console.WriteLine("(Back is go to start, Close is close.)");
                        Console.WriteLine();
                        YRN = Console.ReadLine();
                        if (YRN == "Back")
                        {
                            goto drLabel;
                        }
                        if (YRN == "Close")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please put in Back or Start (With a capital letter.)");
                            Console.WriteLine();
                            goto lab;
                        }
                    }

                    if (number == "2")
                    {
                        string line;
                        con.Open();
                        do
                        {
                            Console.WriteLine("(CTRL + Z To stop)");
                            Console.WriteLine("What Band do you wanna see our databse from? :");
                            Console.WriteLine();
                            line = Console.ReadLine();
                            if (line == "TBR")
                            {
                                Console.WriteLine();
                                var query = "SELECT Tracks.ID, Tracks.Name, Artists.Name, Albums.Name FROM (Tracks LEFT OUTER JOIN Artists ON Tracks.artID=Artists.ID) LEFT OUTER JOIN Albums ON Tracks.albID=Albums.ID WHERE Artists.Name = 'The Boxer Rebellion'";
                                OleDbCommand command = new OleDbCommand(query, con);
                                OleDbDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(reader[0].ToString());
                                    Console.WriteLine(reader[1].ToString());
                                    Console.WriteLine(reader[2].ToString());
                                    Console.WriteLine(reader[3].ToString());
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                reader.Close();
                                Console.WriteLine();
                                String YRN;
                                lab:
                                Console.WriteLine("Do you want to close the program or get back to start?");
                                Console.WriteLine("(Back is go to start, Close is close.)");
                                Console.WriteLine();
                                YRN = Console.ReadLine();
                                if (YRN == "Back")
                                {
                                    goto drLabel;
                                }
                                if (YRN == "Close")
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Please put in Back or Start (With a capital letter.)");
                                    Console.WriteLine();
                                    goto lab;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You Didn't type TBR!");
                            }
                        } while (line != null);
                    }

                    if (number == "3")
                    {
                        string line;
                        con.Open();
                        do
                        {
                            Console.WriteLine("(CTRL + Z To stop)");
                            Console.WriteLine("Choose the band");
                            line = Console.ReadLine();
                            if (line == "TBR")
                            {
                                Console.WriteLine("Choose from Songs or Albums");
                                string lines = Console.ReadLine();
                                if (lines == "Songs")
                                {
                                    var query = "Select Name From Tracks where artID = 4";
                                    OleDbCommand command = new OleDbCommand(query, con);
                                    OleDbDataReader reader = command.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        Console.WriteLine(reader[0].ToString());
                                    }
                                    reader.Close();
                                    Console.WriteLine();
                                    String YRN;
                                    lab:
                                    Console.WriteLine("Do you want to close the program or get back to start?");
                                    Console.WriteLine("(Back is go to start, Close is close.)");
                                    Console.WriteLine();
                                    YRN = Console.ReadLine();
                                    if (YRN == "Back")
                                    {
                                        goto drLabel;
                                    }
                                    if (YRN == "Close")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Please put in Back or Start (With a capital letter.)");
                                        Console.WriteLine();
                                        goto lab;
                                    }
                                }
                                if (lines == "Albums")
                                {
                                    var query = "Select Name From Albums where artID = 4";
                                    OleDbCommand command = new OleDbCommand(query, con);
                                    OleDbDataReader reader = command.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        Console.WriteLine(reader[0].ToString());
                                    }
                                    reader.Close();
                                    Console.WriteLine();
                                    String YRN;
                                    lab:
                                    Console.WriteLine("Do you want to close the program or get back to start?");
                                    Console.WriteLine("(Back is go to start, Close is close.)");
                                    Console.WriteLine();
                                    YRN = Console.ReadLine();
                                    if (YRN == "Back")
                                    {
                                        goto drLabel;
                                    }
                                    if (YRN == "Close")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Please put in Back or Start (With a capital letter.)");
                                        Console.WriteLine();
                                        goto lab;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("You Didn't type TBR!");
                            }
                        } while (line != null);
                    }

                    if (number == "4")
                    {
                        goto drLabel;
                    }


                }
            }
        }

        public static object laze { get; set; }
    }
}