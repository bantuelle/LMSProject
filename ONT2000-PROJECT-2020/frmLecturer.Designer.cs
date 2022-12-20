
namespace ONT2000_PROJECT_2020
{
    partial class frmLecturer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLayout = new System.Windows.Forms.Panel();
            this.llacc = new System.Windows.Forms.LinkLabel();
            this.btnCreateAssessments = new System.Windows.Forms.Button();
            this.btnAssessmentType = new System.Windows.Forms.Button();
            this.btnStudentReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ONT2000_PROJECT_2020.Properties.Resources.thumbnail_image001;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1256, 112);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnStudentReport);
            this.panel1.Controls.Add(this.btnAssessmentType);
            this.panel1.Controls.Add(this.btnCreateAssessments);
            this.panel1.Location = new System.Drawing.Point(3, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 545);
            this.panel1.TabIndex = 5;
            // 
            // pnlLayout
            // 
            this.pnlLayout.Location = new System.Drawing.Point(220, 117);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(1039, 545);
            this.pnlLayout.TabIndex = 6;
            // 
            // llacc
            // 
            this.llacc.AutoSize = true;
            this.llacc.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llacc.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.llacc.Location = new System.Drawing.Point(933, 90);
            this.llacc.Name = "llacc";
            this.llacc.Size = new System.Drawing.Size(270, 21);
            this.llacc.TabIndex = 7;
            this.llacc.TabStop = true;
            this.llacc.Text = "__________________________";
            // 
            // btnCreateAssessments
            // 
            this.btnCreateAssessments.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCreateAssessments.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAssessments.Location = new System.Drawing.Point(3, 3);
            this.btnCreateAssessments.Name = "btnCreateAssessments";
            this.btnCreateAssessments.Size = new System.Drawing.Size(208, 67);
            this.btnCreateAssessments.TabIndex = 0;
            this.btnCreateAssessments.Text = "Create Assessments";
            this.btnCreateAssessments.UseVisualStyleBackColor = false;
            this.btnCreateAssessments.Click += new System.EventHandler(this.btnCreateAssessments_Click);
            // 
            // btnAssessmentType
            // 
            this.btnAssessmentType.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAssessmentType.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssessmentType.Location = new System.Drawing.Point(3, 159);
            this.btnAssessmentType.Name = "btnAssessmentType";
            this.btnAssessmentType.Size = new System.Drawing.Size(208, 67);
            this.btnAssessmentType.TabIndex = 1;
            this.btnAssessmentType.Text = "Create Assessments Type\r\n";
            this.btnAssessmentType.UseVisualStyleBackColor = false;
            this.btnAssessmentType.Click += new System.EventHandler(this.btnAssessmentType_Click);
            // 
            // btnStudentReport
            // 
            this.btnStudentReport.BackColor = System.Drawing.Color.PowderBlue;
            this.btnStudentReport.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentReport.Location = new System.Drawing.Point(6, 307);
            this.btnStudentReport.Name = "btnStudentReport";
            this.btnStudentReport.Size = new System.Drawing.Size(205, 67);
            this.btnStudentReport.TabIndex = 2;
            this.btnStudentReport.Text = "Student Report";
            this.btnStudentReport.UseVisualStyleBackColor = false;
            this.btnStudentReport.Click += new System.EventHandler(this.btnStudentReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogout.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(3, 470);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(198, 67);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1259, 666);
            this.Controls.Add(this.llacc);
            this.Controls.Add(this.pnlLayout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLecturer";
            this.Text = "frmLecturer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLayout;
        private System.Windows.Forms.LinkLabel llacc;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStudentReport;
        private System.Windows.Forms.Button btnAssessmentType;
        private System.Windows.Forms.Button btnCreateAssessments;
    }
}