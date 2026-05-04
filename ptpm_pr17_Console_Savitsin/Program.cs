using ptpm_pr17_Savitsin;

bool start = true;
while (start)
{
    bool temp = true;
    while (temp)
    {
        Console.Write("Бюджетный или коммерческий студент: ");
        string otvet = Console.ReadLine();

        if (otvet.ToLower() == "бюджетный")
        {
            temp = false;
            AddBudgetStudent();
        }
        else if (otvet.ToLower() == "коммерческий")
        {
            temp = false;
            AddCommercialStudent();
        }
        else
        {
            temp = true;
            Console.WriteLine("Некорректное значение");
        }
    }

    Console.WriteLine("\nВсе студенты:");
    ShowAllStudents();

    bool temp2 = true;
    while (temp2)
    {
        Console.Write("\nДобавить ещё студента? (да/нет): ");
        string otv = Console.ReadLine();
        if (otv.ToLower() == "нет")
        {
            temp2 = false;
            start = false;
        }
        else if (otv.ToLower() == "да")
        {
            temp2 = false;
            start = true;
        }
        else
        {
            temp2 = true;
            Console.WriteLine("Неверное значение");
        }
    }
}

static void AddBudgetStudent() //Добавление бюджетного студента
{
    string surname;
    while (true)
    {
        Console.Write("Введите фамилию: ");
        surname = Console.ReadLine();

        string error = Validation.ValidateSurname(surname);
        if (error == "") break;
        else Console.WriteLine(error);
    }

    string speciality;
    while (true)
    {
        Console.Write("Введите специальность: ");
        speciality = Console.ReadLine();
        string error = Validation.ValidateSpeciality(speciality);
        if (error == "") break;
        else Console.WriteLine(error);
    }

    int course;
    while (true)
    {
        Console.Write("Введите курс: ");
        if (int.TryParse(Console.ReadLine(), out course))
        {
            string error = Validation.ValidateCourse(course);
            if (error == "") break;
            else Console.WriteLine(error);
        }
    }

    string fullOrPart;
    while (true)
    {
        Console.Write("Очное или заочное обучение: ");
        fullOrPart = Console.ReadLine();
        string error = Validation.ValidateFullOrPart(fullOrPart);
        if (error == "") break;
        else Console.WriteLine(error);
    }

    BudgetStudent budgetStudent = new BudgetStudent("", "", 0, "", "");
    budgetStudent.Surname = surname;
    budgetStudent.Speciality = speciality;
    budgetStudent.Course = course;
    budgetStudent.FullOrPart = fullOrPart;

    string livesDormitory;
    while (true)
    {
        Console.Write("Живёт в общежитии (да/нет): ");
        livesDormitory = Console.ReadLine();
        string error = Validation.ValidateLivesDormitory(livesDormitory);
        if (error == "") break;
        else Console.WriteLine(error);
    }

    budgetStudent.LivesDormitory = livesDormitory;
    StudentsClass.studentsList.Add(budgetStudent);
    Console.WriteLine($"\n{budgetStudent.GetInfo()}");
}

static void AddCommercialStudent() //Добавление коммерческого студента
{
    string surname;
    while (true)
    {
        Console.Write("Введите фамилию: ");
        surname = Console.ReadLine();

        string error = Validation.ValidateSurname(surname);
        if (error == "") break;
        else Console.WriteLine(error);
    }

    string speciality;
    while (true)
    {
        Console.Write("Введите специальность: ");
        speciality = Console.ReadLine();
        string error = Validation.ValidateSpeciality(speciality);
        if (error == "") break;
        else Console.WriteLine(error);
    }

    int course;
    while (true)
    {
        Console.Write("Введите курс: ");
        if (int.TryParse(Console.ReadLine(), out course))
        {
            string error = Validation.ValidateCourse(course);
            if (error == "") break;
            else Console.WriteLine(error);
        }
    }

    string fullOrPart;
    while (true)
    {
        Console.Write("Очное или заочное обучение: ");
        fullOrPart = Console.ReadLine();
        string error = Validation.ValidateFullOrPart(fullOrPart);
        if (error == "") break;
        else Console.WriteLine(error);
    }

    CommercialStudent commercialStudent = new CommercialStudent("", "", 0, "", 0, 0);
    commercialStudent.Surname = surname;
    commercialStudent.Speciality = speciality;
    commercialStudent.Course = course;
    commercialStudent.FullOrPart = fullOrPart;

    int paySemester;
    while (true)
    {
        Console.Write("Введите оплату за семестр: ");
        if (int.TryParse(Console.ReadLine(), out paySemester))
        {
            string error = Validation.ValidatePaySemester(paySemester);
            if (error == "") break;
            else Console.WriteLine(error);
        }
        else
        {
            Console.WriteLine("Неверное значение");
        }
    }
    commercialStudent.PaySemester = paySemester;

    int depositedAmount;

    while (true)
    {
        Console.Write("Введите сумму, которую хотите внести: ");
        if (int.TryParse(Console.ReadLine(), out depositedAmount))
        {
            string error = Validation.ValidateDepositedAmount(depositedAmount);
            if (error == "") break;
            else Console.WriteLine(error);
        }
        else
        {
            Console.WriteLine("Неверное значение");
        }
    }
    commercialStudent.DepositedAmount = depositedAmount;
    StudentsClass.studentsList.Add(commercialStudent);
    Console.WriteLine($"\n{commercialStudent.GetInfo()}");
}

static void ShowAllStudents()
{
    foreach (var item in StudentsClass.studentsList)
    {
        Console.WriteLine(item.GetInfo());
    }
}

Console.ReadKey();