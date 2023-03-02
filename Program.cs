using System.Text.RegularExpressions;

namespace EmailValidateDemo
{
    public class Program
    {

        public static bool func()
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            string email = "abc-100@yahoo.com";
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            Program.func();
        } 
    }
}