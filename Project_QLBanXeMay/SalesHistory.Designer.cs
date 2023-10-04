namespace Project_QLBanXeMay
{
    partial class SalesHistory
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
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMotorcycles = new System.Windows.Forms.DataGridView();
            this.SoHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOther = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SearchByDate = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorcycles)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SearchByDate.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.Location = new System.Drawing.Point(3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(43, 36);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.dgvMotorcycles);
            this.panel1.Location = new System.Drawing.Point(45, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 585);
            this.panel1.TabIndex = 2;
            // 
            // dgvMotorcycles
            // 
            this.dgvMotorcycles.AllowUserToAddRows = false;
            this.dgvMotorcycles.AllowUserToDeleteRows = false;
            this.dgvMotorcycles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMotorcycles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMotorcycles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMotorcycles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMotorcycles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotorcycles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHoaDon,
            this.nameCustomer,
            this.nameMotor,
            this.SoKhung,
            this.Cost,
            this.DateBuy});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMotorcycles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMotorcycles.Location = new System.Drawing.Point(6, 9);
            this.dgvMotorcycles.Margin = new System.Windows.Forms.Padding(9);
            this.dgvMotorcycles.Name = "dgvMotorcycles";
            this.dgvMotorcycles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMotorcycles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMotorcycles.RowHeadersVisible = false;
            this.dgvMotorcycles.RowTemplate.Height = 50;
            this.dgvMotorcycles.RowTemplate.ReadOnly = true;
            this.dgvMotorcycles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMotorcycles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMotorcycles.Size = new System.Drawing.Size(991, 507);
            this.dgvMotorcycles.StandardTab = true;
            this.dgvMotorcycles.TabIndex = 0;
            // 
            // SoHoaDon
            // 
            this.SoHoaDon.HeaderText = "So hoa don";
            this.SoHoaDon.Name = "SoHoaDon";
            this.SoHoaDon.ReadOnly = true;
            this.SoHoaDon.Width = 140;
            // 
            // nameCustomer
            // 
            this.nameCustomer.HeaderText = "ten khach hang";
            this.nameCustomer.Name = "nameCustomer";
            this.nameCustomer.ReadOnly = true;
            this.nameCustomer.Width = 200;
            // 
            // nameMotor
            // 
            this.nameMotor.HeaderText = "ten Xe";
            this.nameMotor.Name = "nameMotor";
            this.nameMotor.ReadOnly = true;
            this.nameMotor.Width = 150;
            // 
            // SoKhung
            // 
            this.SoKhung.HeaderText = "SoKhung";
            this.SoKhung.Name = "SoKhung";
            this.SoKhung.ReadOnly = true;
            this.SoKhung.Width = 150;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Thanh Tien";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 150;
            // 
            // DateBuy
            // 
            this.DateBuy.HeaderText = "Ngay Mua";
            this.DateBuy.Name = "DateBuy";
            this.DateBuy.ReadOnly = true;
            this.DateBuy.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 42);
            this.label5.TabIndex = 9;
            this.label5.Text = "Manager Sales History";
            // 
            // btnWeek
            // 
            this.btnWeek.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnWeek.Location = new System.Drawing.Point(45, 77);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(182, 44);
            this.btnWeek.TabIndex = 12;
            this.btnWeek.Text = "Week";
            this.btnWeek.UseVisualStyleBackColor = true;
            // 
            // btnMonth
            // 
            this.btnMonth.FlatAppearance.BorderSize = 0;
            this.btnMonth.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMonth.Location = new System.Drawing.Point(45, 144);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(179, 44);
            this.btnMonth.TabIndex = 13;
            this.btnMonth.Text = "Month";
            this.btnMonth.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnToday.Location = new System.Drawing.Point(3, 3);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(106, 44);
            this.btnToday.TabIndex = 14;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnYesterday
            // 
            this.btnYesterday.FlatAppearance.BorderSize = 0;
            this.btnYesterday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYesterday.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnYesterday.Location = new System.Drawing.Point(115, 2);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(107, 44);
            this.btnYesterday.TabIndex = 16;
            this.btnYesterday.Text = "Yesterday";
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(63, 280);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 24);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 241);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 24);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "From";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnOther);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnToday);
            this.panel2.Controls.Add(this.btnYesterday);
            this.panel2.Location = new System.Drawing.Point(447, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 49);
            this.panel2.TabIndex = 25;
            // 
            // btnOther
            // 
            this.btnOther.FlatAppearance.BorderSize = 0;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOther.Location = new System.Drawing.Point(228, 5);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(101, 41);
            this.btnOther.TabIndex = 28;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(224, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 40);
            this.panel6.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(111, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 40);
            this.panel4.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(0, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 40);
            this.panel5.TabIndex = 27;
            // 
            // SearchByDate
            // 
            this.SearchByDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchByDate.Controls.Add(this.panel3);
            this.SearchByDate.Controls.Add(this.label18);
            this.SearchByDate.Controls.Add(this.button3);
            this.SearchByDate.Controls.Add(this.dateTimePicker1);
            this.SearchByDate.Controls.Add(this.label1);
            this.SearchByDate.Controls.Add(this.dateTimePicker2);
            this.SearchByDate.Controls.Add(this.btnMonth);
            this.SearchByDate.Controls.Add(this.label2);
            this.SearchByDate.Controls.Add(this.btnWeek);
            this.SearchByDate.Location = new System.Drawing.Point(1065, 242);
            this.SearchByDate.Name = "SearchByDate";
            this.SearchByDate.Size = new System.Drawing.Size(258, 397);
            this.SearchByDate.TabIndex = 26;
            this.SearchByDate.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(34, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(163)))));
            this.label18.Location = new System.Drawing.Point(52, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 33);
            this.label18.TabIndex = 31;
            this.label18.Text = "Search Other";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(58, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 30);
            this.button3.TabIndex = 29;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnSearch.Controls.Add(this.searchLabel);
            this.pnSearch.Controls.Add(button1);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Location = new System.Drawing.Point(45, 173);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(328, 43);
            this.pnSearch.TabIndex = 30;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.searchLabel.Location = new System.Drawing.Point(42, 12);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(96, 18);
            this.searchLabel.TabIndex = 19;
            this.searchLabel.Text = "Search  by ID";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(45, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 19);
            this.txtSearch.TabIndex = 10;
            // 
            // SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1500, 875);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.SearchByDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesHistory";
            this.Text = "SalesHistory";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorcycles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.SearchByDate.ResumeLayout(false);
            this.SearchByDate.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMotorcycles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBuy;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Panel SearchByDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
    }
}