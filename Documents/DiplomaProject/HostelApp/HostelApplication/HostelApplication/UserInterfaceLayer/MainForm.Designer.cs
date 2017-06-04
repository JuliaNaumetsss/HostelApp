namespace HostelApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonalInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFunctionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrearsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkedHoursArrearsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentArrearsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OtherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkedHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddThingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.SurnameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumberEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.cmbFileFormat = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(915, 496);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(127, 37);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfoMenuItem,
            this.mainFunctionMenuItem,
            this.infoMenuItem,
            this.OtherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalInfoMenuItem
            // 
            this.personalInfoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonalInfoMenuItem,
            this.editPasswordMenuItem});
            this.personalInfoMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalInfoMenuItem.Name = "personalInfoMenuItem";
            this.personalInfoMenuItem.Size = new System.Drawing.Size(231, 32);
            this.personalInfoMenuItem.Text = "Кабинет пользователя";
            // 
            // showPersonalInfoMenuItem
            // 
            this.showPersonalInfoMenuItem.Name = "showPersonalInfoMenuItem";
            this.showPersonalInfoMenuItem.Size = new System.Drawing.Size(290, 32);
            this.showPersonalInfoMenuItem.Text = "Личная информация";
            this.showPersonalInfoMenuItem.Click += new System.EventHandler(this.showPersonalInfoMenuItem_Click);
            // 
            // editPasswordMenuItem
            // 
            this.editPasswordMenuItem.Name = "editPasswordMenuItem";
            this.editPasswordMenuItem.Size = new System.Drawing.Size(290, 32);
            this.editPasswordMenuItem.Text = "Изменить пароль";
            this.editPasswordMenuItem.Click += new System.EventHandler(this.editPasswordMenuItem_Click);
            // 
            // mainFunctionMenuItem
            // 
            this.mainFunctionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeUserMenuItem,
            this.addUserMenuItem,
            this.editUserMenuItem});
            this.mainFunctionMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainFunctionMenuItem.Name = "mainFunctionMenuItem";
            this.mainFunctionMenuItem.Size = new System.Drawing.Size(206, 32);
            this.mainFunctionMenuItem.Text = "Основные функции";
            // 
            // removeUserMenuItem
            // 
            this.removeUserMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeEmployeeMenuItem,
            this.removeStudentMenuItem});
            this.removeUserMenuItem.Name = "removeUserMenuItem";
            this.removeUserMenuItem.Size = new System.Drawing.Size(363, 32);
            this.removeUserMenuItem.Text = "Удалить пользователя";
            // 
            // removeEmployeeMenuItem
            // 
            this.removeEmployeeMenuItem.Name = "removeEmployeeMenuItem";
            this.removeEmployeeMenuItem.Size = new System.Drawing.Size(281, 32);
            this.removeEmployeeMenuItem.Text = "Удалить сотрудника";
            this.removeEmployeeMenuItem.Click += new System.EventHandler(this.removeEmployeeMenuItem_Click);
            // 
            // removeStudentMenuItem
            // 
            this.removeStudentMenuItem.Name = "removeStudentMenuItem";
            this.removeStudentMenuItem.Size = new System.Drawing.Size(281, 32);
            this.removeStudentMenuItem.Text = "Удалить студента";
            this.removeStudentMenuItem.Click += new System.EventHandler(this.removeStudentMenuItem_Click);
            // 
            // addUserMenuItem
            // 
            this.addUserMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeMenuItem,
            this.addStudentMenuItem});
            this.addUserMenuItem.Name = "addUserMenuItem";
            this.addUserMenuItem.Size = new System.Drawing.Size(363, 32);
            this.addUserMenuItem.Text = "Добавить пользователя";
            // 
            // addEmployeeMenuItem
            // 
            this.addEmployeeMenuItem.Name = "addEmployeeMenuItem";
            this.addEmployeeMenuItem.Size = new System.Drawing.Size(297, 32);
            this.addEmployeeMenuItem.Text = "Добавить сотрудника";
            this.addEmployeeMenuItem.Click += new System.EventHandler(this.addEmployeeMenuItem_Click);
            // 
            // addStudentMenuItem
            // 
            this.addStudentMenuItem.Name = "addStudentMenuItem";
            this.addStudentMenuItem.Size = new System.Drawing.Size(297, 32);
            this.addStudentMenuItem.Text = "Добавить студента";
            this.addStudentMenuItem.Click += new System.EventHandler(this.addStudentMenuItem_Click);
            // 
            // editUserMenuItem
            // 
            this.editUserMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEmployeeMenuItem,
            this.editStudentMenuItem});
            this.editUserMenuItem.Name = "editUserMenuItem";
            this.editUserMenuItem.Size = new System.Drawing.Size(363, 32);
            this.editUserMenuItem.Text = "Редактировать пользователя";
            // 
            // editEmployeeMenuItem
            // 
            this.editEmployeeMenuItem.Name = "editEmployeeMenuItem";
            this.editEmployeeMenuItem.Size = new System.Drawing.Size(343, 32);
            this.editEmployeeMenuItem.Text = "Редактировать сотрудника";
            this.editEmployeeMenuItem.Click += new System.EventHandler(this.editEmployeeMenuItem_Click);
            // 
            // editStudentMenuItem
            // 
            this.editStudentMenuItem.Name = "editStudentMenuItem";
            this.editStudentMenuItem.Size = new System.Drawing.Size(343, 32);
            this.editStudentMenuItem.Text = "Редактировать студента";
            this.editStudentMenuItem.Click += new System.EventHandler(this.editStudentMenuItem_Click);
            // 
            // infoMenuItem
            // 
            this.infoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInfoMenuItem,
            this.employeeInfoMenuItem,
            this.ArrearsToolStripMenuItem});
            this.infoMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoMenuItem.Name = "infoMenuItem";
            this.infoMenuItem.Size = new System.Drawing.Size(276, 32);
            this.infoMenuItem.Text = "Просмотреть информацию";
            // 
            // studentInfoMenuItem
            // 
            this.studentInfoMenuItem.Name = "studentInfoMenuItem";
            this.studentInfoMenuItem.Size = new System.Drawing.Size(392, 32);
            this.studentInfoMenuItem.Text = "Информация о студентах";
            this.studentInfoMenuItem.Click += new System.EventHandler(this.studentInfoMenuItem_Click);
            // 
            // employeeInfoMenuItem
            // 
            this.employeeInfoMenuItem.Name = "employeeInfoMenuItem";
            this.employeeInfoMenuItem.Size = new System.Drawing.Size(392, 32);
            this.employeeInfoMenuItem.Text = "Информация о сотрудниках";
            this.employeeInfoMenuItem.Click += new System.EventHandler(this.employeeInfoMenuItem_Click);
            // 
            // ArrearsToolStripMenuItem
            // 
            this.ArrearsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WorkedHoursArrearsToolStripMenuItem,
            this.PaymentArrearsToolStripMenuItem});
            this.ArrearsToolStripMenuItem.Name = "ArrearsToolStripMenuItem";
            this.ArrearsToolStripMenuItem.Size = new System.Drawing.Size(392, 32);
            this.ArrearsToolStripMenuItem.Text = "Информация о задолженностях";
            // 
            // WorkedHoursArrearsToolStripMenuItem
            // 
            this.WorkedHoursArrearsToolStripMenuItem.Name = "WorkedHoursArrearsToolStripMenuItem";
            this.WorkedHoursArrearsToolStripMenuItem.Size = new System.Drawing.Size(337, 32);
            this.WorkedHoursArrearsToolStripMenuItem.Text = "Задолженность по ОХЧ";
            this.WorkedHoursArrearsToolStripMenuItem.Click += new System.EventHandler(this.WorkedHoursArrearsToolStripMenuItem_Click);
            // 
            // PaymentArrearsToolStripMenuItem
            // 
            this.PaymentArrearsToolStripMenuItem.Name = "PaymentArrearsToolStripMenuItem";
            this.PaymentArrearsToolStripMenuItem.Size = new System.Drawing.Size(337, 32);
            this.PaymentArrearsToolStripMenuItem.Text = "Задолженность по оплате";
            this.PaymentArrearsToolStripMenuItem.Click += new System.EventHandler(this.PaymentArrearsToolStripMenuItem_Click);
            // 
            // OtherToolStripMenuItem
            // 
            this.OtherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InspectionToolStripMenuItem,
            this.WorkedHoursToolStripMenuItem,
            this.PaymentToolStripMenuItem,
            this.AddThingsToolStripMenuItem});
            this.OtherToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem";
            this.OtherToolStripMenuItem.Size = new System.Drawing.Size(177, 32);
            this.OtherToolStripMenuItem.Text = "Другие функции";
            // 
            // InspectionToolStripMenuItem
            // 
            this.InspectionToolStripMenuItem.Name = "InspectionToolStripMenuItem";
            this.InspectionToolStripMenuItem.Size = new System.Drawing.Size(283, 32);
            this.InspectionToolStripMenuItem.Text = "Проверка блока";
            this.InspectionToolStripMenuItem.Click += new System.EventHandler(this.InspectionToolStripMenuItem_Click);
            // 
            // WorkedHoursToolStripMenuItem
            // 
            this.WorkedHoursToolStripMenuItem.Name = "WorkedHoursToolStripMenuItem";
            this.WorkedHoursToolStripMenuItem.Size = new System.Drawing.Size(283, 32);
            this.WorkedHoursToolStripMenuItem.Text = "Добавление ОХЧ";
            this.WorkedHoursToolStripMenuItem.Click += new System.EventHandler(this.WorkedHoursToolStripMenuItem_Click);
            // 
            // PaymentToolStripMenuItem
            // 
            this.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem";
            this.PaymentToolStripMenuItem.Size = new System.Drawing.Size(283, 32);
            this.PaymentToolStripMenuItem.Text = "Добавление оплаты";
            this.PaymentToolStripMenuItem.Click += new System.EventHandler(this.PaymentToolStripMenuItem_Click);
            // 
            // AddThingsToolStripMenuItem
            // 
            this.AddThingsToolStripMenuItem.Name = "AddThingsToolStripMenuItem";
            this.AddThingsToolStripMenuItem.Size = new System.Drawing.Size(283, 32);
            this.AddThingsToolStripMenuItem.Text = "Оформление вещей";
            this.AddThingsToolStripMenuItem.Click += new System.EventHandler(this.AddThingsToolStripMenuItem_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.Name,
            this.Patronymic,
            this.Floor,
            this.Room,
            this.LoginStudent});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudents.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowTemplate.Height = 28;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1178, 388);
            this.dataGridViewStudents.TabIndex = 2;
            this.dataGridViewStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewStudents_MouseDoubleClick);
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 220;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 220;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            this.Patronymic.Width = 290;
            // 
            // Floor
            // 
            this.Floor.HeaderText = "Этаж";
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            this.Floor.Width = 120;
            // 
            // Room
            // 
            this.Room.HeaderText = "Комната";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Width = 150;
            // 
            // LoginStudent
            // 
            this.LoginStudent.HeaderText = "Login";
            this.LoginStudent.Name = "LoginStudent";
            this.LoginStudent.ReadOnly = true;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameEmployee,
            this.NameEmployee,
            this.PatronymicEmployee,
            this.EmployeeType,
            this.RoomNumberEmployee,
            this.Login});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowTemplate.Height = 28;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1166, 454);
            this.dataGridViewEmployees.TabIndex = 6;
            this.dataGridViewEmployees.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewEmployees_MouseDoubleClick);
            // 
            // SurnameEmployee
            // 
            this.SurnameEmployee.HeaderText = "Фамилия";
            this.SurnameEmployee.Name = "SurnameEmployee";
            this.SurnameEmployee.Width = 220;
            // 
            // NameEmployee
            // 
            this.NameEmployee.HeaderText = "Имя";
            this.NameEmployee.Name = "NameEmployee";
            this.NameEmployee.Width = 220;
            // 
            // PatronymicEmployee
            // 
            this.PatronymicEmployee.HeaderText = "Отчество";
            this.PatronymicEmployee.Name = "PatronymicEmployee";
            this.PatronymicEmployee.Width = 270;
            // 
            // EmployeeType
            // 
            this.EmployeeType.HeaderText = "Должность";
            this.EmployeeType.Name = "EmployeeType";
            this.EmployeeType.Width = 160;
            // 
            // RoomNumberEmployee
            // 
            this.RoomNumberEmployee.HeaderText = "Номер кабинета";
            this.RoomNumberEmployee.Name = "RoomNumberEmployee";
            this.RoomNumberEmployee.Width = 130;
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(965, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(51, 20);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "label1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.Location = new System.Drawing.Point(549, 500);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(168, 34);
            this.buttonOpenFile.TabIndex = 8;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // cmbFileFormat
            // 
            this.cmbFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileFormat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFileFormat.FormattingEnabled = true;
            this.cmbFileFormat.Items.AddRange(new object[] {
            "MS Word",
            "MS Excel"});
            this.cmbFileFormat.Location = new System.Drawing.Point(723, 501);
            this.cmbFileFormat.Name = "cmbFileFormat";
            this.cmbFileFormat.Size = new System.Drawing.Size(186, 33);
            this.cmbFileFormat.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 545);
            this.ControlBox = false;
            this.Controls.Add(this.cmbFileFormat);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
           // this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт и мониторинг студентов, проживающих в общежитии";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonalInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainFunctionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmployeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStudentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.ToolStripMenuItem OtherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkedHoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArrearsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkedHoursArrearsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaymentArrearsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddThingsToolStripMenuItem;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.ComboBox cmbFileFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumberEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
    }
}