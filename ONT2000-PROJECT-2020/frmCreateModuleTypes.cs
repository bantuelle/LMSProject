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
using DAL;
using BLL;

namespace ONT2000_PROJECT_2020
{
    public partial class frmCreateModuleTypes : Form
    {
        public frmCreateModuleTypes()
        {
            InitializeComponent();
        }
        DataAccessLayer dal = new DataAccessLayer();
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void frmCreateModuleTypes_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ModuleType moduleType = new ModuleType();
            moduleType.ModuleTypeID = int.Parse(dgvDisplay.SelectedRows[0].Cells["ModuleTypeID"].Value.ToString());
            bll.DeleteModuleType(moduleType);
            dgvDisplay.DataSource = bll.GetModuleType();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTypeDesc.Text))
            {
                errorModuleTypeDescription.SetError(txtTypeDesc, "Please do not leave field empty.");
            }
            else
            {
                ModuleType moduleType = new ModuleType();
                moduleType.ModuleTypeDescription = txtTypeDesc.Text;
                int x = bll.AddModuleType(moduleType);
                if (x < 0)
                {
                    MessageBox.Show("Module Type was Added");
                    dgvDisplay.DataSource = bll.GetModuleType();
                }
                else
                {
                    MessageBox.Show("Module Type was not Added");
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.GetModuleType();
        }
    }
}
