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
    public partial class ForgotPass : Form
    {
        //String email;
     

        public ForgotPass()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (email2.Text == "" && name2.Text== "")
            {
                MessageBox.Show("Retry");
            }
            else
            {
                MessageBox.Show("Email send to your mail please confirm");
            }
            }

        private void email2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
