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
    public partial class frmManageModules : Form
    {
        public frmManageModules()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();//Done
        DataAccessLayer dal = new DataAccessLayer();
        private void frmManageModules_Load(object sender, EventArgs e)
        {
			cmbDuration.Items.Add("6 months");
			cmbDuration.Items.Add("1 year ");
			cmbDuration.Items.Add("3 year");


			cmbModuleType.DataSource = bll.GetModuleType();
			cmbModuleType.DisplayMember = "ModuleTypeDescription";
			cmbModuleType.ValueMember = "ModuleTypeID";
		}

        private void btnAdd_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(txtModuleName.Text))
			{
				errorModuleName.SetError(txtModuleName, "Please do not leave field empty.");
			}
			else
			{
				Module module = new Module();
				module.ModuleName = txtModuleName.Text;
				module.ModuleDuration = cmbDuration.Text;
				module.ModuleTypeID = Convert.ToInt16(cmbModuleType.SelectedValue.ToString());
				int x = bll.InsertModule(module);
				if (x < 0)
				{
					MessageBox.Show("Module was successfully Added");
					dgvDisplayInfo.DataSource = bll.GetModule();
				}
				else
				{
					MessageBox.Show("Your adding was Unsuccessfull ");
				}
			}
		}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			Module module = new Module();
			module.ModuleName = txtModuleName.Text;
			module.ModuleDuration = cmbDuration.Text;
			module.ModuleTypeID = Convert.ToInt16(cmbModuleType.SelectedValue.ToString());
			if (bll.UpdateModule(module) < 0)
			{
				MessageBox.Show("Updated Successfully");
				dgvDisplayInfo.DataSource = bll.GetModule();
			}
			else
			{
				MessageBox.Show("Update Failed");
			}
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			Module modules = new Module();
			modules.ModuleID = int.Parse(dgvDisplayInfo.SelectedRows[0].Cells["ModuleID"].Value.ToString());
			bll.DeleteModule(modules);
			dgvDisplayInfo.DataSource = bll.GetModule();
		}

        private void btnList_Click(object sender, EventArgs e)
        {
			dgvDisplayInfo.DataSource = bll.GetModule();
		}

        private void dgvDisplayInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			if (dgvDisplayInfo.Rows.Count > 0)
			{
				Module module = new Module();
				txtModuleName.Text = dgvDisplayInfo.SelectedRows[0].Cells[1].Value.ToString();
				cmbDuration.SelectedValue = dgvDisplayInfo.SelectedRows[0].Cells[2].Value.ToString();
				cmbModuleType.SelectedItem = dgvDisplayInfo.SelectedRows[0].Cells[3].Value.ToString();

			}
		}
    }
}
