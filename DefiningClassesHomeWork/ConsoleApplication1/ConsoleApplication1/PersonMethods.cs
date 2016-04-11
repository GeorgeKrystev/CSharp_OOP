using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class PersonMethods
    {
        private const string EmailPattern = @"^[a-z0-9!#$%&'*+\/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+\/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        private const string NamePattern = @"^[A-Z][a-zA-Z- ]+$";

        public static bool ValidateName(string name)
        {
            Regex nameMatcher = new Regex(NamePattern);
            return nameMatcher.IsMatch(name);
        }

        public static bool ValidateAge(int age)
        {
            return age >= 1 && age <= 100;
        }

        public static bool ValidateEmail(string email)
        {
            Regex emailMatcher = new Regex(EmailPattern);
            return emailMatcher.IsMatch(email);
        }
    }
}
