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
    public partial class frmSearchAssessments : Form
    {
        public frmSearchAssessments()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void button1_Click(object sender, EventArgs e)
        {
            dgvSearchingResults.DataSource = bll.GetAssessmentByType(Convert.ToInt16(cmbSearchAssess.SelectedIndex.ToString()));
        }

        private void frmSearchAssessments_Load(object sender, EventArgs e)
        {
            cmbSearchAssess.DataSource = bll.GetAssessmentType();
            cmbSearchAssess.DisplayMember = "AssessmentTypeDescription";
            cmbSearchAssess.ValueMember = "AssessmentTypeID";
        }
    }
}
