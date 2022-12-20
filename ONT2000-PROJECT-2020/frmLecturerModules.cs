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
    public partial class frmLecturerModules : Form
    {
        public frmLecturerModules()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dal = new DataAccessLayer();
        public void RefreshDGV()
        {
            dataGridView1.DataSource = bll.GetLecturerModule();
        }
        public void Refresh()
        {


            cmbLecturer.DataSource = bll.GetLecturer();
            cmbLecturer.ValueMember = "UserID";
            cmbLecturer.DisplayMember = "Name & Surname";

            cmbModule.DataSource = bll.GetModule();
            cmbModule.ValueMember = "ModuleID";
            cmbModule.DisplayMember = "ModuleName";


        }
        private void frmLecturerModules_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In-Active");
            Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LecturerModule lecturerModule = new LecturerModule();
            lecturerModule.UserID = Convert.ToInt16(cmbLecturer.SelectedValue.ToString());
            lecturerModule.ModuleID = Convert.ToInt16(cmbModule.SelectedValue.ToString());
            lecturerModule.Date = dtaDate.Value.ToString();
            lecturerModule.ModLecturerStatus = cmbStatus.Text;
            int x = bll.AddLecturerModule(lecturerModule);
            if (x > 0)
            {
                MessageBox.Show("A Lecturer Module has been" + " " + " Added");
                RefreshDGV();

            }
            else
            {
                MessageBox.Show("Lecturer has not been  Added");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LecturerModule lecturerModule = new LecturerModule();
            lecturerModule.LecturerModuleID = int.Parse(dataGridView1.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString());
            lecturerModule.UserID = Convert.ToInt16(cmbLecturer.SelectedValue.ToString());
            lecturerModule.ModuleID = Convert.ToInt16(cmbModule.SelectedValue.ToString());
            lecturerModule.Date = dtaDate.Value.ToString();
            lecturerModule.ModLecturerStatus = cmbStatus.Text;
            int x = bll.UpdateLecturerModule(lecturerModule);
            if (x > 0)
            {
                MessageBox.Show("You have succesfully updated lecturer's module");
                RefreshDGV();
            }
            else
            {



                MessageBox.Show("Select a lecturer if you want to update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LecturerModule LecModule = new LecturerModule();
            LecModule.LecturerModuleID = int.Parse(dataGridView1.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString());
            int x = bll.DeleteLecturerModule(LecModule);
            if (x > 0)
            {
                MessageBox.Show("A Lecturer Module has been" + " " + " Deleted!!!!");
                RefreshDGV();

            }
            else
            {
                MessageBox.Show("Lecturer has not been  Deleted!!!!");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                LecturerModule lecturerModule = new LecturerModule();
                DataTable data = new DataTable();
                lecturerModule.LecturerModuleID = int.Parse(dataGridView1.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString());
                cmbLecturer.SelectedItem = data.Rows[0]["UserID"].ToString();
                cmbModule.SelectedItem = data.Rows[0]["ModuleID"].ToString();
                dtaDate.Text = data.Rows[0]["Date"].ToString();
                cmbStatus.SelectedValue = data.Rows[0]["ModLecturerStatus"].ToString();
            }
        }
    }
}
