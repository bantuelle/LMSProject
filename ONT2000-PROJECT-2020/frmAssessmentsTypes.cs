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
    public partial class frmAssessmentsTypes : Form
    {
        public frmAssessmentsTypes()
        {
            InitializeComponent();
        }
		BusinessLogicLayer bll = new BusinessLogicLayer();
		DataAccessLayer dal = new DataAccessLayer();
		private void btnAdd_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(txtTypeDesc.Text))
			{
				errorAssessmentTypeDescription.SetError(txtTypeDesc, "Please do not leave field empty.");
			}
			else
			{
				AssessmentsType assessmentType = new AssessmentsType();
				assessmentType.AssessmentTypeDescription = txtTypeDesc.Text;
				int x = bll.AddAssessmentType(assessmentType);
				if (x < 0)
				{
					MessageBox.Show("Successfully added");
					dgvDisplay.DataSource = bll.GetAssessmentType();
				}
				else
				{
					MessageBox.Show("UnSuccessfull");
				}
			}
		}

        private void btnList_Click(object sender, EventArgs e)
        {
			dgvDisplay.DataSource = bll.GetAssessmentType();
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			AssessmentsType AssessType = new AssessmentsType();
			AssessType.AssessmentTypeID = int.Parse(dgvDisplay.SelectedRows[0].Cells["AssessmentTypeID"].Value.ToString());
			bll.DeleteAssessmentType(AssessType.AssessmentTypeID);
			dgvDisplay.DataSource = bll.GetAssessmentType();
		}
    }
}
