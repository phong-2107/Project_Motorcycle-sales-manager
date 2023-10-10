namespace Project_QLBanXeMay
{
    partial class QLNhanVien
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
            System.Windows.Forms.Button button2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.borderPanel3 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.dgvMotorcycles = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borderPanel2 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.countTotalStaff = new System.Windows.Forms.Label();
            this.borderPanel1 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.borderPanel4 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            this.borderPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorcycles)).BeginInit();
            this.borderPanel2.SuspendLayout();
            this.borderPanel1.SuspendLayout();
            this.borderPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            button2.Location = new System.Drawing.Point(17, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(43, 36);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            // 
            // borderPanel3
            // 
            this.borderPanel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borderPanel3.Controls.Add(this.dgvMotorcycles);
            this.borderPanel3.Location = new System.Drawing.Point(33, 240);
            this.borderPanel3.Name = "borderPanel3";
            this.borderPanel3.Size = new System.Drawing.Size(990, 584);
            this.borderPanel3.TabIndex = 63;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMotorcycles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMotorcycles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotorcycles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.staffName,
            this.StaffSex,
            this.StaffPhone,
            this.StaffEmail,
            this.StaffAddress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMotorcycles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMotorcycles.Location = new System.Drawing.Point(9, 25);
            this.dgvMotorcycles.Margin = new System.Windows.Forms.Padding(9);
            this.dgvMotorcycles.Name = "dgvMotorcycles";
            this.dgvMotorcycles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMotorcycles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMotorcycles.RowHeadersVisible = false;
            this.dgvMotorcycles.RowTemplate.Height = 50;
            this.dgvMotorcycles.RowTemplate.ReadOnly = true;
            this.dgvMotorcycles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMotorcycles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMotorcycles.Size = new System.Drawing.Size(959, 531);
            this.dgvMotorcycles.StandardTab = true;
            this.dgvMotorcycles.TabIndex = 1;
            // 
            // StaffID
            // 
            this.StaffID.HeaderText = "ID";
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // staffName
            // 
            this.staffName.HeaderText = "FullName";
            this.staffName.Name = "staffName";
            this.staffName.ReadOnly = true;
            this.staffName.Width = 200;
            // 
            // StaffSex
            // 
            this.StaffSex.HeaderText = "Sex";
            this.StaffSex.Name = "StaffSex";
            this.StaffSex.ReadOnly = true;
            // 
            // StaffPhone
            // 
            this.StaffPhone.HeaderText = "Phone";
            this.StaffPhone.Name = "StaffPhone";
            this.StaffPhone.ReadOnly = true;
            this.StaffPhone.Width = 150;
            // 
            // StaffEmail
            // 
            this.StaffEmail.HeaderText = "Email";
            this.StaffEmail.Name = "StaffEmail";
            this.StaffEmail.ReadOnly = true;
            this.StaffEmail.Width = 200;
            // 
            // StaffAddress
            // 
            this.StaffAddress.HeaderText = "Address";
            this.StaffAddress.Name = "StaffAddress";
            this.StaffAddress.ReadOnly = true;
            this.StaffAddress.Width = 200;
            // 
            // borderPanel2
            // 
            this.borderPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borderPanel2.Controls.Add(this.label2);
            this.borderPanel2.Controls.Add(this.countTotalStaff);
            this.borderPanel2.Location = new System.Drawing.Point(53, 118);
            this.borderPanel2.Name = "borderPanel2";
            this.borderPanel2.Size = new System.Drawing.Size(237, 93);
            this.borderPanel2.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(66, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Staff";
            // 
            // countTotalStaff
            // 
            this.countTotalStaff.AutoSize = true;
            this.countTotalStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTotalStaff.ForeColor = System.Drawing.Color.Black;
            this.countTotalStaff.Location = new System.Drawing.Point(84, 47);
            this.countTotalStaff.Margin = new System.Windows.Forms.Padding(0);
            this.countTotalStaff.Name = "countTotalStaff";
            this.countTotalStaff.Size = new System.Drawing.Size(41, 29);
            this.countTotalStaff.TabIndex = 4;
            this.countTotalStaff.Text = "12";
            // 
            // borderPanel1
            // 
            this.borderPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borderPanel1.Controls.Add(this.label7);
            this.borderPanel1.Controls.Add(this.label10);
            this.borderPanel1.Controls.Add(this.label8);
            this.borderPanel1.Controls.Add(this.label9);
            this.borderPanel1.Location = new System.Drawing.Point(343, 118);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(237, 93);
            this.borderPanel1.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(130, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "+ 5.34%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(40, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Motorcycle  SOLD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(39, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "250";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 42);
            this.label5.TabIndex = 64;
            this.label5.Text = "Manager Staff";
            // 
            // borderPanel4
            // 
            this.borderPanel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borderPanel4.Controls.Add(this.label3);
            this.borderPanel4.Controls.Add(button2);
            this.borderPanel4.Controls.Add(this.textBox1);
            this.borderPanel4.Location = new System.Drawing.Point(256, 3);
            this.borderPanel4.Name = "borderPanel4";
            this.borderPanel4.Size = new System.Drawing.Size(370, 48);
            this.borderPanel4.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(66, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Search  By Name";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(66, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 19);
            this.textBox1.TabIndex = 10;
            // 
            // QLNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1640, 875);
            this.Controls.Add(this.borderPanel4);
            this.Controls.Add(this.borderPanel2);
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.borderPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "QLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QLNhanVien";
            this.Load += new System.EventHandler(this.QLNhanVien_Load);
            this.borderPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorcycles)).EndInit();
            this.borderPanel2.ResumeLayout(false);
            this.borderPanel2.PerformLayout();
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            this.borderPanel4.ResumeLayout(false);
            this.borderPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private borderRadius.borderPanel borderPanel3;
        private System.Windows.Forms.DataGridView dgvMotorcycles;
        private borderRadius.borderPanel borderPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countTotalStaff;
        private borderRadius.borderPanel borderPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private borderRadius.borderPanel borderPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffAddress;
    }
}