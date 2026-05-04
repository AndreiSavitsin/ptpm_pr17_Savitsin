using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptpm_pr17_Savitsin
{
    public static class Validation //Класс для проверки
    {
        public static string ValidateSurname(string surname)
        {
            if (surname == "")
            {
                return "Фамилия не может быть пустой";
            }
            foreach (char c in surname)
            {
                if (!char.IsLetter(c))
                {
                    return "Фамилия должна содержать только буквы";
                }
            }
            return "";
        }

        public static string ValidateSpeciality(string speciality)
        {
            if (speciality == "")
            {
                return "Специальность не может быть пустой";
            }
            foreach (char c in speciality)
            {
                if (!char.IsLetter(c))
                {
                    return "Специальность должна содержать только буквы";
                }
            }
            return "";
        }

        public static string ValidateCourse(int course)
        {
            if (course <=0 || course > 4)
            {
                return "Курс не может быть <=0 или >4";
            }
            return "";
        }

        public static string ValidateFullOrPart(string fullOrPart)
        {
            if (fullOrPart == "")
            {
                return "Поле не может быть пустым";
            }
            if (fullOrPart.ToLower() == "очное" || fullOrPart.ToLower() == "заочное") return "";
            else return "Неверный формат записи";
        }

        public static string ValidateLivesDormitory(string livesDormitory)
        {
            if (livesDormitory == "")
            {
                return "Поле не может быть пустым";
            }
            if (livesDormitory.ToLower() == "да" || livesDormitory.ToLower() == "нет")
            {
                return "";
            }
            else
            {
                return "Неверный формат ответа";
            }
        }

        public static string ValidatePaySemester(int paySemester)
        {
            if (paySemester <= 0) return "Сумма не может быть <= 0";
            return "";
        }

        public static string ValidateDepositedAmount(int depositedAmount)
        {
            if (depositedAmount <= 0) return "Сумма не может быть <= 0";
            return "";
        }
    }
}
