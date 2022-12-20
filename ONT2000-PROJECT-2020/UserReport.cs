/*
 * Student number:219143943   Name:Nobantu      Surname:Ndlovu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ONT2000_PROJECT_2020
{
    public partial class UserReport : Form
    {
        public UserReport()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dal = new DataAccessLayer();
        private void UserReport_Load(object sender, EventArgs e)
        {
            cmbUserType.Items.Add("Administrator");
            cmbUserType.Items.Add("Lecturer");
            cmbUserType.Items.Add("Student");
        }

        private void btnSearchByType_Click(object sender, EventArgs e)
        {
            dgvDisplayUsers.DataSource = bll.GetUsersByRole(cmbUserType.Text);
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsersName.Text))
            {
                errorSearchByUserDetails.SetError(txtUsersName, "Please do not leave field empty.");
            }
            else
            {
                int search;
                Int32.TryParse(txtUsersName.Text, out search);
                dgvDisplayUsers.DataSource = bll.GetUsersBySearching(search, txtUsersName.Text);
            }
        }
    }
}
