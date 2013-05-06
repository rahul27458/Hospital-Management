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
    public partial class CreateAppointment : Form
    {
        public CreateAppointment()
        {
            InitializeComponent();
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appointmentDBDataSet);

        }

        private void CreateAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appointmentDBDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.appointmentDBDataSet.People);

        }

        
    }
}
