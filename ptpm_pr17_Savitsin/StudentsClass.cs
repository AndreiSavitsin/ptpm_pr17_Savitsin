namespace ptpm_pr17_Savitsin
{
    public class StudentsClass //Базовый класс
    {
        static List<StudentsClass> studentsList = new List<StudentsClass>();

        string surname; //Фамилия
        string speciality; //Специальность
        int course; //Курс
        string fullOrPart; //Очник или заочник

        public string Surname { get; set; }
        public string Speciality { get; set; }
        public int Course { get; set; }
        public string FullOrPart { get; set; }
        public StudentsClass() { }

        static public string GetInfo(StudentsClass student)
        {
            return $"Фамилия: {student.Surname}. Специальность: {student.Speciality}. " +
                $"Курс: {student.Course}. Очник или заочник: {student.FullOrPart}";
        }
    }
}
