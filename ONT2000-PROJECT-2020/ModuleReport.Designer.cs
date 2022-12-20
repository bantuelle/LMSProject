
namespace ONT2000_PROJECT_2020
{
    partial class ModuleReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dgvModuleDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModuleType = new System.Windows.Forms.TextBox();
            this.errorSearchModuleByType = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSearchModuleByType)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(582, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.PowderBlue;
            this.btnViewAll.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(766, 54);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(120, 55);
            this.btnViewAll.TabIndex = 1;
            this.btnViewAll.Text = "View All Modules";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // dgvModuleDetails
            // 
            this.dgvModuleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuleDetails.Location = new System.Drawing.Point(35, 153);
            this.dgvModuleDetails.Name = "dgvModuleDetails";
            this.dgvModuleDetails.Size = new System.Drawing.Size(912, 224);
            this.dgvModuleDetails.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Module Type:";
            // 
            // txtModuleType
            // 
            this.txtModuleType.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuleType.Location = new System.Drawing.Point(253, 72);
            this.txtModuleType.Name = "txtModuleType";
            this.txtModuleType.Size = new System.Drawing.Size(281, 26);
            this.txtModuleType.TabIndex = 4;
            // 
            // errorSearchModuleByType
            // 
            this.errorSearchModuleByType.ContainerControl = this;
            // 
            // ModuleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 409);
            this.Controls.Add(this.txtModuleType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvModuleDetails);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModuleReport";
            this.Text = "ModuleReport";
            this.Load += new System.EventHandler(this.ModuleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSearchModuleByType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridView dgvModuleDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModuleType;
        private System.Windows.Forms.ErrorProvider errorSearchModuleByType;
    }
}