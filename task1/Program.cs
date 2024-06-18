using System;
using System.Text.RegularExpressions;


        Console.WriteLine("Введите номер телефона: ");
        string input = Console.ReadLine();

        string regexPattern = @"^(\+7|8)\((9\d{2})\)\d{3}-\d{2}-\d{2}$";

        if(Regex.IsMatch(input, regexPattern))
        {
        Console.WriteLine("Номер введён верно");
        }
        else
        {
        Console.WriteLine("Номер введён НЕ верно");
            
        }