namespace ptpm_pr17_Savitsin
{
    public abstract class StudentsClass //Базовый класс
    {
        static public List<StudentsClass> studentsList = new List<StudentsClass>();

        string surname; //Фамилия
        string speciality; //Специальность
        int course; //Курс
        string fullOrPart; //Очник или заочник

        public string Surname { get; set; }
        public string Speciality { get; set; }
        public int Course { get; set; }
        public string FullOrPart { get; set; }
        public StudentsClass(string surname, string speciality, int course, string fullOrPart) 
        {
            this.surname = surname;
            this.speciality = speciality;
            this.course = course;
            this.fullOrPart = fullOrPart;
        }
        public abstract string GetInfo();
    }
}
