using System.Text.RegularExpressions;

namespace EmailValidateDemo
{
    public class Program
        {
            public static void Main(string[] args)
            {
                string[] emails = new string[] { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", ".abc@abc.com" };
                foreach (string email in emails)
                {
                    if (IsValidEmail(email))
                        Console.WriteLine(email + " is valid");
                    else
                        Console.WriteLine(email + " is invalid");
                }
            }
            public static bool IsValidEmail(string email)
            {
                string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                    + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                    + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                return regex.IsMatch(email);
            }
    }
    
}