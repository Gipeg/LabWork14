using System.Text.RegularExpressions;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string input = Console.ReadLine();
            string regexPattern = @"\s{2,}";
            string replacement = " ";

            string result = Regex.Replace(input, regexPattern, replacement);
            Console.WriteLine("Результат: " + result);
        }
    }
}
