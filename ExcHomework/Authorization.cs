using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExcHomework
{
    public class Authorization
    {
        public static bool CheckData(string login, string password, string confirmPassword)
        {
            try
            {
                if (login.Length > 20 || login == null || login.Contains(' '))
                {
                    throw new WrongLoginException("Ошибка в логине - проверьте правильность ввода \nLogin не меньше 20 символов и не должен содержать пробелы");
                }
                if (password.Length > 20 || password == null || password.Contains(' ') || !password.Any(char.IsDigit) || password != confirmPassword)
                {
                    throw new WrongPasswordException("Ошибка в пароле - проверьте правильность ввода \nPassword не меньше 20 символов, без пробелов и должен содержать хотя бы одну цифру.\nТак же убедитесь, что пароль и подтверждение пароля одинаковые.");
                }
            }
            catch (WrongLoginException extlog)
            {
                Console.WriteLine($"Ошибка: {extlog.Message}");
            }
            catch (WrongPasswordException extpass)
            {
                Console.WriteLine($"Ошибка: {extpass.Message}");
            }
            return true;
        }
    }
}
