namespace Project_QLBanXeMay
{
    partial class TableBrand
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.borderPanel3 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.dgvBrands = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDelete = new Project_QLBanXeMay.borderRadius.RoundedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddUpp = new Project_QLBanXeMay.borderRadius.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.borderPanelBasic5 = new Project_QLBanXeMay.borderRadius.BorderPanelBasic();
            this.txtName = new System.Windows.Forms.TextBox();
            this.borderPanelBasic1 = new Project_QLBanXeMay.borderRadius.BorderPanelBasic();
            this.txtID = new System.Windows.Forms.TextBox();
            this.MaMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.borderPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).BeginInit();
            this.borderPanelBasic5.SuspendLayout();
            this.borderPanelBasic1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.borderPanel3);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddUpp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.borderPanelBasic5);
            this.panel1.Controls.Add(this.borderPanelBasic1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 592);
            this.panel1.TabIndex = 105;
            // 
            // borderPanel3
            // 
            this.borderPanel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borderPanel3.Controls.Add(this.dgvBrands);
            this.borderPanel3.Location = new System.Drawing.Point(243, 41);
            this.borderPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.borderPanel3.Name = "borderPanel3";
            this.borderPanel3.Size = new System.Drawing.Size(383, 512);
            this.borderPanel3.TabIndex = 63;
            // 
            // dgvBrands
            // 
            this.dgvBrands.AllowUserToAddRows = false;
            this.dgvBrands.AllowUserToDeleteRows = false;
            this.dgvBrands.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBrands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBrands.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMau,
            this.nameColor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrands.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBrands.Location = new System.Drawing.Point(15, 22);
            this.dgvBrands.Margin = new System.Windows.Forms.Padding(6);
            this.dgvBrands.Name = "dgvBrands";
            this.dgvBrands.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBrands.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBrands.RowHeadersVisible = false;
            this.dgvBrands.RowHeadersWidth = 62;
            this.dgvBrands.RowTemplate.Height = 50;
            this.dgvBrands.RowTemplate.ReadOnly = true;
            this.dgvBrands.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrands.Size = new System.Drawing.Size(352, 473);
            this.dgvBrands.TabIndex = 1;
            this.dgvBrands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrands_CellClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExit.Location = new System.Drawing.Point(600, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 34);
            this.btnExit.TabIndex = 103;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 42);
            this.label5.TabIndex = 64;
            this.label5.Text = "Brand";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Tomato;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnDelete.Location = new System.Drawing.Point(13, 317);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(215, 49);
            this.BtnDelete.TabIndex = 102;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(24, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 97;
            this.label4.Text = "TênHãng*";
            // 
            // btnAddUpp
            // 
            this.btnAddUpp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddUpp.Location = new System.Drawing.Point(14, 264);
            this.btnAddUpp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUpp.Name = "btnAddUpp";
            this.btnAddUpp.Size = new System.Drawing.Size(214, 49);
            this.btnAddUpp.TabIndex = 101;
            this.btnAddUpp.Text = "Add / Update";
            this.btnAddUpp.UseVisualStyleBackColor = false;
            this.btnAddUpp.Click += new System.EventHandler(this.btnAddUpp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(24, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Mã Hãng*";
            // 
            // borderPanelBasic5
            // 
            this.borderPanelBasic5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.borderPanelBasic5.Controls.Add(this.txtName);
            this.borderPanelBasic5.Location = new System.Drawing.Point(17, 208);
            this.borderPanelBasic5.Name = "borderPanelBasic5";
            this.borderPanelBasic5.Size = new System.Drawing.Size(221, 38);
            this.borderPanelBasic5.TabIndex = 100;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(10, 9);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(202, 20);
            this.txtName.TabIndex = 5;
            // 
            // borderPanelBasic1
            // 
            this.borderPanelBasic1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.borderPanelBasic1.Controls.Add(this.txtID);
            this.borderPanelBasic1.Location = new System.Drawing.Point(14, 148);
            this.borderPanelBasic1.Name = "borderPanelBasic1";
            this.borderPanelBasic1.Size = new System.Drawing.Size(224, 38);
            this.borderPanelBasic1.TabIndex = 99;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(13, 9);
            this.txtID.Margin = new System.Windows.Forms.Padding(0);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtID.Size = new System.Drawing.Size(189, 20);
            this.txtID.TabIndex = 5;
            // 
            // MaMau
            // 
            this.MaMau.HeaderText = "Mã Hãng";
            this.MaMau.Name = "MaMau";
            this.MaMau.ReadOnly = true;
            this.MaMau.Width = 130;
            // 
            // nameColor
            // 
            this.nameColor.HeaderText = "TênHãng";
            this.nameColor.Name = "nameColor";
            this.nameColor.ReadOnly = true;
            this.nameColor.Width = 200;
            // 
            // TableBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(646, 596);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableBrand";
            this.Text = "TableBrand";
            this.Load += new System.EventHandler(this.TableBrand_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.borderPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).EndInit();
            this.borderPanelBasic5.ResumeLayout(false);
            this.borderPanelBasic5.PerformLayout();
            this.borderPanelBasic1.ResumeLayout(false);
            this.borderPanelBasic1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private borderRadius.borderPanel borderPanel3;
        private System.Windows.Forms.DataGridView dgvBrands;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private borderRadius.RoundedButton BtnDelete;
        private System.Windows.Forms.Label label4;
        private borderRadius.RoundedButton btnAddUpp;
        private System.Windows.Forms.Label label1;
        private borderRadius.BorderPanelBasic borderPanelBasic5;
        private System.Windows.Forms.TextBox txtName;
        private borderRadius.BorderPanelBasic borderPanelBasic1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColor;
    }
}