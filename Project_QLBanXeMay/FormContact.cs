using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Project_QLBanXeMay
{
    public partial class FormContact : Form
    {
        public FormContact()
        {
            InitializeComponent();
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void setBorderTextBox()
        {
            //txtName.borc
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string from, to, message, pass;
                
                to = "nguyenphong.210703@gmail.com";
                message = txtMessage.Text.Trim();
                string subject = "Send to";
         

                from = "team3.hutech@gmail.com";
                pass = "uytinh123";

                
                string Host = "smtp.office365.com";
                int Port = 587;

                using (MailMessage mail = new MailMessage(from, to, subject, message))
                {
                    using (SmtpClient smtp = new SmtpClient(Host, Port))
                    {
                        smtp.UseDefaultCredentials = false;
                        
                       smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        smtp.Send(mail);
                        smtp.Timeout = 20000;
                        MessageBox.Show("Email send successfully");
                    }
                }
               

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
