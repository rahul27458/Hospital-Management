using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ForgotPass forgotpass = new ForgotPass();
        Registration register = new Registration();
        Emergency em = new Emergency();
        Professional pf = new Professional();
        Contact ct = new Contact();
        About ab = new About();
        Doctor doc = new Doctor();
        Staff st=new Staff();
        Registration reg = new Registration();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void emergencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            em.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpass.Show();
            

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register.Show();
           
        }

      

        private void professionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.Show();
           
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ct.Show();
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ab.Show();
          
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string getstr="";
            Login log = new Login();

            getstr = log.Authenticate(textBox1.Text, textBox2.Text);

            if (getstr == "doc")
            {
                doc.Show();
            }


            if(getstr == "staff" )
            {
                st.Show();
            }
           /* if (textBox1.Text == "doctor" && textBox2.Text == "doctor")
            {
                doc.Show();
                    
            }
            else
            {
                if (textBox1.Text == "staff" && textBox2.Text == "staff")
                {
                    st.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid User");
                    
                }

            }*/
           
        }
    

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reg.Show();
            
        }

        
       

        

       
    }
}
