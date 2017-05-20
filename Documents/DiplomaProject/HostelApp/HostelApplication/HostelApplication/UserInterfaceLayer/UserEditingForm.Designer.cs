namespace HostelApplication
{
    partial class UserEditingForm
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
            this.panelCommonInfo = new System.Windows.Forms.Panel();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.labPatronymic = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbPassport = new System.Windows.Forms.Label();
            this.panelStudentInfo = new System.Windows.Forms.Panel();
            this.cmbRoomStudent = new System.Windows.Forms.ComboBox();
            this.cmbFloorStudent = new System.Windows.Forms.ComboBox();
            this.lbFloor2 = new System.Windows.Forms.Label();
            this.lmRoom2 = new System.Windows.Forms.Label();
            this.checkBoxHeadFloor = new System.Windows.Forms.CheckBox();
            this.lbCourse = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lbGroup = new System.Windows.Forms.Label();
            this.tbGruop = new System.Windows.Forms.TextBox();
            this.panelEmployeeInfo = new System.Windows.Forms.Panel();
            this.tbWorkPhone = new System.Windows.Forms.TextBox();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.lbWorkPhone = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.lbUserType = new System.Windows.Forms.Label();
            this.lbFloor = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelCommonInfo.SuspendLayout();
            this.panelStudentInfo.SuspendLayout();
            this.panelEmployeeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCommonInfo
            // 
            this.panelCommonInfo.Controls.Add(this.tbPassport);
            this.panelCommonInfo.Controls.Add(this.tbPhone);
            this.panelCommonInfo.Controls.Add(this.tbSurname);
            this.panelCommonInfo.Controls.Add(this.lbSurname);
            this.panelCommonInfo.Controls.Add(this.lbName);
            this.panelCommonInfo.Controls.Add(this.tbName);
            this.panelCommonInfo.Controls.Add(this.tbPatronymic);
            this.panelCommonInfo.Controls.Add(this.labPatronymic);
            this.panelCommonInfo.Controls.Add(this.lbPhone);
            this.panelCommonInfo.Controls.Add(this.lbAddress);
            this.panelCommonInfo.Controls.Add(this.tbAddress);
            this.panelCommonInfo.Controls.Add(this.lbPassport);
            this.panelCommonInfo.Location = new System.Drawing.Point(12, 25);
            this.panelCommonInfo.Name = "panelCommonInfo";
            this.panelCommonInfo.Size = new System.Drawing.Size(400, 346);
            this.panelCommonInfo.TabIndex = 0;
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(158, 277);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(197, 26);
            this.tbPassport.TabIndex = 38;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(158, 169);
            this.tbPhone.Mask = "+(375)00-000-00-00";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(197, 26);
            this.tbPhone.TabIndex = 40;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(158, 29);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(197, 26);
            this.tbSurname.TabIndex = 29;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(60, 32);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(81, 20);
            this.lbSurname.TabIndex = 30;
            this.lbSurname.Text = "Фамилия";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(64, 75);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(40, 20);
            this.lbName.TabIndex = 31;
            this.lbName.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(158, 72);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(197, 26);
            this.tbName.TabIndex = 32;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(158, 118);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(197, 26);
            this.tbPatronymic.TabIndex = 33;
            // 
            // labPatronymic
            // 
            this.labPatronymic.AutoSize = true;
            this.labPatronymic.Location = new System.Drawing.Point(64, 118);
            this.labPatronymic.Name = "labPatronymic";
            this.labPatronymic.Size = new System.Drawing.Size(83, 20);
            this.labPatronymic.TabIndex = 34;
            this.labPatronymic.Text = "Отчество";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(64, 169);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(88, 40);
            this.lbPhone.TabIndex = 35;
            this.lbPhone.Text = "Номер \r\nтелефона";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(64, 226);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(57, 20);
            this.lbAddress.TabIndex = 36;
            this.lbAddress.Text = "Адрес";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(158, 226);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(197, 26);
            this.tbAddress.TabIndex = 37;
            // 
            // lbPassport
            // 
            this.lbPassport.AutoSize = true;
            this.lbPassport.Location = new System.Drawing.Point(45, 277);
            this.lbPassport.Name = "lbPassport";
            this.lbPassport.Size = new System.Drawing.Size(107, 40);
            this.lbPassport.TabIndex = 39;
            this.lbPassport.Text = "Паспортные \r\nданные";
            // 
            // panelStudentInfo
            // 
            this.panelStudentInfo.Controls.Add(this.cmbRoomStudent);
            this.panelStudentInfo.Controls.Add(this.cmbFloorStudent);
            this.panelStudentInfo.Controls.Add(this.lbFloor2);
            this.panelStudentInfo.Controls.Add(this.lmRoom2);
            this.panelStudentInfo.Controls.Add(this.checkBoxHeadFloor);
            this.panelStudentInfo.Controls.Add(this.lbCourse);
            this.panelStudentInfo.Controls.Add(this.cmbCourse);
            this.panelStudentInfo.Controls.Add(this.lbGroup);
            this.panelStudentInfo.Controls.Add(this.tbGruop);
            this.panelStudentInfo.Location = new System.Drawing.Point(436, 25);
            this.panelStudentInfo.Name = "panelStudentInfo";
            this.panelStudentInfo.Size = new System.Drawing.Size(400, 346);
            this.panelStudentInfo.TabIndex = 1;
            // 
            // cmbRoomStudent
            // 
            this.cmbRoomStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomStudent.FormattingEnabled = true;
            this.cmbRoomStudent.Location = new System.Drawing.Point(164, 173);
            this.cmbRoomStudent.Name = "cmbRoomStudent";
            this.cmbRoomStudent.Size = new System.Drawing.Size(197, 28);
            this.cmbRoomStudent.TabIndex = 35;
            // 
            // cmbFloorStudent
            // 
            this.cmbFloorStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloorStudent.FormattingEnabled = true;
            this.cmbFloorStudent.Location = new System.Drawing.Point(164, 121);
            this.cmbFloorStudent.Name = "cmbFloorStudent";
            this.cmbFloorStudent.Size = new System.Drawing.Size(197, 28);
            this.cmbFloorStudent.TabIndex = 38;
            this.cmbFloorStudent.SelectedIndexChanged += new System.EventHandler(this.cmbFloorStudent_SelectedIndexChanged);
            // 
            // lbFloor2
            // 
            this.lbFloor2.AutoSize = true;
            this.lbFloor2.Location = new System.Drawing.Point(97, 124);
            this.lbFloor2.Name = "lbFloor2";
            this.lbFloor2.Size = new System.Drawing.Size(50, 20);
            this.lbFloor2.TabIndex = 37;
            this.lbFloor2.Text = "Этаж";
            // 
            // lmRoom2
            // 
            this.lmRoom2.AutoSize = true;
            this.lmRoom2.Location = new System.Drawing.Point(77, 176);
            this.lmRoom2.Name = "lmRoom2";
            this.lmRoom2.Size = new System.Drawing.Size(75, 20);
            this.lmRoom2.TabIndex = 36;
            this.lmRoom2.Text = "Комната";
            // 
            // checkBoxHeadFloor
            // 
            this.checkBoxHeadFloor.AutoSize = true;
            this.checkBoxHeadFloor.Location = new System.Drawing.Point(164, 231);
            this.checkBoxHeadFloor.Name = "checkBoxHeadFloor";
            this.checkBoxHeadFloor.Size = new System.Drawing.Size(156, 24);
            this.checkBoxHeadFloor.TabIndex = 34;
            this.checkBoxHeadFloor.Text = "староста этажа";
            this.checkBoxHeadFloor.UseVisualStyleBackColor = true;
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(104, 73);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(43, 20);
            this.lbCourse.TabIndex = 33;
            this.lbCourse.Text = "Курс";
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCourse.Location = new System.Drawing.Point(161, 70);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(197, 28);
            this.cmbCourse.TabIndex = 32;
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Location = new System.Drawing.Point(37, 32);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(115, 20);
            this.lbGroup.TabIndex = 31;
            this.lbGroup.Text = "Номер группы";
            // 
            // tbGruop
            // 
            this.tbGruop.Location = new System.Drawing.Point(161, 34);
            this.tbGruop.Name = "tbGruop";
            this.tbGruop.Size = new System.Drawing.Size(197, 26);
            this.tbGruop.TabIndex = 30;
            // 
            // panelEmployeeInfo
            // 
            this.panelEmployeeInfo.Controls.Add(this.tbWorkPhone);
            this.panelEmployeeInfo.Controls.Add(this.cmbUserType);
            this.panelEmployeeInfo.Controls.Add(this.lbWorkPhone);
            this.panelEmployeeInfo.Controls.Add(this.cmbRoom);
            this.panelEmployeeInfo.Controls.Add(this.cmbFloor);
            this.panelEmployeeInfo.Controls.Add(this.lbUserType);
            this.panelEmployeeInfo.Controls.Add(this.lbFloor);
            this.panelEmployeeInfo.Controls.Add(this.lbRoom);
            this.panelEmployeeInfo.Location = new System.Drawing.Point(436, 25);
            this.panelEmployeeInfo.Name = "panelEmployeeInfo";
            this.panelEmployeeInfo.Size = new System.Drawing.Size(400, 346);
            this.panelEmployeeInfo.TabIndex = 31;
            // 
            // tbWorkPhone
            // 
            this.tbWorkPhone.Location = new System.Drawing.Point(171, 193);
            this.tbWorkPhone.Name = "tbWorkPhone";
            this.tbWorkPhone.Size = new System.Drawing.Size(197, 26);
            this.tbWorkPhone.TabIndex = 19;
            // 
            // cmbUserType
            // 
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Location = new System.Drawing.Point(171, 133);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(197, 28);
            this.cmbUserType.TabIndex = 18;
            // 
            // lbWorkPhone
            // 
            this.lbWorkPhone.AutoSize = true;
            this.lbWorkPhone.Location = new System.Drawing.Point(26, 193);
            this.lbWorkPhone.Name = "lbWorkPhone";
            this.lbWorkPhone.Size = new System.Drawing.Size(137, 40);
            this.lbWorkPhone.TabIndex = 20;
            this.lbWorkPhone.Text = "Номер рабочего \r\nтелефона";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(168, 76);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(197, 28);
            this.cmbRoom.TabIndex = 21;
            // 
            // cmbFloor
            // 
            this.cmbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(168, 24);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(197, 28);
            this.cmbFloor.TabIndex = 25;
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.Location = new System.Drawing.Point(48, 141);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(95, 20);
            this.lbUserType.TabIndex = 22;
            this.lbUserType.Text = "Должность";
            // 
            // lbFloor
            // 
            this.lbFloor.AutoSize = true;
            this.lbFloor.Location = new System.Drawing.Point(87, 27);
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(50, 20);
            this.lbFloor.TabIndex = 24;
            this.lbFloor.Text = "Этаж";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Location = new System.Drawing.Point(81, 83);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(75, 20);
            this.lbRoom.TabIndex = 23;
            this.lbRoom.Text = "Комната";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(258, 394);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(154, 37);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(436, 394);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(154, 37);
            this.buttonExit.TabIndex = 33;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // UserEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 443);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.panelStudentInfo);
            this.Controls.Add(this.panelEmployeeInfo);
            this.Controls.Add(this.panelCommonInfo);
            this.Name = "UserEditingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEditingForm";
            this.panelCommonInfo.ResumeLayout(false);
            this.panelCommonInfo.PerformLayout();
            this.panelStudentInfo.ResumeLayout(false);
            this.panelStudentInfo.PerformLayout();
            this.panelEmployeeInfo.ResumeLayout(false);
            this.panelEmployeeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCommonInfo;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label labPatronymic;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbPassport;
        private System.Windows.Forms.Panel panelStudentInfo;
        private System.Windows.Forms.ComboBox cmbRoomStudent;
        private System.Windows.Forms.ComboBox cmbFloorStudent;
        private System.Windows.Forms.Label lbFloor2;
        private System.Windows.Forms.Label lmRoom2;
        private System.Windows.Forms.CheckBox checkBoxHeadFloor;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.TextBox tbGruop;
        private System.Windows.Forms.Panel panelEmployeeInfo;
        private System.Windows.Forms.TextBox tbWorkPhone;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label lbWorkPhone;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.Label lbFloor;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonExit;
    }
}