namespace HostelApplication.UserInterfaceLayer
{
    partial class AddThingForm
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
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbThing = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbThingCount = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddThing = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ThingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(150, 31);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 26);
            this.dateTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата выдачи";
            // 
            // cmbFloor
            // 
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(150, 88);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(200, 28);
            this.cmbFloor.TabIndex = 2;
            this.cmbFloor.SelectedIndexChanged += new System.EventHandler(this.cmbFloor_SelectedIndexChanged);
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(150, 147);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(200, 28);
            this.cmbRoom.TabIndex = 3;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(150, 211);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(200, 28);
            this.cmbStudent.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.buttonAddThing);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbThingCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbThing);
            this.panel1.Location = new System.Drawing.Point(497, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 372);
            this.panel1.TabIndex = 5;
            // 
            // cmbThing
            // 
            this.cmbThing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThing.FormattingEnabled = true;
            this.cmbThing.Location = new System.Drawing.Point(186, 17);
            this.cmbThing.Name = "cmbThing";
            this.cmbThing.Size = new System.Drawing.Size(179, 28);
            this.cmbThing.TabIndex = 0;
            this.cmbThing.SelectedIndexChanged += new System.EventHandler(this.cmbThing_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование вещи";
            // 
            // cmbThingCount
            // 
            this.cmbThingCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThingCount.FormattingEnabled = true;
            this.cmbThingCount.Location = new System.Drawing.Point(186, 79);
            this.cmbThingCount.Name = "cmbThingCount";
            this.cmbThingCount.Size = new System.Drawing.Size(179, 28);
            this.cmbThingCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество вещей";
            // 
            // buttonAddThing
            // 
            this.buttonAddThing.Location = new System.Drawing.Point(123, 147);
            this.buttonAddThing.Name = "buttonAddThing";
            this.buttonAddThing.Size = new System.Drawing.Size(144, 39);
            this.buttonAddThing.TabIndex = 4;
            this.buttonAddThing.Text = "Добавить";
            this.buttonAddThing.UseVisualStyleBackColor = true;
            this.buttonAddThing.Click += new System.EventHandler(this.buttonAddThing_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThingName,
            this.Count});
            this.dataGridView.Location = new System.Drawing.Point(417, 17);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(354, 340);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView_UserDeletingRow);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(256, 404);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(323, 63);
            this.buttonAddRecord.TabIndex = 6;
            this.buttonAddRecord.Text = "Добавить запись";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbStudent);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateTime);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbFloor);
            this.panel2.Controls.Add(this.cmbRoom);
            this.panel2.Location = new System.Drawing.Point(46, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 372);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Этаж";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Комната";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Студент";
            // 
            // ThingName
            // 
            this.ThingName.HeaderText = "Название вещи";
            this.ThingName.Name = "ThingName";
            this.ThingName.ReadOnly = true;
            this.ThingName.Width = 200;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 110;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(620, 404);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(323, 63);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AddThingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1283, 471);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.panel1);
            this.Name = "AddThingForm";
            this.Text = "Добавление записи о взятых вещах";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbThingCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbThing;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAddThing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Button buttonExit;
    }
}