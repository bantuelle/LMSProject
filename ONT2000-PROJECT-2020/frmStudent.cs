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
    public partial class frmStudent : Form
    {
        public frmStudent(string reference)
        {
            InitializeComponent();
            llacc.Text = reference;
        }
        public frmStudent()
        {
            InitializeComponent();

        }

        private void btnSearchAssess_Click(object sender, EventArgs e)
        {
            btnSearchAssess.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmSearchAssessments assess = new frmSearchAssessments();
            assess.TopLevel = false;
            pnlLayout.Controls.Add(assess);
            assess.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            assess.Dock = DockStyle.Fill;
            assess.Visible = true;
        }

        private void btnSubmissionAssess_Click(object sender, EventArgs e)
        {
            btnSubmissionAssess.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmSubmissionAssessments frmSubmission = new frmSubmissionAssessments();
            frmSubmission.TopLevel = false;
            pnlLayout.Controls.Add(frmSubmission);
            frmSubmission.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmSubmission.Dock = DockStyle.Fill;
            frmSubmission.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmMyModules modules = new frmMyModules();
            modules.TopLevel = false;
            pnlLayout.Controls.Add(modules);
            modules.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            modules.Dock = DockStyle.Fill;
            modules.Visible = true;
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
