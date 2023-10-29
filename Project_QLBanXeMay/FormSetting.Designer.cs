namespace Project_QLBanXeMay
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Account = new System.Windows.Forms.TabPage();
            this.CustomerTab = new System.Windows.Forms.TabPage();
            this.MotorTab = new System.Windows.Forms.TabPage();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnRefresh = new Project_QLBanXeMay.borderRadius.RoundedButton();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 42);
            this.label5.TabIndex = 3;
            this.label5.Text = "Setting";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Account);
            this.tabControl1.Controls.Add(this.CustomerTab);
            this.tabControl1.Controls.Add(this.MotorTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(130, 30);
            this.tabControl1.Location = new System.Drawing.Point(33, 73);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1271, 727);
            this.tabControl1.TabIndex = 3;
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.Location = new System.Drawing.Point(4, 34);
            this.Account.Margin = new System.Windows.Forms.Padding(0);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(1263, 689);
            this.Account.TabIndex = 0;
            this.Account.Text = "           Account           ";
            // 
            // CustomerTab
            // 
            this.CustomerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CustomerTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTab.Location = new System.Drawing.Point(4, 34);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTab.Size = new System.Drawing.Size(1263, 689);
            this.CustomerTab.TabIndex = 1;
            this.CustomerTab.Text = "   Customer Deleted      ";
            // 
            // MotorTab
            // 
            this.MotorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.MotorTab.Location = new System.Drawing.Point(4, 34);
            this.MotorTab.Name = "MotorTab";
            this.MotorTab.Size = new System.Drawing.Size(1263, 689);
            this.MotorTab.TabIndex = 2;
            this.MotorTab.Text = "       Motorcycle Deleted      ";
            // 
            // txtPosition
            // 
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(2, 5);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(0);
            this.txtPosition.Multiline = true;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPosition.Size = new System.Drawing.Size(210, 19);
            this.txtPosition.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(193, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 42);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 911);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Account;
        private System.Windows.Forms.TabPage CustomerTab;
        private System.Windows.Forms.TabPage MotorTab;
        private System.Windows.Forms.TextBox txtPosition;
        private borderRadius.RoundedButton btnRefresh;
    }
}