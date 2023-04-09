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
            using (entities1 = new TCDEntities1())
            {
                var lstCustVal = entities1.tbl_CustomerDetails.Select(x => x.CustomerId).OrderByDescending(z => z).FirstOrDefault();
                var customerId = lstCustVal + 1;
                txt_cust_Id.Text = Convert.ToString(customerId);

                var dbsource = (from p in entities1.tbl_ProjectDetails
                                orderby p.ProjectName
                                select new { p.ProjectId, p.ProjectName }).ToList();
                drd_project.DisplayMember = "ProjectName";
                drd_project.ValueMember = "ProjectId";
                drd_project.DataSource = dbsource;


                var data = (from cd in entities1.tbl_CustomerDetails
                            join m in entities1.tbl_ProjectDetails
                            on cd.ProjectId equals m.ProjectId
                            orderby cd.CustomerName
                            select new
                            {
                                Id = cd.CustomerId,
                                Name = cd.CustomerName,
                                Address = cd.CustomerAddress,
                                Phone = cd.CustomerPhone,
                                ProjectName = m.ProjectName
                            }).ToList();
                dgvCustomerDetails.DataSource = data;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                using (entities1 = new TCDEntities1())
                {
                    tbl_CustomerDetails cd = new tbl_CustomerDetails()
                    {
                        CustomerId = Convert.ToInt32(txt_cust_Id.Text.ToString()),
                        CustomerName = txt_cust_Name.Text.ToString(),
                        CustomerAddress = txt_cust_Address.Text.ToString(),
                        CustomerPhone = txt_cust_phone.Text.ToString(),
                        ProjectId = Convert.ToInt32(drd_project.SelectedValue.ToString())
                    };
                    entities1.tbl_CustomerDetails.Add(cd);
                    entities1.SaveChanges();
                    MessageBox.Show("Data added successfully");
                    txt_cust_Name.Clear();
                    txt_cust_Address.Clear();
                    txt_cust_phone.Clear();
                }
            }
            catch(Exception ex)
            {
                ex.InnerException.ToString();
            } 
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_cust_Name.Clear();
            txt_cust_Address.Clear();
            txt_cust_phone.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
