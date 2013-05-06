using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBox2.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("error in email");
                    return;
                }
                MailMessage message = new MailMessage();
                message.From = new MailAddress(textBox2.Text);
                message.Subject = textBox1.Text;
                message.Body = richTextBox2.Text;

                foreach (String s in richTextBox1.Text.Split(';'))
                {
                    message.To.Add(s);
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new NetworkCredential(textBox2.Text, textBox3.Text);
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Send(message);

                }
            }
            catch { MessageBox.Show("Enter Valid Email Address or check the internet connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
