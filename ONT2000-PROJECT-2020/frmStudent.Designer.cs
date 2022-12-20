
namespace ONT2000_PROJECT_2020
{
    partial class frmStudent
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
            this.btnSearchAssess = new System.Windows.Forms.Button();
            this.btnSubmissionAssess = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ONT2000_PROJECT_2020.Properties.Resources.thumbnail_image001;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1252, 112);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSubmissionAssess);
            this.panel1.Controls.Add(this.btnSearchAssess);
            this.panel1.Location = new System.Drawing.Point(1, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 516);
            this.panel1.TabIndex = 5;
            // 
            // pnlLayout
            // 
            this.pnlLayout.Location = new System.Drawing.Point(225, 110);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(1028, 516);
            this.pnlLayout.TabIndex = 6;
            // 
            // llacc
            // 
            this.llacc.AutoSize = true;
            this.llacc.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llacc.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.llacc.Location = new System.Drawing.Point(841, 86);
            this.llacc.Name = "llacc";
            this.llacc.Size = new System.Drawing.Size(270, 21);
            this.llacc.TabIndex = 8;
            this.llacc.TabStop = true;
            this.llacc.Text = "__________________________";
            // 
            // btnSearchAssess
            // 
            this.btnSearchAssess.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSearchAssess.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAssess.Location = new System.Drawing.Point(3, 21);
            this.btnSearchAssess.Name = "btnSearchAssess";
            this.btnSearchAssess.Size = new System.Drawing.Size(212, 71);
            this.btnSearchAssess.TabIndex = 0;
            this.btnSearchAssess.Text = "Search My Assessments";
            this.btnSearchAssess.UseVisualStyleBackColor = false;
            this.btnSearchAssess.Click += new System.EventHandler(this.btnSearchAssess_Click);
            // 
            // btnSubmissionAssess
            // 
            this.btnSubmissionAssess.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSubmissionAssess.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmissionAssess.Location = new System.Drawing.Point(6, 134);
            this.btnSubmissionAssess.Name = "btnSubmissionAssess";
            this.btnSubmissionAssess.Size = new System.Drawing.Size(212, 71);
            this.btnSubmissionAssess.TabIndex = 1;
            this.btnSubmissionAssess.Text = "Submit Assessments";
            this.btnSubmissionAssess.UseVisualStyleBackColor = false;
            this.btnSubmissionAssess.Click += new System.EventHandler(this.btnSubmissionAssess_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogout.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(6, 424);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(212, 71);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "My Modules";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1253, 628);
            this.Controls.Add(this.llacc);
            this.Controls.Add(this.pnlLayout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSubmissionAssess;
        private System.Windows.Forms.Button btnSearchAssess;
    }
}