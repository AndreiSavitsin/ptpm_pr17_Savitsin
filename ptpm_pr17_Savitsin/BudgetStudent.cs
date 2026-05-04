using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptpm_pr17_Savitsin
{
    public class BudgetStudent : StudentsClass //Класс-наследник
    {
        string livesDormitory; //Живет в общежитии
        public string LivesDormitory { get; set; }
        public BudgetStudent(string surname, string speciality, int course, string fullOrPart, string livesDormitory) : base(surname, speciality, course, fullOrPart)
        {
            this.livesDormitory = livesDormitory;
        }
        public override string GetInfo()
        {
            return $"Фамилия: {Surname}. Специальность: {Speciality}. " +
                $"Курс: {Course}. Очное или заочное: {FullOrPart}. Живёт в общежитии: {LivesDormitory}";
        }
    }
}
