namespace HostelApplication.UserInterfaceLayer
{
    partial class WorkedHoursForm
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
            this.dateInspection = new System.Windows.Forms.DateTimePicker();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.tbHoursCount = new System.Windows.Forms.TextBox();
            this.labelCountHours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAddInspection = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.textBoxPaymentSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateInspection
            // 
            this.dateInspection.Location = new System.Drawing.Point(200, 29);
            this.dateInspection.Name = "dateInspection";
            this.dateInspection.Size = new System.Drawing.Size(242, 26);
            this.dateInspection.TabIndex = 0;
            // 
            // cmbFloor
            // 
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(199, 131);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(242, 28);
            this.cmbFloor.TabIndex = 1;
            this.cmbFloor.SelectedIndexChanged += new System.EventHandler(this.cmbFloor_SelectedIndexChanged);
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(199, 187);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(242, 28);
            this.cmbRoom.TabIndex = 2;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(199, 244);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(242, 28);
            this.cmbStudent.TabIndex = 3;
            // 
            // tbHoursCount
            // 
            this.tbHoursCount.Location = new System.Drawing.Point(199, 77);
            this.tbHoursCount.MaxLength = 3;
            this.tbHoursCount.Name = "tbHoursCount";
            this.tbHoursCount.Size = new System.Drawing.Size(242, 26);
            this.tbHoursCount.TabIndex = 5;
            this.tbHoursCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHoursCount_KeyPress);
            // 
            // labelCountHours
            // 
            this.labelCountHours.AutoSize = true;
            this.labelCountHours.Location = new System.Drawing.Point(87, 80);
            this.labelCountHours.Name = "labelCountHours";
            this.labelCountHours.Size = new System.Drawing.Size(104, 40);
            this.labelCountHours.TabIndex = 6;
            this.labelCountHours.Text = "Количество \r\nчасов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "этаж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "комната";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "студент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "сотрудник";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(198, 361);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(243, 96);
            this.richTextBoxDescription.TabIndex = 12;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(87, 382);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 40);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Описание\r\nработы";
            // 
            // buttonAddInspection
            // 
            this.buttonAddInspection.Location = new System.Drawing.Point(91, 477);
            this.buttonAddInspection.Name = "buttonAddInspection";
            this.buttonAddInspection.Size = new System.Drawing.Size(141, 49);
            this.buttonAddInspection.TabIndex = 14;
            this.buttonAddInspection.Text = "Добавить";
            this.buttonAddInspection.UseVisualStyleBackColor = true;
            this.buttonAddInspection.Click += new System.EventHandler(this.buttonAddInspection_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 40);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата \r\nотработки";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(256, 477);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(141, 49);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // tbEmployee
            // 
            this.tbEmployee.Location = new System.Drawing.Point(200, 308);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Size = new System.Drawing.Size(242, 26);
            this.tbEmployee.TabIndex = 17;
            this.tbEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmployee_KeyPress);
            // 
            // textBoxPaymentSum
            // 
            this.textBoxPaymentSum.Location = new System.Drawing.Point(197, 77);
            this.textBoxPaymentSum.Name = "textBoxPaymentSum";
            this.textBoxPaymentSum.Size = new System.Drawing.Size(244, 26);
            this.textBoxPaymentSum.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "Сумма \r\nплатежа";
            // 
            // WorkedHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 538);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPaymentSum);
            this.Controls.Add(this.tbEmployee);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonAddInspection);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCountHours);
            this.Controls.Add(this.tbHoursCount);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmbFloor);
            this.Controls.Add(this.dateInspection);
            this.Name = "WorkedHoursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkedHoursForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateInspection;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.TextBox tbHoursCount;
        private System.Windows.Forms.Label labelCountHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonAddInspection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox tbEmployee;
        private System.Windows.Forms.TextBox textBoxPaymentSum;
        private System.Windows.Forms.Label label1;
    }
}