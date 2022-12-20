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

namespace ONT2000_PROJECT_2020
{
    public partial class frmLecturer : Form
    {
        public frmLecturer(string reference)
        {
            InitializeComponent();
            llacc.Text = reference;
        }
        public frmLecturer()
        {
            InitializeComponent();
        }

        private void btnCreateAssessments_Click(object sender, EventArgs e)
        {
            btnCreateAssessments.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmAssessments assess = new frmAssessments();
            assess.TopLevel = false;
            pnlLayout.Controls.Add(assess);
            assess.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            assess.Dock = DockStyle.Fill;
            assess.Visible = true;
        }

        private void btnAssessmentType_Click(object sender, EventArgs e)
        {
            btnAssessmentType.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmAssessmentsTypes assessmentsTypes = new frmAssessmentsTypes();
            assessmentsTypes.TopLevel = false;
            pnlLayout.Controls.Add(assessmentsTypes);
            assessmentsTypes.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            assessmentsTypes.Dock = DockStyle.Fill;
            assessmentsTypes.Visible = true;
        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            btnStudentReport.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmStudentReports students = new frmStudentReports();
            students.TopLevel = false;
            pnlLayout.Controls.Add(students);
            students.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            students.Dock = DockStyle.Fill;
            students.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmSignIn.dtlog = null;
            frmSignIn log = new frmSignIn();
            log.Show();
            this.Hide();
        }
    }
}
