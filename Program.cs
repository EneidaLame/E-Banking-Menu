﻿using System;
        static void Main(string[] args)
            
            List<string> names = new List<string>() { "Eneida", "Panos", "Kostas" };
            List<string> surnames = new List<string>() { "Lame", "Pappas", "Papadopoulos" };
            List<string> mouneyamount = new List<string>() { "50000", "3000", "4000" };
            List<string> password = new List<string>() { "3g893#5r", "3045u9$", "3049ue@" };
            List<string> content = new List<string>();

            string path = @"C:\Users\Eneid\Desktop\assessment\file.txt";//create a .txt

            Console.WriteLine("Please give me your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Please give me your last name");
            string lname = Console.ReadLine();

            Random n = new Random();
            int money = n.Next(1000, 100000);

            var con = string.Join(",", fname, lname, money);
            List<string> contents = new List<string>();
            contents.Add(con);

            File.ReadAllLines(path).ToList();

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

        }


        public static void RegisterLoginMenu()


        }

        public static string InputString()

        public static bool Name(string name, string pass)
        {
            if (!HasCapitalLetter(pass)) return false;
        }
        public static bool isStrongPassword(string pass, string password)


        }

            string choice = InputString();
                int counter = 0;


                while (counter < 3)

                }
                

            }

            }
            Environment.Exit(0);  //you exit here
        }
            
            AskPasswordView();
            Console.WriteLine("Please give me your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Please give me your last name");
            string lname = Console.ReadLine();

            Random n = new Random();
            int money = n.Next(1000, 100000);


         //connection with the databse for the validation
            return true;
     

    }
}

       
                
            
        
    
