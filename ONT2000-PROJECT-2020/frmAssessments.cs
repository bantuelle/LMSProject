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
    public partial class frmAssessments : Form
    {
        public frmAssessments()
        {
            InitializeComponent();
        }
        Assessment assessments = new Assessment();
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dal = new DataAccessLayer();
        private void frmAssessments_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("In-Active");
            cmbStatus.Items.Add("Active");


            cmbLec.DataSource = bll.GetLecturerModule();
            cmbLec.DisplayMember = "Name";
            cmbLec.ValueMember = "LecturerModuleID";
            cmbLec.Text = " ";

            Refresh();
        }
        public void Refresh()
        { 
            cmbType.DataSource = bll.GetAssessmentType();
            cmbType.ValueMember = "AssessmentTypeID";
            cmbType.DisplayMember = "AssessmentTypeDescription";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Assessment assessments = new Assessment();
            assessments.LecturerModuleID = Convert.ToInt16(cmbLec.SelectedValue.ToString());
            assessments.AssessmentDescription = txtDesc.Text;
            assessments.AssessmentTypeID = Convert.ToInt16(cmbType.SelectedValue.ToString());
            assessments.DueDate = dtaDueDate.Value.ToString();
            assessments.AssessmentStatus = cmbStatus.Text;
            int x = bll.AddAssessment(assessments);
            if (x > 0)
            {

                MessageBox.Show("Your updating failed");
            }
            else
            {
                MessageBox.Show("You have successfully added this assessment");
                Refresh();


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Assessment assessments = new Assessment();
            assessments.AssessmentID = int.Parse(dgvDisplayInfo.SelectedRows[0].Cells["AssessmentID"].Value.ToString());
            assessments.LecturerModuleID = Convert.ToInt16(cmbLec.SelectedValue.ToString());
            assessments.AssessmentDescription = txtDesc.Text;
            assessments.AssessmentTypeID = Convert.ToInt16(cmbType.SelectedValue.ToString());
            assessments.DueDate = dtaDueDate.Text;
            assessments.AssessmentStatus = cmbStatus.Text;

            int x = bll.UpdateAssessment(assessments);
            if (x > 0)
            {
               

                MessageBox.Show("You have successfully updated this assessment");
                Refresh();


            }
            else
            {
                MessageBox.Show("Select an assessment to update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            assessments.AssessmentID = int.Parse(dgvDisplayInfo.SelectedRows[0].Cells["AssessmentID"].Value.ToString());
            assessments.AssessmentStatus = "In-Active";
            bll.DeleteAssessment(assessments);
            dgvDisplayInfo.DataSource = bll.GetAssessments();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvDisplayInfo.DataSource = bll.GetAssessments();
        }
    }
}
