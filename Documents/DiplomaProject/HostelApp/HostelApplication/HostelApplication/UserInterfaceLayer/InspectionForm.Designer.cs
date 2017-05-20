namespace HostelApplication.UserInterfaceLayer
{
    partial class InspectionForm
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
            this.cmbRestRoom = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRoomB = new System.Windows.Forms.ComboBox();
            this.cmbRoomA = new System.Windows.Forms.ComboBox();
            this.cmbKitchen = new System.Windows.Forms.ComboBox();
            this.cmbHall = new System.Windows.Forms.ComboBox();
            this.cmbBathroom = new System.Windows.Forms.ComboBox();
            this.tbFirstEmployee = new System.Windows.Forms.TextBox();
            this.cmbSecondEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddInspection = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateInspection
            // 
            this.dateInspection.Location = new System.Drawing.Point(211, 14);
            this.dateInspection.Name = "dateInspection";
            this.dateInspection.Size = new System.Drawing.Size(200, 26);
            this.dateInspection.TabIndex = 0;
            // 
            // cmbFloor
            // 
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(211, 86);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(200, 28);
            this.cmbFloor.TabIndex = 1;
            this.cmbFloor.SelectedIndexChanged += new System.EventHandler(this.cmbFloor_SelectedIndexChanged);
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(211, 159);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(200, 28);
            this.cmbRoom.TabIndex = 2;
            // 
            // cmbRestRoom
            // 
            this.cmbRestRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRestRoom.FormattingEnabled = true;
            this.cmbRestRoom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbRestRoom.Location = new System.Drawing.Point(187, 62);
            this.cmbRestRoom.Name = "cmbRestRoom";
            this.cmbRestRoom.Size = new System.Drawing.Size(121, 28);
            this.cmbRestRoom.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbRoomB);
            this.panel1.Controls.Add(this.cmbRoomA);
            this.panel1.Controls.Add(this.cmbKitchen);
            this.panel1.Controls.Add(this.cmbHall);
            this.panel1.Controls.Add(this.cmbBathroom);
            this.panel1.Controls.Add(this.cmbRestRoom);
            this.panel1.Location = new System.Drawing.Point(482, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 348);
            this.panel1.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Комната \'б\'";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Комната \'а\'";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Кухня";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Коридор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ванная комната";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Оценки за санитарное состояние";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Уборная комната";
            // 
            // cmbRoomB
            // 
            this.cmbRoomB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomB.FormattingEnabled = true;
            this.cmbRoomB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbRoomB.Location = new System.Drawing.Point(187, 302);
            this.cmbRoomB.Name = "cmbRoomB";
            this.cmbRoomB.Size = new System.Drawing.Size(121, 28);
            this.cmbRoomB.TabIndex = 8;
            // 
            // cmbRoomA
            // 
            this.cmbRoomA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomA.FormattingEnabled = true;
            this.cmbRoomA.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbRoomA.Location = new System.Drawing.Point(187, 254);
            this.cmbRoomA.Name = "cmbRoomA";
            this.cmbRoomA.Size = new System.Drawing.Size(121, 28);
            this.cmbRoomA.TabIndex = 7;
            // 
            // cmbKitchen
            // 
            this.cmbKitchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitchen.FormattingEnabled = true;
            this.cmbKitchen.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbKitchen.Location = new System.Drawing.Point(187, 207);
            this.cmbKitchen.Name = "cmbKitchen";
            this.cmbKitchen.Size = new System.Drawing.Size(121, 28);
            this.cmbKitchen.TabIndex = 6;
            // 
            // cmbHall
            // 
            this.cmbHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHall.FormattingEnabled = true;
            this.cmbHall.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbHall.Location = new System.Drawing.Point(187, 156);
            this.cmbHall.Name = "cmbHall";
            this.cmbHall.Size = new System.Drawing.Size(121, 28);
            this.cmbHall.TabIndex = 5;
            // 
            // cmbBathroom
            // 
            this.cmbBathroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBathroom.FormattingEnabled = true;
            this.cmbBathroom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbBathroom.Location = new System.Drawing.Point(187, 110);
            this.cmbBathroom.Name = "cmbBathroom";
            this.cmbBathroom.Size = new System.Drawing.Size(121, 28);
            this.cmbBathroom.TabIndex = 4;
            // 
            // tbFirstEmployee
            // 
            this.tbFirstEmployee.Location = new System.Drawing.Point(211, 228);
            this.tbFirstEmployee.Name = "tbFirstEmployee";
            this.tbFirstEmployee.Size = new System.Drawing.Size(200, 26);
            this.tbFirstEmployee.TabIndex = 5;
            this.tbFirstEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstEmployee_KeyPress);
            // 
            // cmbSecondEmployee
            // 
            this.cmbSecondEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondEmployee.FormattingEnabled = true;
            this.cmbSecondEmployee.Location = new System.Drawing.Point(211, 294);
            this.cmbSecondEmployee.Name = "cmbSecondEmployee";
            this.cmbSecondEmployee.Size = new System.Drawing.Size(200, 28);
            this.cmbSecondEmployee.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата проверки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер этажа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер комнаты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Первый проверяющий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Второй проверяющий";
            // 
            // buttonAddInspection
            // 
            this.buttonAddInspection.Location = new System.Drawing.Point(235, 389);
            this.buttonAddInspection.Name = "buttonAddInspection";
            this.buttonAddInspection.Size = new System.Drawing.Size(175, 60);
            this.buttonAddInspection.TabIndex = 12;
            this.buttonAddInspection.Text = "Добавить запись о\r\nпроврке блока";
            this.buttonAddInspection.UseVisualStyleBackColor = true;
            this.buttonAddInspection.Click += new System.EventHandler(this.buttonAddInspection_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(439, 389);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(175, 60);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbSecondEmployee);
            this.panel2.Controls.Add(this.dateInspection);
            this.panel2.Controls.Add(this.cmbFloor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbRoom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbFirstEmployee);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 348);
            this.panel2.TabIndex = 14;
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAddInspection);
            this.Controls.Add(this.panel1);
            this.Name = "InspectionForm";
            this.Text = "Проверка блока";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateInspection;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbRestRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRoomB;
        private System.Windows.Forms.ComboBox cmbRoomA;
        private System.Windows.Forms.ComboBox cmbKitchen;
        private System.Windows.Forms.ComboBox cmbHall;
        private System.Windows.Forms.ComboBox cmbBathroom;
        private System.Windows.Forms.TextBox tbFirstEmployee;
        private System.Windows.Forms.ComboBox cmbSecondEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddInspection;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel2;
    }
}