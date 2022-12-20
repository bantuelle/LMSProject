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
    public partial class DashBoard : Form
    {
        public DashBoard(string reference)
        {
            InitializeComponent();
            llacc.Text = reference;
        }
        public DashBoard() { InitializeComponent(); }

        private void btnManageModule_Click(object sender, EventArgs e)
        {
            btnManageModule.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmManageModules modules = new frmManageModules();
            modules.TopLevel = false;
            pnlLayout.Controls.Add(modules);
            modules.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            modules.Dock = DockStyle.Fill;
            modules.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnManageUsers.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmManageUsers users = new frmManageUsers();
            users.TopLevel = false;
            pnlLayout.Controls.Add(users);
            users.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            users.Dock = DockStyle.Fill;
            users.Visible = true;
        }

        private void btnLecMod_Click(object sender, EventArgs e)
        {
            btnLecMod.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmLecturerModules Lecmodules = new frmLecturerModules();
            Lecmodules.TopLevel = false;
            pnlLayout.Controls.Add(Lecmodules);
            Lecmodules.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Lecmodules.Dock = DockStyle.Fill;
            Lecmodules.Visible = true;
        }

        private void btnStudMod_Click(object sender, EventArgs e)
        {
            btnStudMod.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmStudentModules Studmodules = new frmStudentModules();
            Studmodules.TopLevel = false;
            pnlLayout.Controls.Add(Studmodules);
            Studmodules.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Studmodules.Dock = DockStyle.Fill;
            Studmodules.Visible = true;
        }

        private void btnModuleType_Click(object sender, EventArgs e)
        {
            btnModuleType.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmCreateModuleTypes modules = new frmCreateModuleTypes();
            modules.TopLevel = false;
            pnlLayout.Controls.Add(modules);
            modules.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            modules.Dock = DockStyle.Fill;
            modules.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.Blue;
            pnlLayout.Controls.Clear();
            frmReports Reports = new frmReports();
            Reports.TopLevel = false;
            pnlLayout.Controls.Add(Reports);
            Reports.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Reports.Dock = DockStyle.Fill;
            Reports.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmSignIn.dtlog = null;
            frmSignIn log = new frmSignIn();
            log.Show();
            this.Hide();
        }
    }
}
