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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnUserReports_Click(object sender, EventArgs e)
        {
            btnUserReports.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            UserReport users = new UserReport();
            users.TopLevel = false;
            pnlLayout.Controls.Add(users);
            users.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            users.Dock = DockStyle.Fill;
            users.Visible = true;
        }

        private void btnModuleReports_Click(object sender, EventArgs e)
        {
            btnModuleReports.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            ModuleReport modules = new ModuleReport();
            modules.TopLevel = false;
            pnlLayout.Controls.Add(modules);
            modules.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            modules.Dock = DockStyle.Fill;
            modules.Visible = true;
        }

        private void btnAssessmentsReports_Click(object sender, EventArgs e)
        {
            btnAssessmentsReports.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            AssessmentReport assessments = new AssessmentReport();
            assessments.TopLevel = false;
            pnlLayout.Controls.Add(assessments);
            assessments.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            assessments.Dock = DockStyle.Fill;
            assessments.Visible = true;
        }
    }
}
