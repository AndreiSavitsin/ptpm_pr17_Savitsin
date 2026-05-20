using ptpm_pr17_Savitsin;

namespace ptpm_pr17_Form_Savitsin
{
    public partial class Form1 : Form
    {
        List<BudgetStudent> budjetList = new List<BudgetStudent>(); //Лист бюджетных студентов
        List<CommercialStudent> comList = new List<CommercialStudent>(); //Лист коммерческих студентов

        public Form1()
        {
            InitializeComponent();
        }

        private void бюджетныйСтудентToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка в меню добавить бюджетного студента
        {
            groupBoxGeneral.Visible = true;
            groupBoxBudjet.Visible = true;
            groupBoxCom.Visible = false;
        }

        private void коммерческийСтудентToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка в меню добавить коммерческого студента
        {
            groupBoxGeneral.Visible = true;
            groupBoxBudjet.Visible = false;
            groupBoxCom.Visible = true;
        }

        private void бюджетныеСтудентыToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка в меню показать бюджетных студентов
        {
            groupBoxGeneral.Visible = false;
            groupBoxBudjet.Visible = false;
            groupBoxCom.Visible = false;

            string text = "бюджетные";
            FillDataGrid(text);
        }

        private void коммерческиеСтудентыToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка в меню показать коммерческих студентов
        {
            groupBoxGeneral.Visible = false;
            groupBoxBudjet.Visible = false;
            groupBoxCom.Visible = false;

            string text = "коммерческие";
            FillDataGrid(text);
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка в меню выход
        {
            this.Close();
        }

        private void FillDataGrid(string text) //Заполнение dataGridView
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (text == "бюджетные")
            {

            }
            else if (text == "коммерческие")
            {

            }
        }
        private void SaveBudjetStudent() //Сохранить бюджетного студента
        {
            using (StreamWriter sw = File.AppendText("infoBudjet.txt"))
            {
                foreach (var item in budjetList)
                {
                    sw.WriteLine($"{item.Surname}|{item.Speciality}|{item.Course}|{item.FullOrPart}|{item.LivesDormitory}");
                }
            }
        }
        private void SaveComStudent() //Сохранить коммерческого
        {
            using (StreamWriter sw = File.AppendText("infoCom.txt"))
            {
                foreach (var item in comList)
                {
                    sw.WriteLine($"{item.Surname}|{item.Speciality}|{item.Course}|{item.FullOrPart}|{item.PaySemester}|{item.DepositedAmount}");
                }
            }
        }

        private void btnAddBud_Click(object sender, EventArgs e) //Кнопка добавить бюджетного студента
        {
            string surname = txtSurname.Text;
            string errorSurname = Validation.ValidateSurname(surname);
            if (!String.IsNullOrEmpty(errorSurname))
            {
                MessageBox.Show(errorSurname, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string speciality = txtSpeciality.Text;
            string errorSpec = Validation.ValidateSpeciality(speciality);
            if (!String.IsNullOrEmpty(errorSpec))
            {
                MessageBox.Show(errorSpec, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtCourse.Text, out int course))
            {
                string errorCourse = Validation.ValidateCourse(course);
                if (!String.IsNullOrEmpty(errorCourse))
                {
                    MessageBox.Show(errorCourse, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Курс должен быть целым числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fullOrPart = txtFullOrPart.Text;
            string errorFOP = Validation.ValidateFullOrPart(fullOrPart);
            if (!String.IsNullOrEmpty(errorFOP))
            {
                MessageBox.Show(errorFOP, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string livesDormitory = txtLiveDorm.Text;
            string errorLiveDorm = Validation.ValidateLivesDormitory(livesDormitory);
            if (!String.IsNullOrEmpty(errorLiveDorm))
            {
                MessageBox.Show(errorLiveDorm, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BudgetStudent budgetStudent = new BudgetStudent("", "", 0, "", "");
            budgetStudent.Surname = surname;
            budgetStudent.Speciality = speciality;
            budgetStudent.Course = course;
            budgetStudent.FullOrPart = fullOrPart;
            budgetStudent.LivesDormitory = livesDormitory;
            budjetList.Add(budgetStudent);
            SaveBudjetStudent();
        }

        private void btnAddCom_Click(object sender, EventArgs e) //Кнопка добавить коммерческого студента
        {
            string surname = txtSurname.Text;
            string errorSurname = Validation.ValidateSurname(surname);
            if (!String.IsNullOrEmpty(errorSurname))
            {
                MessageBox.Show(errorSurname, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string speciality = txtSpeciality.Text;
            string errorSpec = Validation.ValidateSpeciality(speciality);
            if (!String.IsNullOrEmpty(errorSpec))
            {
                MessageBox.Show(errorSpec, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtCourse.Text, out int course))
            {
                string errorCourse = Validation.ValidateCourse(course);
                if (!String.IsNullOrEmpty(errorCourse))
                {
                    MessageBox.Show(errorCourse, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Курс должен быть целым числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fullOrPart = txtFullOrPart.Text;
            string errorFOP = Validation.ValidateFullOrPart(fullOrPart);
            if (!String.IsNullOrEmpty(errorFOP))
            {
                MessageBox.Show(errorFOP, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtPaySemester.Text, out int paySemester))
            {
                string errorPaySemester = Validation.ValidatePaySemester(paySemester);
                if (!String.IsNullOrEmpty(errorPaySemester))
                {
                    MessageBox.Show(errorPaySemester, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Оплата за семестр должна быть целым числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtDeposAmount.Text, out int deposAmount))
            {
                string errorDeposAmount = Validation.ValidateDepositedAmount(deposAmount);
                if (!String.IsNullOrEmpty(errorDeposAmount))
                {
                    MessageBox.Show(errorDeposAmount, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Внесённая сумма должна быть целым числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CommercialStudent commercialStudent = new CommercialStudent("", "", 0, "", 0, 0);
            commercialStudent.Surname = surname;
            commercialStudent.Speciality = speciality;
            commercialStudent.Course = course;
            commercialStudent.FullOrPart = fullOrPart;
            commercialStudent.PaySemester = paySemester;
            commercialStudent.DepositedAmount = deposAmount;
            comList.Add(commercialStudent);
            SaveComStudent();
        }
    }
}
