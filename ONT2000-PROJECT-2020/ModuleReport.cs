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
    public partial class ModuleReport : Form
    {
        public ModuleReport()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void ModuleReport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModuleType.Text))
            {
                errorSearchModuleByType.SetError(txtModuleType, "Please do not leave field empty.");
            }
            else
            {
                dgvModuleDetails.DataSource = bll.GetModuleDetailsBySearching(txtModuleType.Text);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvModuleDetails.DataSource = bll.GetModule();
        }
    }
}
