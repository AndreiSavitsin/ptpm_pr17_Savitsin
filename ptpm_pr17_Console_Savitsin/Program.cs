using ptpm_pr17_Savitsin;

StudentsClass student = new StudentsClass();

Console.Write("Введите фамилию: ");
student.Surname = Console.ReadLine();

Console.Write("Введите специальность: ");
student.Speciality = Console.ReadLine();

Console.Write("Введите курс: ");
if (int.TryParse(Console.ReadLine(), out int course))
{
    student.Course = course;
}

Console.Write("Очное или заочное обучение: ");
student.FullOrPart = Console.ReadLine();

Console.WriteLine(StudentsClass.GetInfo(student));

Console.ReadKey();
