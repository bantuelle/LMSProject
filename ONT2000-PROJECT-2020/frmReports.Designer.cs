
namespace ONT2000_PROJECT_2020
{
    partial class frmReports
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserReports = new System.Windows.Forms.Button();
            this.btnAssessmentsReports = new System.Windows.Forms.Button();
            this.btnModuleReports = new System.Windows.Forms.Button();
            this.pnlLayout = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // btnUserReports
            // 
            this.btnUserReports.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUserReports.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserReports.Location = new System.Drawing.Point(174, 62);
            this.btnUserReports.Name = "btnUserReports";
            this.btnUserReports.Size = new System.Drawing.Size(169, 44);
            this.btnUserReports.TabIndex = 1;
            this.btnUserReports.Text = "User Reports";
            this.btnUserReports.UseVisualStyleBackColor = false;
            this.btnUserReports.Click += new System.EventHandler(this.btnUserReports_Click);
            // 
            // btnAssessmentsReports
            // 
            this.btnAssessmentsReports.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAssessmentsReports.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssessmentsReports.Location = new System.Drawing.Point(673, 63);
            this.btnAssessmentsReports.Name = "btnAssessmentsReports";
            this.btnAssessmentsReports.Size = new System.Drawing.Size(169, 44);
            this.btnAssessmentsReports.TabIndex = 2;
            this.btnAssessmentsReports.Text = "Assessment Reports";
            this.btnAssessmentsReports.UseVisualStyleBackColor = false;
            this.btnAssessmentsReports.Click += new System.EventHandler(this.btnAssessmentsReports_Click);
            // 
            // btnModuleReports
            // 
            this.btnModuleReports.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModuleReports.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleReports.Location = new System.Drawing.Point(404, 63);
            this.btnModuleReports.Name = "btnModuleReports";
            this.btnModuleReports.Size = new System.Drawing.Size(169, 44);
            this.btnModuleReports.TabIndex = 3;
            this.btnModuleReports.Text = "Module Reports";
            this.btnModuleReports.UseVisualStyleBackColor = false;
            this.btnModuleReports.Click += new System.EventHandler(this.btnModuleReports_Click);
            // 
            // pnlLayout
            // 
            this.pnlLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.pnlLayout.Location = new System.Drawing.Point(13, 112);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(991, 409);
            this.pnlLayout.TabIndex = 4;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ONT2000_PROJECT_2020.Properties.Resources.coding;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 533);
            this.Controls.Add(this.pnlLayout);
            this.Controls.Add(this.btnModuleReports);
            this.Controls.Add(this.btnAssessmentsReports);
            this.Controls.Add(this.btnUserReports);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserReports;
        private System.Windows.Forms.Button btnAssessmentsReports;
        private System.Windows.Forms.Button btnModuleReports;
        private System.Windows.Forms.Panel pnlLayout;
    }
}