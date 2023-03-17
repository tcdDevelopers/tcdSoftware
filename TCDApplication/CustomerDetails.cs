using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCDApplication.Entity;

namespace TCDApplication
{
    public partial class CustomerDetails : Form
    {
        TCDEntities1 entities1;
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            using(entities1 = new TCDEntities1())
            {
                drd_project.DataSource = from p in entities1.tbl_ProjectDetails
                                         orderby p.ProjectName
                                         select new { p.ProjectId, p.ProjectName };
                drd_project.DisplayMember = "ProjectName";
                drd_project.ValueMember = "ProjectId";
                

            }
        }
    }
}
