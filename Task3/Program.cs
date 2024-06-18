using System.Text.RegularExpressions;

            Console.WriteLine("Введите адрес электроной почты:");
            string input = Console.ReadLine();
            string regexPattern = @"^[a-zA-z0-9_.+-]+@[a-zA-z0-9-]+\.[a-zA-z0-9-.]+$";

            if (Regex.IsMatch(input, regexPattern)) 
            {
                Console.WriteLine("Адрес введён верно");
            }
            else
            {
                Console.WriteLine("Адрес введён не верно");
            }
