namespace HostelApplication.UserInterfaceLayer
{
    partial class ArrearsForm
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
            this.cmbNormCount = new System.Windows.Forms.ComboBox();
            this.lbNormHours = new System.Windows.Forms.Label();
            this.cmbStartMonth = new System.Windows.Forms.ComboBox();
            this.cmbEndMonth = new System.Windows.Forms.ComboBox();
            this.tbHoursCount = new System.Windows.Forms.TextBox();
            this.buttonShowDebtors = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbExpectedHours = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.cmbFileFormat = new System.Windows.Forms.ComboBox();
            this.lbExpectedSum = new System.Windows.Forms.Label();
            this.lbNormSum = new System.Windows.Forms.Label();
            this.tbExpectedSum = new System.Windows.Forms.TextBox();
            this.tbNormSum = new System.Windows.Forms.TextBox();
            this.dataGridViewDebtors = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebtors)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNormCount
            // 
            this.cmbNormCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNormCount.FormattingEnabled = true;
            this.cmbNormCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbNormCount.Location = new System.Drawing.Point(188, 10);
            this.cmbNormCount.Name = "cmbNormCount";
            this.cmbNormCount.Size = new System.Drawing.Size(134, 28);
            this.cmbNormCount.TabIndex = 0;
            // 
            // lbNormHours
            // 
            this.lbNormHours.AutoSize = true;
            this.lbNormHours.Location = new System.Drawing.Point(17, 10);
            this.lbNormHours.Name = "lbNormHours";
            this.lbNormHours.Size = new System.Drawing.Size(111, 40);
            this.lbNormHours.TabIndex = 1;
            this.lbNormHours.Text = "Норма часов \r\nза месяц";
            // 
            // cmbStartMonth
            // 
            this.cmbStartMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartMonth.FormattingEnabled = true;
            this.cmbStartMonth.Items.AddRange(new object[] {
            "январь",
            "февраль",
            "март",
            "апрель",
            "май",
            "июнь",
            "июль",
            "август",
            "сентябрь",
            "октябрь",
            "ноябрь",
            "декабрь"});
            this.cmbStartMonth.Location = new System.Drawing.Point(188, 79);
            this.cmbStartMonth.Name = "cmbStartMonth";
            this.cmbStartMonth.Size = new System.Drawing.Size(134, 28);
            this.cmbStartMonth.TabIndex = 2;
            // 
            // cmbEndMonth
            // 
            this.cmbEndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndMonth.FormattingEnabled = true;
            this.cmbEndMonth.Items.AddRange(new object[] {
            "январь",
            "февраль",
            "март",
            "апрель",
            "май",
            "июнь",
            "июль",
            "август",
            "сентябрь",
            "октябрь",
            "ноябрь",
            "декабрь"});
            this.cmbEndMonth.Location = new System.Drawing.Point(188, 149);
            this.cmbEndMonth.Name = "cmbEndMonth";
            this.cmbEndMonth.Size = new System.Drawing.Size(134, 28);
            this.cmbEndMonth.TabIndex = 3;
            this.cmbEndMonth.SelectedIndexChanged += new System.EventHandler(this.cmbEndMonth_SelectedIndexChanged);
            // 
            // tbHoursCount
            // 
            this.tbHoursCount.Location = new System.Drawing.Point(188, 224);
            this.tbHoursCount.Name = "tbHoursCount";
            this.tbHoursCount.Size = new System.Drawing.Size(134, 26);
            this.tbHoursCount.TabIndex = 4;
            this.tbHoursCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHoursCount_KeyPress);
            // 
            // buttonShowDebtors
            // 
            this.buttonShowDebtors.Location = new System.Drawing.Point(21, 283);
            this.buttonShowDebtors.Name = "buttonShowDebtors";
            this.buttonShowDebtors.Size = new System.Drawing.Size(301, 63);
            this.buttonShowDebtors.TabIndex = 5;
            this.buttonShowDebtors.Text = "Показать должников";
            this.buttonShowDebtors.UseVisualStyleBackColor = true;
            this.buttonShowDebtors.Click += new System.EventHandler(this.buttonShowDebtors_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Начальный\r\nмесяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Конечный \r\nмесяц";
            // 
            // lbExpectedHours
            // 
            this.lbExpectedHours.AutoSize = true;
            this.lbExpectedHours.Location = new System.Drawing.Point(17, 210);
            this.lbExpectedHours.Name = "lbExpectedHours";
            this.lbExpectedHours.Size = new System.Drawing.Size(165, 40);
            this.lbExpectedHours.TabIndex = 8;
            this.lbExpectedHours.Text = "Требуемое число \r\nотработанных часов";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOpenFile);
            this.panel1.Controls.Add(this.cmbFileFormat);
            this.panel1.Controls.Add(this.lbExpectedSum);
            this.panel1.Controls.Add(this.lbNormSum);
            this.panel1.Controls.Add(this.tbExpectedSum);
            this.panel1.Controls.Add(this.tbNormSum);
            this.panel1.Controls.Add(this.buttonShowDebtors);
            this.panel1.Controls.Add(this.lbExpectedHours);
            this.panel1.Controls.Add(this.cmbNormCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbNormHours);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbStartMonth);
            this.panel1.Controls.Add(this.cmbEndMonth);
            this.panel1.Controls.Add(this.tbHoursCount);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 443);
            this.panel1.TabIndex = 9;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(188, 379);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(134, 45);
            this.buttonOpenFile.TabIndex = 14;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // cmbFileFormat
            // 
            this.cmbFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileFormat.FormattingEnabled = true;
            this.cmbFileFormat.Items.AddRange(new object[] {
            "MS Word",
            "MS Excel"});
            this.cmbFileFormat.Location = new System.Drawing.Point(21, 388);
            this.cmbFileFormat.Name = "cmbFileFormat";
            this.cmbFileFormat.Size = new System.Drawing.Size(161, 28);
            this.cmbFileFormat.TabIndex = 13;
            // 
            // lbExpectedSum
            // 
            this.lbExpectedSum.AutoSize = true;
            this.lbExpectedSum.Location = new System.Drawing.Point(19, 210);
            this.lbExpectedSum.Name = "lbExpectedSum";
            this.lbExpectedSum.Size = new System.Drawing.Size(163, 40);
            this.lbExpectedSum.TabIndex = 12;
            this.lbExpectedSum.Text = "Сумма необходимая\r\nдля оплаты";
            // 
            // lbNormSum
            // 
            this.lbNormSum.AutoSize = true;
            this.lbNormSum.Location = new System.Drawing.Point(17, 14);
            this.lbNormSum.Name = "lbNormSum";
            this.lbNormSum.Size = new System.Drawing.Size(125, 40);
            this.lbNormSum.TabIndex = 11;
            this.lbNormSum.Text = "Сумма за один \r\nмесяц (руб.)";
            // 
            // tbExpectedSum
            // 
            this.tbExpectedSum.Location = new System.Drawing.Point(188, 224);
            this.tbExpectedSum.Name = "tbExpectedSum";
            this.tbExpectedSum.Size = new System.Drawing.Size(134, 26);
            this.tbExpectedSum.TabIndex = 10;
            // 
            // tbNormSum
            // 
            this.tbNormSum.Location = new System.Drawing.Point(188, 11);
            this.tbNormSum.Name = "tbNormSum";
            this.tbNormSum.Size = new System.Drawing.Size(134, 26);
            this.tbNormSum.TabIndex = 9;
            // 
            // dataGridViewDebtors
            // 
            this.dataGridViewDebtors.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDebtors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebtors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.Name,
            this.Patronymic,
            this.ActualCount,
            this.Expected});
            this.dataGridViewDebtors.Location = new System.Drawing.Point(396, 13);
            this.dataGridViewDebtors.Name = "dataGridViewDebtors";
            this.dataGridViewDebtors.RowTemplate.Height = 28;
            this.dataGridViewDebtors.Size = new System.Drawing.Size(947, 442);
            this.dataGridViewDebtors.TabIndex = 10;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.Width = 200;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            this.Name.Width = 200;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Width = 200;
            // 
            // ActualCount
            // 
            this.ActualCount.HeaderText = "Отработанное количество";
            this.ActualCount.Name = "ActualCount";
            this.ActualCount.Width = 150;
            // 
            // Expected
            // 
            this.Expected.HeaderText = "Необходимое число";
            this.Expected.Name = "Expected";
            this.Expected.Width = 150;
            // 
            // ArrearsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 491);
            this.Controls.Add(this.dataGridViewDebtors);
            this.Controls.Add(this.panel1);
           // this.Name = "ArrearsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrears";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebtors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNormCount;
        private System.Windows.Forms.Label lbNormHours;
        private System.Windows.Forms.ComboBox cmbStartMonth;
        private System.Windows.Forms.ComboBox cmbEndMonth;
        private System.Windows.Forms.TextBox tbHoursCount;
        private System.Windows.Forms.Button buttonShowDebtors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbExpectedHours;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDebtors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expected;
        private System.Windows.Forms.TextBox tbNormSum;
        private System.Windows.Forms.Label lbExpectedSum;
        private System.Windows.Forms.Label lbNormSum;
        private System.Windows.Forms.TextBox tbExpectedSum;
        private System.Windows.Forms.ComboBox cmbFileFormat;
        private System.Windows.Forms.Button buttonOpenFile;
    }
}