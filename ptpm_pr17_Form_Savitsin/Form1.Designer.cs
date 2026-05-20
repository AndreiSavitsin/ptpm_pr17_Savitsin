namespace ptpm_pr17_Form_Savitsin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fdasToolStripMenuItem = new ToolStripMenuItem();
            бюджетныйСтудентToolStripMenuItem = new ToolStripMenuItem();
            коммерческийСтудентToolStripMenuItem = new ToolStripMenuItem();
            fsdaToolStripMenuItem = new ToolStripMenuItem();
            бюджетныеСтудентыToolStripMenuItem = new ToolStripMenuItem();
            коммерческиеСтудентыToolStripMenuItem = new ToolStripMenuItem();
            показатьToolStripMenuItem = new ToolStripMenuItem();
            txtSurname = new TextBox();
            txtSpeciality = new TextBox();
            txtCourse = new TextBox();
            txtFullOrPart = new TextBox();
            groupBoxGeneral = new GroupBox();
            txtLiveDorm = new TextBox();
            groupBoxBudjet = new GroupBox();
            btnAddBud = new Button();
            groupBoxCom = new GroupBox();
            btnAddCom = new Button();
            txtDeposAmount = new TextBox();
            txtPaySemester = new TextBox();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBoxGeneral.SuspendLayout();
            groupBoxBudjet.SuspendLayout();
            groupBoxCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fdasToolStripMenuItem, fsdaToolStripMenuItem, показатьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1301, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fdasToolStripMenuItem
            // 
            fdasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { бюджетныйСтудентToolStripMenuItem, коммерческийСтудентToolStripMenuItem });
            fdasToolStripMenuItem.Name = "fdasToolStripMenuItem";
            fdasToolStripMenuItem.Size = new Size(121, 20);
            fdasToolStripMenuItem.Text = "Добавить студента";
            // 
            // бюджетныйСтудентToolStripMenuItem
            // 
            бюджетныйСтудентToolStripMenuItem.Name = "бюджетныйСтудентToolStripMenuItem";
            бюджетныйСтудентToolStripMenuItem.Size = new Size(202, 22);
            бюджетныйСтудентToolStripMenuItem.Text = "Бюджетный студент";
            бюджетныйСтудентToolStripMenuItem.Click += бюджетныйСтудентToolStripMenuItem_Click;
            // 
            // коммерческийСтудентToolStripMenuItem
            // 
            коммерческийСтудентToolStripMenuItem.Name = "коммерческийСтудентToolStripMenuItem";
            коммерческийСтудентToolStripMenuItem.Size = new Size(202, 22);
            коммерческийСтудентToolStripMenuItem.Text = "Коммерческий студент";
            коммерческийСтудентToolStripMenuItem.Click += коммерческийСтудентToolStripMenuItem_Click;
            // 
            // fsdaToolStripMenuItem
            // 
            fsdaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { бюджетныеСтудентыToolStripMenuItem, коммерческиеСтудентыToolStripMenuItem });
            fsdaToolStripMenuItem.Name = "fsdaToolStripMenuItem";
            fsdaToolStripMenuItem.Size = new Size(69, 20);
            fsdaToolStripMenuItem.Text = "Показать";
            // 
            // бюджетныеСтудентыToolStripMenuItem
            // 
            бюджетныеСтудентыToolStripMenuItem.Name = "бюджетныеСтудентыToolStripMenuItem";
            бюджетныеСтудентыToolStripMenuItem.Size = new Size(210, 22);
            бюджетныеСтудентыToolStripMenuItem.Text = "Бюджетные студенты";
            бюджетныеСтудентыToolStripMenuItem.Click += бюджетныеСтудентыToolStripMenuItem_Click;
            // 
            // коммерческиеСтудентыToolStripMenuItem
            // 
            коммерческиеСтудентыToolStripMenuItem.Name = "коммерческиеСтудентыToolStripMenuItem";
            коммерческиеСтудентыToolStripMenuItem.Size = new Size(210, 22);
            коммерческиеСтудентыToolStripMenuItem.Text = "Коммерческие студенты";
            коммерческиеСтудентыToolStripMenuItem.Click += коммерческиеСтудентыToolStripMenuItem_Click;
            // 
            // показатьToolStripMenuItem
            // 
            показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            показатьToolStripMenuItem.Size = new Size(54, 20);
            показатьToolStripMenuItem.Text = "Выход";
            показатьToolStripMenuItem.Click += показатьToolStripMenuItem_Click;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(28, 24);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Введите фамилию";
            txtSurname.Size = new Size(175, 23);
            txtSurname.TabIndex = 1;
            // 
            // txtSpeciality
            // 
            txtSpeciality.Location = new Point(28, 71);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.PlaceholderText = "Введите специальность";
            txtSpeciality.Size = new Size(175, 23);
            txtSpeciality.TabIndex = 2;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(28, 117);
            txtCourse.Name = "txtCourse";
            txtCourse.PlaceholderText = "Введите курс";
            txtCourse.Size = new Size(175, 23);
            txtCourse.TabIndex = 3;
            // 
            // txtFullOrPart
            // 
            txtFullOrPart.Location = new Point(28, 167);
            txtFullOrPart.Name = "txtFullOrPart";
            txtFullOrPart.PlaceholderText = "Очное или заочное обучение";
            txtFullOrPart.Size = new Size(175, 23);
            txtFullOrPart.TabIndex = 4;
            // 
            // groupBoxGeneral
            // 
            groupBoxGeneral.Controls.Add(txtFullOrPart);
            groupBoxGeneral.Controls.Add(txtCourse);
            groupBoxGeneral.Controls.Add(txtSpeciality);
            groupBoxGeneral.Controls.Add(txtSurname);
            groupBoxGeneral.Location = new Point(30, 59);
            groupBoxGeneral.Name = "groupBoxGeneral";
            groupBoxGeneral.Size = new Size(240, 201);
            groupBoxGeneral.TabIndex = 5;
            groupBoxGeneral.TabStop = false;
            groupBoxGeneral.Visible = false;
            // 
            // txtLiveDorm
            // 
            txtLiveDorm.Location = new Point(53, 13);
            txtLiveDorm.Name = "txtLiveDorm";
            txtLiveDorm.PlaceholderText = "Живёт в общежитии (да/нет)";
            txtLiveDorm.Size = new Size(175, 23);
            txtLiveDorm.TabIndex = 6;
            // 
            // groupBoxBudjet
            // 
            groupBoxBudjet.Controls.Add(btnAddBud);
            groupBoxBudjet.Controls.Add(txtLiveDorm);
            groupBoxBudjet.Location = new Point(4, 266);
            groupBoxBudjet.Name = "groupBoxBudjet";
            groupBoxBudjet.Size = new Size(320, 164);
            groupBoxBudjet.TabIndex = 7;
            groupBoxBudjet.TabStop = false;
            groupBoxBudjet.Visible = false;
            // 
            // btnAddBud
            // 
            btnAddBud.Location = new Point(54, 59);
            btnAddBud.Name = "btnAddBud";
            btnAddBud.Size = new Size(176, 41);
            btnAddBud.TabIndex = 11;
            btnAddBud.Text = "Добавить";
            btnAddBud.UseVisualStyleBackColor = true;
            btnAddBud.Click += btnAddBud_Click;
            // 
            // groupBoxCom
            // 
            groupBoxCom.Controls.Add(btnAddCom);
            groupBoxCom.Controls.Add(txtDeposAmount);
            groupBoxCom.Controls.Add(txtPaySemester);
            groupBoxCom.Location = new Point(30, 266);
            groupBoxCom.Name = "groupBoxCom";
            groupBoxCom.Size = new Size(262, 199);
            groupBoxCom.TabIndex = 10;
            groupBoxCom.TabStop = false;
            groupBoxCom.Visible = false;
            // 
            // btnAddCom
            // 
            btnAddCom.Location = new Point(29, 112);
            btnAddCom.Name = "btnAddCom";
            btnAddCom.Size = new Size(176, 41);
            btnAddCom.TabIndex = 12;
            btnAddCom.Text = "Добавить";
            btnAddCom.UseVisualStyleBackColor = true;
            btnAddCom.Click += btnAddCom_Click;
            // 
            // txtDeposAmount
            // 
            txtDeposAmount.Location = new Point(29, 63);
            txtDeposAmount.Name = "txtDeposAmount";
            txtDeposAmount.PlaceholderText = "Введите внесённую сумму";
            txtDeposAmount.Size = new Size(175, 23);
            txtDeposAmount.TabIndex = 9;
            // 
            // txtPaySemester
            // 
            txtPaySemester.Location = new Point(29, 13);
            txtPaySemester.Name = "txtPaySemester";
            txtPaySemester.PlaceholderText = "Введите оплату за семестр";
            txtPaySemester.Size = new Size(175, 23);
            txtPaySemester.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(516, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(710, 382);
            dataGridView1.TabIndex = 11;
            dataGridView1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 542);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxCom);
            Controls.Add(groupBoxBudjet);
            Controls.Add(groupBoxGeneral);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxGeneral.ResumeLayout(false);
            groupBoxGeneral.PerformLayout();
            groupBoxBudjet.ResumeLayout(false);
            groupBoxBudjet.PerformLayout();
            groupBoxCom.ResumeLayout(false);
            groupBoxCom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fdasToolStripMenuItem;
        private ToolStripMenuItem fsdaToolStripMenuItem;
        private ToolStripMenuItem бюджетныйСтудентToolStripMenuItem;
        private ToolStripMenuItem коммерческийСтудентToolStripMenuItem;
        private ToolStripMenuItem бюджетныеСтудентыToolStripMenuItem;
        private ToolStripMenuItem коммерческиеСтудентыToolStripMenuItem;
        private ToolStripMenuItem показатьToolStripMenuItem;
        private TextBox txtSurname;
        private TextBox txtSpeciality;
        private TextBox txtCourse;
        private TextBox txtFullOrPart;
        private GroupBox groupBoxGeneral;
        private TextBox txtLiveDorm;
        private GroupBox groupBoxBudjet;
        private TextBox txtPaySemester;
        private TextBox txtDeposAmount;
        private GroupBox groupBoxCom;
        private Button btnAddBud;
        private Button btnAddCom;
        private DataGridView dataGridView1;
    }
}
