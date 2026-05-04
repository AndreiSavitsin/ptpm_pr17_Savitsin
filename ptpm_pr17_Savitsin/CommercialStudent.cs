using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptpm_pr17_Savitsin
{
    public class CommercialStudent : StudentsClass //Класс-наследик
    {
        int paySemester; //Оплата за семестр
        int depositedAmount; //Внесенная сумма
        public int PaySemester { get; set; }
        public int DepositedAmount { get; set; }
        public CommercialStudent(string surname, string speciality, int course, string fullOrPart, int paySemester, int depositedAmount) : base(surname, speciality, course, fullOrPart)
        {
            PaySemester = paySemester;
            DepositedAmount = depositedAmount;
        }
        public override string GetInfo()
        {
            return $"Фамилия: {Surname}. Специальность: {Speciality}. " +
                $"Курс: {Course}. Очное или заочное: {FullOrPart}. Оплата за семестр: {PaySemester}. Внесенная сумма: {DepositedAmount}";
        }
    }
}
