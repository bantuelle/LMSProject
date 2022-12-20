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
    public partial class frmSubmissionAssessments : Form
    {
        public frmSubmissionAssessments()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dal = new DataAccessLayer();
        AssessmentsSubmission submission = new AssessmentsSubmission();
        private void frmSubmissionAssessments_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetAssessments();
            cmbSubmitStatus.Items.Add("Completed");
            cmbSubmitStatus.Items.Add("Missed");
            cmbSubmitStatus.Items.Add("Rescheduled");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Assessment assessment = new Assessment();
            assessment.AssessmentID = int.Parse(dataGridView1.SelectedRows[0].Cells["AssessmentID"].Value.ToString());
            assessment.AssessmentStatus = cmbSubmitStatus.Text;
            assessment.DueDate = dtaRescheduled.Value.ToShortDateString();
            int x = bll.AddAssessmentSubmission(assessment);
            if (x < 0)
            {
                MessageBox.Show("Assessment was successfully Submitted");
                dataGridView1.DataSource = bll.GetAssessments();
            }
            else
            {
                MessageBox.Show("Your submission was Unsuccessfull ");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string jobId = dataGridView1.SelectedRows[0].Cells["AssessmentID"].Value + string.Empty;
            lblAssessID.Text = jobId;
            lblMod.Text = dataGridView1.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString();
            lblAssessDesc.Text = dataGridView1.SelectedRows[0].Cells["AssessmentDescription"].Value.ToString();
            lblDa.Text = dataGridView1.SelectedRows[0].Cells["DueDate"].Value.ToString();
            lblAssessType.Text = dataGridView1.SelectedRows[0].Cells["AssessmentTypeID"].Value.ToString();
            lblStatus.Text = dataGridView1.SelectedRows[0].Cells["AssessmentStatus"].Value.ToString();
        }
    }
}
