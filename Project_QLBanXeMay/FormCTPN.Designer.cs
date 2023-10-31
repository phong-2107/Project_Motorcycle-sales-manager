namespace Project_QLBanXeMay
{
    partial class FormCTPN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.borderPanel1 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.dgvMotorcycles = new System.Windows.Forms.DataGridView();
            this.IDImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Somay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbName = new System.Windows.Forms.Label();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorcycles)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 42);
            this.label5.TabIndex = 36;
            this.label5.Text = "Import Detail: ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExit.Location = new System.Drawing.Point(638, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 34);
            this.btnExit.TabIndex = 104;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // borderPanel1
            // 
            this.borderPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.borderPanel1.Controls.Add(this.dgvMotorcycles);
            this.borderPanel1.Location = new System.Drawing.Point(11, 50);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(651, 296);
            this.borderPanel1.TabIndex = 105;
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMotorcycles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMotorcycles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotorcycles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDImport,
            this.NameMotor,
            this.SoKhung,
            this.Somay});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMotorcycles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMotorcycles.Location = new System.Drawing.Point(19, 21);
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
            this.dgvMotorcycles.Size = new System.Drawing.Size(610, 236);
            this.dgvMotorcycles.StandardTab = true;
            this.dgvMotorcycles.TabIndex = 1;
            // 
            // IDImport
            // 
            this.IDImport.HeaderText = "IdDetail";
            this.IDImport.Name = "IDImport";
            this.IDImport.ReadOnly = true;
            // 
            // NameMotor
            // 
            this.NameMotor.HeaderText = "Ten Xe";
            this.NameMotor.Name = "NameMotor";
            this.NameMotor.ReadOnly = true;
            this.NameMotor.Width = 180;
            // 
            // SoKhung
            // 
            this.SoKhung.HeaderText = "Số Khung";
            this.SoKhung.Name = "SoKhung";
            this.SoKhung.ReadOnly = true;
            this.SoKhung.Width = 160;
            // 
            // Somay
            // 
            this.Somay.HeaderText = "Số Máy";
            this.Somay.Name = "Somay";
            this.Somay.ReadOnly = true;
            this.Somay.Width = 160;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(244, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(125, 26);
            this.lbName.TabIndex = 106;
            this.lbName.Text = "Import Detail";
            // 
            // FormCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(679, 357);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCTPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCTPN";
            this.Load += new System.EventHandler(this.FormCTPN_Load);
            this.borderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorcycles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMotorcycles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private borderRadius.borderPanel borderPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Somay;
        private System.Windows.Forms.Label lbName;
    }
}