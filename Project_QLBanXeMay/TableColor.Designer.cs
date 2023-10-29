namespace Project_QLBanXeMay
{
    partial class TableColor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.borderPanel3 = new Project_QLBanXeMay.borderRadius.borderPanel();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.MaMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDelete = new Project_QLBanXeMay.borderRadius.RoundedButton();
            this.btnAddUpp = new Project_QLBanXeMay.borderRadius.RoundedButton();
            this.borderPanelBasic5 = new Project_QLBanXeMay.borderRadius.BorderPanelBasic();
            this.txtName = new System.Windows.Forms.TextBox();
            this.borderPanelBasic1 = new Project_QLBanXeMay.borderRadius.BorderPanelBasic();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.borderPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            this.borderPanelBasic5.SuspendLayout();
            this.borderPanelBasic1.SuspendLayout();
            this.SuspendLayout();
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
            this.label5.Text = "Color ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(24, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Mã Màu*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(24, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 97;
            this.label4.Text = "Tên Màu*";
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
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 592);
            this.panel1.TabIndex = 104;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // borderPanel3
            // 
            this.borderPanel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borderPanel3.Controls.Add(this.dgvColors);
            this.borderPanel3.Location = new System.Drawing.Point(243, 41);
            this.borderPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.borderPanel3.Name = "borderPanel3";
            this.borderPanel3.Size = new System.Drawing.Size(383, 512);
            this.borderPanel3.TabIndex = 63;
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AllowUserToDeleteRows = false;
            this.dgvColors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvColors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMau,
            this.nameColor});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColors.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvColors.Location = new System.Drawing.Point(15, 22);
            this.dgvColors.Margin = new System.Windows.Forms.Padding(6);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvColors.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvColors.RowHeadersVisible = false;
            this.dgvColors.RowHeadersWidth = 62;
            this.dgvColors.RowTemplate.Height = 50;
            this.dgvColors.RowTemplate.ReadOnly = true;
            this.dgvColors.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColors.Size = new System.Drawing.Size(352, 484);
            this.dgvColors.TabIndex = 1;
            this.dgvColors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColors_CellClick);
            // 
            // MaMau
            // 
            this.MaMau.HeaderText = "Mã Màu";
            this.MaMau.Name = "MaMau";
            this.MaMau.ReadOnly = true;
            this.MaMau.Width = 130;
            // 
            // nameColor
            // 
            this.nameColor.HeaderText = "Tên Màu";
            this.nameColor.Name = "nameColor";
            this.nameColor.ReadOnly = true;
            this.nameColor.Width = 200;
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
            // TableColor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableColor";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TableColor";
            this.Load += new System.EventHandler(this.TableColor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.borderPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.borderPanelBasic5.ResumeLayout(false);
            this.borderPanelBasic5.PerformLayout();
            this.borderPanelBasic1.ResumeLayout(false);
            this.borderPanelBasic1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColors;
        private borderRadius.borderPanel borderPanel3;
        private System.Windows.Forms.Label label5;
        private borderRadius.BorderPanelBasic borderPanelBasic5;
        private System.Windows.Forms.TextBox txtName;
        private borderRadius.BorderPanelBasic borderPanelBasic1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private borderRadius.RoundedButton BtnDelete;
        private borderRadius.RoundedButton btnAddUpp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColor;
        private System.Windows.Forms.Panel panel1;
    }
}