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
    public partial class AssessmentReport : Form
    {
        public AssessmentReport()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dal = new DataAccessLayer();
        private void AssessmentReport_Load(object sender, EventArgs e)
        {
            cmbAssessmentType.DataSource = bll.GetAssessmentType();
            cmbAssessmentType.ValueMember = "AssessmentTypeID";
            cmbAssessmentType.DisplayMember = "AssessmentTypeDescription";

            cmbAssessmentStatus.Items.Add("Completed");
            cmbAssessmentStatus.Items.Add("Missed");
            cmbAssessmentStatus.Items.Add("Not Yet Due");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Searching for Assessment Type
            int AssessmentID;
            Int32.TryParse(cmbAssessmentType.SelectedValue.ToString(), out AssessmentID);
            dataGridView1.DataSource = bll.GetAssessmentByType(AssessmentID);


            //Searching for Assessment Description
            if (string.IsNullOrEmpty(txtAssessmentDescription.Text))
            {
                errorAssessmentDescription.SetError(txtAssessmentDescription, "Please do not leave field empty.");
            }
            else
            {
                int search;
                Int32.TryParse(txtAssessmentDescription.Text, out search);
                dataGridView1.DataSource = bll.GetAssessmentByID(search, txtAssessmentDescription.Text);
            }
        }
    }
}
