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
    public partial class ProjectDataShow : Form
    {
        TCDEntities1 entity;
        tbl_ProjectDetails details;
        public ProjectDataShow()
        {
            InitializeComponent();
        }

        private void ProjectDataShow_Load(object sender, EventArgs e)
        {
            using(entity = new TCDEntities1())
            {
                var data = (from pr in entity.tbl_ProjectDetails
                            orderby pr.ProjectId
                            select new
                            {
                                Id = pr.ProjectId,
                                Name = pr.ProjectName,
                                Address = pr.ProjectAddress
                            }).ToList();
                dgvProject.DataSource = data;
            }
        }
    }
}
