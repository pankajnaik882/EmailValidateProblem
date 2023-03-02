using System.Text.RegularExpressions;

namespace EmailValidateDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string email = " abc-100@abc.net";

            if (Regex.IsMatch(email, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}