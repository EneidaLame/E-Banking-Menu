using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using System.IO;namespace assessment{    class Program    {
        static void Main(string[] args)        {            Init();            ExitManager();            RegisterLoginMenu();            LoginManager();            RegisterManager();            AskUsernameView();            AskPasswordView();            DisplayMenou();
            
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


        public static void RegisterLoginMenu()        {            Console.WriteLine("Welcome user");            Console.WriteLine("-----------------");            Console.WriteLine("1 - Login");            Console.WriteLine("2 - Register");            Console.WriteLine("3 - Exit");        }        public static void AskUsernameView()        {            Console.WriteLine("Give me your username");


        }        public static void AskPasswordView()        {            Console.WriteLine("Give me your password");        }        public static void DisplayMenou()        {            Console.WriteLine("Hello User");            Console.WriteLine("Choose");            Console.WriteLine("1 - Money Balance");            Console.WriteLine("2 - Withdrawal");            Console.WriteLine("3 - Deposit");            Console.WriteLine("4 - Exit");        }

        public static string InputString()        {            return Console.ReadLine();        }        public static int ParseInt(string str)        {            return Convert.ToInt32(str);        }

        public static bool Name(string name, string pass)
        {
            if (!HasCapitalLetter(pass)) return false;            if (!HasLowerLetter(pass)) return false;            if (!Hasdigit(pass)) return false;            if (!HasSymbol(pass)) return false;            if (!HasValidLength(pass)) return false;            if (!HasUsername(pass, name)) return false;            return true;
        }
        public static bool isStrongPassword(string pass, string password)        {            if (!HasCapitalLetter(pass)) return false;            if (!HasLowerLetter(pass)) return false;            if (!Hasdigit(pass)) return false;            if (!HasSymbol(pass)) return false;            if (!HasValidLength(pass)) return false;            if (!HasUsername(pass, password)) return false;            return true;


        }        public static bool HasUsername(string pass, string username) => !pass.Contains(username);        public static bool HasCapitalLetter(string pass) => !pass.Any(x => char.IsUpper(x));        public static bool HasLowerLetter(string pass) => !pass.Any(x => char.IsLower(x));        public static bool Hasdigit(string pass) => !pass.Any(x => char.IsDigit(x));        public static bool HasSymbol(string pass) => !pass.Any(x => char.IsSymbol(x));        public static bool HasValidLength(string pass) => pass.Length > 6 && pass.Length < 20;        public static void Init()        {            RegisterLoginMenu();

            string choice = InputString();            if (choice == "1")            {
                int counter = 0;


                while (counter < 3)                {                    if (LoginManager()) break;                    else counter++;

                }
                

            }            else if (choice == "2")            {                RegisterManager();            }            else if (choice == "3")            {                ExitManager();

            }        }        public static void ExitManager()        {            Console.WriteLine("Goodbye");
            Environment.Exit(0);  //you exit here
        }        public static bool LoginManager()        {            AskUsernameView();            string username = InputString();
            
            AskPasswordView();            string password = InputString();            return isValidUsernamePassword(username, password);        }        public static void RegisterManager()        {
            Console.WriteLine("Please give me your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Please give me your last name");
            string lname = Console.ReadLine();

            Random n = new Random();
            int money = n.Next(1000, 100000);
                    }        public static bool isValidUsernamePassword(string username, string password)        {

         //connection with the databse for the validation
            return true;        }        public static bool SetAlarm(bool employed, bool vacation)        {            if (employed == true && vacation == true)            {                return false;            }            else if (employed == false && vacation == true)            {                return false;            }            else if (employed == false && vacation == false)            {                return true;            }            else            {                return true;            }        }        public static void DisplayBalanceInfo(string names, int amount)        {            Console.WriteLine("Name : " + names);            Console.WriteLine("Money : " + amount);        }
     

    }
}

       
                
            
        
    
