using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Utils.Helpers
{
    public static class Checker
    {
      public  static bool EmailChecker(string emailadress)

        {
            Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");
            return regex.IsMatch(emailadress);

        }

      public   static bool PasswordChecker(string password)
        {

            if (password.Length >= 8 & HasUpper(password) && HasLower(password) && HasDigit(password))
            {
                return true;
            }return false;
        }
      public  static bool HasUpper(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                    return true;
            }
            return false;
        }

       public  static bool HasLower(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                    return true;
            }
            return false;
        }

      public  static bool HasDigit(string password)
        {
            foreach (var item in password)
            {
                if (char.IsDigit(item))
                    return true;
            }
            return false;
        }


     }
}
