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
            this.label5 = new System.Windows.Forms.Label();
            this.borderPanel4 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.borderPanel2 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.countTotalStaff = new System.Windows.Forms.Label();
            this.borderPanel1 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.borderPanel3 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button2 = new System.Windows.Forms.Button();
            this.borderPanel4.SuspendLayout();
            this.borderPanel2.SuspendLayout();
            this.borderPanel1.SuspendLayout();
            this.borderPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            button2.Location = new System.Drawing.Point(14, 6);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(43, 36);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
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
            this.borderPanel4.Location = new System.Drawing.Point(256, 9);
            this.borderPanel4.Name = "borderPanel4";
            this.borderPanel4.Size = new System.Drawing.Size(370, 48);
            this.borderPanel4.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(63, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Search  By Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(66, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 19);
            this.textBox1.TabIndex = 10;
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
            this.label2.Location = new System.Drawing.Point(82, 14);
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
            this.countTotalStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.countTotalStaff.Location = new System.Drawing.Point(95, 47);
            this.countTotalStaff.Margin = new System.Windows.Forms.Padding(0);
            this.countTotalStaff.Name = "countTotalStaff";
            this.countTotalStaff.Size = new System.Drawing.Size(41, 29);
            this.countTotalStaff.TabIndex = 4;
            this.countTotalStaff.Text = "12";
            // 
            // borderPanel1
            // 
            this.borderPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borderPanel1.Controls.Add(this.label10);
            this.borderPanel1.Controls.Add(this.lbName);
            this.borderPanel1.Controls.Add(this.label9);
            this.borderPanel1.Location = new System.Drawing.Point(343, 118);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(259, 93);
            this.borderPanel1.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(83, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Typical Staff";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(163)))));
            this.lbName.Location = new System.Drawing.Point(21, 40);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 29);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name";
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
            // borderPanel3
            // 
            this.borderPanel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borderPanel3.Controls.Add(this.dgvStaff);
            this.borderPanel3.Location = new System.Drawing.Point(33, 240);
            this.borderPanel3.Name = "borderPanel3";
            this.borderPanel3.Size = new System.Drawing.Size(990, 584);
            this.borderPanel3.TabIndex = 63;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.Location = new System.Drawing.Point(20, 20);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(9);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowTemplate.Height = 50;
            this.dgvStaff.RowTemplate.ReadOnly = true;
            this.dgvStaff.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(959, 531);
            this.dgvStaff.StandardTab = true;
            this.dgvStaff.TabIndex = 1;
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
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 740);
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
            this.borderPanel4.ResumeLayout(false);
            this.borderPanel4.PerformLayout();
            this.borderPanel2.ResumeLayout(false);
            this.borderPanel2.PerformLayout();
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            this.borderPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private borderRadius.borderPanel borderPanel3;
        private System.Windows.Forms.DataGridView dgvStaff;
        private borderRadius.borderPanel borderPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countTotalStaff;
        private borderRadius.borderPanel borderPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbName;
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