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
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new Project_QLBanXeMay.borderRadius.RoundedButton();
            this.SearchByDate = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnWeek = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchDay = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.borderPanel3 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.dgvMotorcycles = new System.Windows.Forms.DataGridView();
            this.SoHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borderPanel2 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.borderPanel1 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnOther = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.SearchByDate.SuspendLayout();
            this.borderPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorcycles)).BeginInit();
            this.borderPanel2.SuspendLayout();
            this.borderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.Location = new System.Drawing.Point(17, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(43, 36);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
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
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(375, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 42);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SearchByDate
            // 
            this.SearchByDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchByDate.Controls.Add(this.panel3);
            this.SearchByDate.Controls.Add(this.btnWeek);
            this.SearchByDate.Controls.Add(this.label18);
            this.SearchByDate.Controls.Add(this.label2);
            this.SearchByDate.Controls.Add(this.btnSearchDay);
            this.SearchByDate.Controls.Add(this.btnMonth);
            this.SearchByDate.Controls.Add(this.dtpFrom);
            this.SearchByDate.Controls.Add(this.dtpTo);
            this.SearchByDate.Controls.Add(this.label1);
            this.SearchByDate.Location = new System.Drawing.Point(1066, 205);
            this.SearchByDate.Name = "SearchByDate";
            this.SearchByDate.Size = new System.Drawing.Size(272, 429);
            this.SearchByDate.TabIndex = 34;
            this.SearchByDate.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(41, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 31;
            // 
            // btnWeek
            // 
            this.btnWeek.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnWeek.Location = new System.Drawing.Point(52, 105);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(182, 44);
            this.btnWeek.TabIndex = 12;
            this.btnWeek.Text = "Week";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(163)))));
            this.label18.Location = new System.Drawing.Point(59, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 33);
            this.label18.TabIndex = 31;
            this.label18.Text = "Search Other";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "To";
            // 
            // btnSearchDay
            // 
            this.btnSearchDay.FlatAppearance.BorderSize = 0;
            this.btnSearchDay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSearchDay.Location = new System.Drawing.Point(70, 350);
            this.btnSearchDay.Name = "btnSearchDay";
            this.btnSearchDay.Size = new System.Drawing.Size(150, 30);
            this.btnSearchDay.TabIndex = 29;
            this.btnSearchDay.Text = "Search";
            this.btnSearchDay.UseVisualStyleBackColor = true;
            this.btnSearchDay.Click += new System.EventHandler(this.btnSearchDay_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.FlatAppearance.BorderSize = 0;
            this.btnMonth.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMonth.Location = new System.Drawing.Point(52, 172);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(179, 44);
            this.btnMonth.TabIndex = 13;
            this.btnMonth.Text = "Month";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(70, 269);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(150, 24);
            this.dtpFrom.TabIndex = 22;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(70, 308);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(150, 24);
            this.dtpTo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "From";
            // 
            // borderPanel3
            // 
            this.borderPanel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borderPanel3.Controls.Add(this.dgvMotorcycles);
            this.borderPanel3.Location = new System.Drawing.Point(15, 205);
            this.borderPanel3.Name = "borderPanel3";
            this.borderPanel3.Size = new System.Drawing.Size(1034, 600);
            this.borderPanel3.TabIndex = 33;
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
            this.dgvMotorcycles.Location = new System.Drawing.Point(15, 9);
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
            this.dgvMotorcycles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMotorcycles.Size = new System.Drawing.Size(1004, 469);
            this.dgvMotorcycles.StandardTab = true;
            this.dgvMotorcycles.TabIndex = 0;
            // 
            // SoHoaDon
            // 
            this.SoHoaDon.HeaderText = "So hoa don";
            this.SoHoaDon.Name = "SoHoaDon";
            this.SoHoaDon.ReadOnly = true;
            this.SoHoaDon.Width = 180;
            // 
            // nameCustomer
            // 
            this.nameCustomer.HeaderText = "ten khach hang";
            this.nameCustomer.Name = "nameCustomer";
            this.nameCustomer.ReadOnly = true;
            this.nameCustomer.Width = 180;
            // 
            // nameMotor
            // 
            this.nameMotor.HeaderText = "ten Xe";
            this.nameMotor.Name = "nameMotor";
            this.nameMotor.ReadOnly = true;
            this.nameMotor.Width = 180;
            // 
            // SoKhung
            // 
            this.SoKhung.HeaderText = "SoLuong";
            this.SoKhung.Name = "SoKhung";
            this.SoKhung.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Thanh Tien";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 180;
            // 
            // DateBuy
            // 
            this.DateBuy.HeaderText = "Ngay Mua";
            this.DateBuy.Name = "DateBuy";
            this.DateBuy.ReadOnly = true;
            this.DateBuy.Width = 150;
            // 
            // borderPanel2
            // 
            this.borderPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borderPanel2.Controls.Add(this.searchLabel);
            this.borderPanel2.Controls.Add(button1);
            this.borderPanel2.Controls.Add(this.txtSearch);
            this.borderPanel2.Location = new System.Drawing.Point(25, 126);
            this.borderPanel2.Name = "borderPanel2";
            this.borderPanel2.Size = new System.Drawing.Size(370, 48);
            this.borderPanel2.TabIndex = 32;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.searchLabel.Location = new System.Drawing.Point(66, 17);
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
            this.txtSearch.Location = new System.Drawing.Point(69, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 19);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // borderPanel1
            // 
            this.borderPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borderPanel1.Controls.Add(this.panel6);
            this.borderPanel1.Controls.Add(this.btnOther);
            this.borderPanel1.Controls.Add(this.panel4);
            this.borderPanel1.Controls.Add(this.btnToday);
            this.borderPanel1.Controls.Add(this.btnYesterday);
            this.borderPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderPanel1.Location = new System.Drawing.Point(401, 128);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(332, 51);
            this.borderPanel1.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(223, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 30);
            this.panel6.TabIndex = 27;
            // 
            // btnOther
            // 
            this.btnOther.FlatAppearance.BorderSize = 0;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(227, 5);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(101, 41);
            this.btnOther.TabIndex = 28;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Location = new System.Drawing.Point(110, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 30);
            this.panel4.TabIndex = 26;
            // 
            // btnToday
            // 
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(2, 2);
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
            this.btnYesterday.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesterday.Location = new System.Drawing.Point(117, 3);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(107, 44);
            this.btnYesterday.TabIndex = 16;
            this.btnYesterday.Text = "Yesterday";
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.SearchByDate);
            this.Controls.Add(this.borderPanel3);
            this.Controls.Add(this.borderPanel2);
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesHistory";
            this.Text = "SalesHistory";
            this.Load += new System.EventHandler(this.SalesHistory_Load);
            this.SearchByDate.ResumeLayout(false);
            this.SearchByDate.PerformLayout();
            this.borderPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorcycles)).EndInit();
            this.borderPanel2.ResumeLayout(false);
            this.borderPanel2.PerformLayout();
            this.borderPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMotorcycles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnSearchDay;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private borderRadius.borderPanel borderPanel1;
        private borderRadius.borderPanel borderPanel2;
        private borderRadius.borderPanel borderPanel3;
        private borderRadius.borderPanel SearchByDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBuy;
        private borderRadius.RoundedButton btnRefresh;
    }
}