using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TCDApplication.Entity;

namespace TCDApplication
{
    public partial class CustomerDetailsShow : Form
    {
        TCDEntities1 entity;
        public CustomerDetailsShow()
        {
            InitializeComponent();
        }

        private void CustomerDetailsShow_Load(object sender, EventArgs e)
        {
            using (entity = new TCDEntities1())
            {
                var data = (from cd in entity.tbl_CustomerDetails
                            join m in entity.tbl_ProjectDetails
                            on cd.ProjectId  equals m.ProjectId
                            orderby cd.CustomerName
                            select new
                            {
                                Id = cd.CustomerId,
                                Name = cd.CustomerName,
                                Address = cd.CustomerAddress,
                                Phone= cd.CustomerPhone,
                                ProjectName = m.ProjectName
                            }).ToList();
                dgvCustomerDetails.DataSource = data;
            }
        }
    }
}
