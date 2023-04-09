using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCDApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void projectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ProjectDetails pd = new ProjectDetails();
            pd.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDetails cd = new CustomerDetails();
            cd.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void searchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerBooking cb = new CustomerBooking();
            cb.ShowDialog();
        }
    }
}
