using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCDApplication.BL;
using TCDApplication.Entity;

namespace TCDApplication
{
    public partial class ProjectDetails : Form
    {
        TCDEntities1 entity;
        tbl_ProjectDetails details;
        public ProjectDetails()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using(entity = new TCDEntities1())
            {
                details = new tbl_ProjectDetails()
                {
                    ProjectId = Convert.ToInt32(txtId.Text.ToString()),
                    ProjectName = txtName.Text.ToUpper(),
                    ProjectAddress = txtAddress.Text.ToUpper()
                };
                entity.tbl_ProjectDetails.Add(details);
                entity.SaveChanges();
                MessageBox.Show("Data saved successfully");
                txtName.Clear();
                txtAddress.Clear();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
        }

        private void ProjectDetails_Load(object sender, EventArgs e)
        {
            using (entity = new TCDEntities1())
            {
                var lastval = entity.tbl_ProjectDetails.Select(x => x.ProjectId).OrderByDescending(z => z).FirstOrDefault();
                var projecId = lastval + 1;
                txtId.Text = Convert.ToString(projecId);
            }
        }
    }
}
