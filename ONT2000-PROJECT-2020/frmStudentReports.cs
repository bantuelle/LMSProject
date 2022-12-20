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

namespace ONT2000_PROJECT_2020
{
    public partial class frmStudentReports : Form
    {
        public frmStudentReports()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = bll.GetStudentByID(int.Parse(dataGridView1.SelectedRows[0].Cells["UserID"].Value.ToString()), dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString());

            }
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchID.Text))
            {
                errorProvider1.SetError(txtSearchID, "Please do not leave field empty.");
            }
            else
            {
                int StudentID;
                Int32.TryParse(txtSearchID.Text, out StudentID);
                dataGridView1.DataSource = bll.GetStudentByID(StudentID, txtSearchID.Text);
            }
        }
    }
}
