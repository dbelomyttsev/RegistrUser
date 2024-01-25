using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrUser
{
    public class RegistrValidation
    {
        private string errorMessage;
        public string ErrorMessage { get { return errorMessage; } }
        public bool ValidatePassword(string password) 
        {
            if (string.IsNullOrEmpty(password)) 
            {
                errorMessage = "Пароль пустой!";
                return false;
            }
            if (password.Length < 8)
            {
                errorMessage = "Пароль меньше 8 символов!";
                return false;
            }
            if (!password.Contains('@') || !password.Contains(',') || !password.Contains('!'))
            {
                errorMessage = "Пароль должен содержать символы \"@,!\"!";
                return false;

            }
            if (!password.Any(char.IsLower) || !password.Any(char.IsUpper))
            {
                errorMessage = "Пароль должен содержать верхний и нижний регистры!";
                return false;
            }
            return true;
        }
    }
}
