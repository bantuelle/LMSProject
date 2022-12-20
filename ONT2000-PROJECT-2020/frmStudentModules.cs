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
    public partial class frmStudentModules : Form
    {
        public frmStudentModules()
        {
            InitializeComponent();
        }
        DataAccessLayer dal = new DataAccessLayer();
        BusinessLogicLayer bll = new BusinessLogicLayer();

        public void Refresh()
        {
            cmbStudModStatus.Items.Add("In-Active");
            cmbStudModStatus.Items.Add("Active");

            cmbStudent.DataSource = bll.GetStudent();
            cmbStudent.DisplayMember = "Name & Surname";
            cmbStudent.ValueMember = "UserID";
            cmbStudent.Text = " ";

            cmblecturer.DataSource = bll.GetLecturer();
            cmblecturer.ValueMember = "UserID";
            cmblecturer.DisplayMember = "Name & Surname";
            cmblecturer.Text = " ";


            cmbModule.DataSource = bll.GetModule();
            cmbModule.ValueMember = "ModuleID";
            cmbModule.DisplayMember = "ModuleName";
            cmbModule.Text = " ";

            dgvDisplay.DataSource = bll.GetStudentModule();
        }
        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentModule student = new StudentModule();
            DataTable data = new DataTable();
            student.UserID = int.Parse(dgvDisplay.SelectedRows[0].Cells["UserID"].Value.ToString());
            cmbStudent.SelectedItem = data.Rows[0]["StudentModuleID"].ToString();
            cmblecturer.SelectedItem = data.Rows[0]["LecturerModuleID"].ToString();
            dtaDate.Text = data.Rows[0]["Date"].ToString();
            cmbStudModStatus.SelectedValue = data.Rows[0]["StudModStatus"].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentModule student = new StudentModule();

            student.StudentModuleID = int.Parse(cmbStudent.SelectedItem.ToString());
            student.LecturerModuleID = int.Parse(cmblecturer.SelectedItem.ToString());
            student.Date = dtaDate.Text;
            student.StudModStatus = cmbStudModStatus.SelectedValue.ToString();
            int x = bll.AddStudentModule(student);
            if (x > 0)
            {
                MessageBox.Show("A student's Module has been" + " " + " Added");
                Refresh();
            }
            else
            {
                MessageBox.Show("Student has not been " + " " + " Added");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentModule student = new StudentModule();
            student.StudentModuleID = int.Parse(dgvDisplay.SelectedRows[0].Cells["StudentModuleID"].Value.ToString());
            student.LecturerModuleID = Convert.ToInt16(cmblecturer.SelectedValue.ToString());
            student.UserID = Convert.ToInt16(cmbStudent.SelectedValue.ToString());
            student.Date = dtaDate.Value.ToString();
            student.StudModStatus = cmbStudModStatus.Text;
            int x = bll.UpdateStudentModule(student);
            if (x > 0)
            {
                MessageBox.Show("You have succesfully updated student's module");
                dgvDisplay.DataSource = bll.GetStudentModule();

            }
            else
            {



                MessageBox.Show("Select a student if you want to update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StudentModule studentModule = new StudentModule();
            studentModule.StudentModuleID = int.Parse(dgvDisplay.SelectedRows[0].Cells["StudentModuleID"].Value.ToString());
            bll.DeleteStudentModule(studentModule);
            dgvDisplay.DataSource = bll.GetStudentModule();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.GetStudentModule();
        }

        private void frmStudentModules_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
