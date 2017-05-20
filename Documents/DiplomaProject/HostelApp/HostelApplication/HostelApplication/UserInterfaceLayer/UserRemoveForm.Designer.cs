namespace HostelApplication
{
    partial class UserRemoveForm
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
            this.gridEmployee = new System.Windows.Forms.DataGridView();
            this.SurnameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStudent = new System.Windows.Forms.DataGridView();
            this.SurnameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmployee
            // 
            this.gridEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameEmployee,
            this.NameEmployee,
            this.PatronymicEmployee,
            this.TypeEmployee,
            this.RoomEmployee,
            this.PhoneEmployee,
            this.LoginEmployee});
            this.gridEmployee.Location = new System.Drawing.Point(-1, 0);
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.ReadOnly = true;
            this.gridEmployee.RowTemplate.Height = 28;
            this.gridEmployee.Size = new System.Drawing.Size(1198, 474);
            this.gridEmployee.TabIndex = 0;
            this.gridEmployee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridEmployee_MouseDoubleClick);
            // 
            // SurnameEmployee
            // 
            this.SurnameEmployee.HeaderText = "Фамилия";
            this.SurnameEmployee.Name = "SurnameEmployee";
            this.SurnameEmployee.ReadOnly = true;
            this.SurnameEmployee.Width = 200;
            // 
            // NameEmployee
            // 
            this.NameEmployee.HeaderText = "Имя";
            this.NameEmployee.Name = "NameEmployee";
            this.NameEmployee.ReadOnly = true;
            this.NameEmployee.Width = 200;
            // 
            // PatronymicEmployee
            // 
            this.PatronymicEmployee.HeaderText = "Отчество";
            this.PatronymicEmployee.Name = "PatronymicEmployee";
            this.PatronymicEmployee.ReadOnly = true;
            this.PatronymicEmployee.Width = 250;
            // 
            // TypeEmployee
            // 
            this.TypeEmployee.HeaderText = "Должность";
            this.TypeEmployee.Name = "TypeEmployee";
            this.TypeEmployee.ReadOnly = true;
            this.TypeEmployee.Width = 150;
            // 
            // RoomEmployee
            // 
            this.RoomEmployee.HeaderText = "Рабочее место";
            this.RoomEmployee.Name = "RoomEmployee";
            this.RoomEmployee.ReadOnly = true;
            this.RoomEmployee.Width = 150;
            // 
            // PhoneEmployee
            // 
            this.PhoneEmployee.HeaderText = "Номер телефона";
            this.PhoneEmployee.Name = "PhoneEmployee";
            this.PhoneEmployee.ReadOnly = true;
            this.PhoneEmployee.Width = 200;
            // 
            // LoginEmployee
            // 
            this.LoginEmployee.HeaderText = "Login";
            this.LoginEmployee.Name = "LoginEmployee";
            this.LoginEmployee.ReadOnly = true;
            // 
            // gridStudent
            // 
            this.gridStudent.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameStudent,
            this.NameStudent,
            this.PatronymicStudent,
            this.FloorStudent,
            this.RoomStudent,
            this.PhoneStudent,
            this.LoginStudent});
            this.gridStudent.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridStudent.Location = new System.Drawing.Point(-1, 0);
            this.gridStudent.Name = "gridStudent";
            this.gridStudent.ReadOnly = true;
            this.gridStudent.RowTemplate.Height = 28;
            this.gridStudent.Size = new System.Drawing.Size(1198, 474);
            this.gridStudent.TabIndex = 1;
            this.gridStudent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridStudent_MouseDoubleClick);
            // 
            // SurnameStudent
            // 
            this.SurnameStudent.HeaderText = "Фамилия";
            this.SurnameStudent.Name = "SurnameStudent";
            this.SurnameStudent.ReadOnly = true;
            this.SurnameStudent.Width = 200;
            // 
            // NameStudent
            // 
            this.NameStudent.HeaderText = "Имя";
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.ReadOnly = true;
            this.NameStudent.Width = 210;
            // 
            // PatronymicStudent
            // 
            this.PatronymicStudent.HeaderText = "Отчество";
            this.PatronymicStudent.Name = "PatronymicStudent";
            this.PatronymicStudent.ReadOnly = true;
            this.PatronymicStudent.Width = 230;
            // 
            // FloorStudent
            // 
            this.FloorStudent.HeaderText = "Этаж";
            this.FloorStudent.Name = "FloorStudent";
            this.FloorStudent.ReadOnly = true;
            this.FloorStudent.Width = 150;
            // 
            // RoomStudent
            // 
            this.RoomStudent.HeaderText = "Комната";
            this.RoomStudent.Name = "RoomStudent";
            this.RoomStudent.ReadOnly = true;
            this.RoomStudent.Width = 150;
            // 
            // PhoneStudent
            // 
            this.PhoneStudent.HeaderText = "Телефон";
            this.PhoneStudent.Name = "PhoneStudent";
            this.PhoneStudent.ReadOnly = true;
            this.PhoneStudent.Width = 210;
            // 
            // LoginStudent
            // 
            this.LoginStudent.HeaderText = "Login";
            this.LoginStudent.Name = "LoginStudent";
            this.LoginStudent.ReadOnly = true;
            // 
            // UserRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 474);
            this.Controls.Add(this.gridStudent);
            this.Controls.Add(this.gridEmployee);
            this.Name = "UserRemoveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRemoveForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmployee;
        private System.Windows.Forms.DataGridView gridStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginStudent;
    }
}