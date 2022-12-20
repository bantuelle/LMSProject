
namespace ONT2000_PROJECT_2020
{
    partial class frmSubmissionAssessments
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.lblAssessID = new System.Windows.Forms.Label();
            this.lblAssessDesc = new System.Windows.Forms.Label();
            this.lblDa = new System.Windows.Forms.Label();
            this.lblAssessType = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbSubmitStatus = new System.Windows.Forms.ComboBox();
            this.dtaRescheduled = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(565, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 484);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(330, 437);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(162, 45);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submission";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assessment ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Module:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assessment Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Due Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PowderBlue;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Assessment Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PowderBlue;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Assessment Status:";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod.Location = new System.Drawing.Point(326, 82);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(76, 19);
            this.lblMod.TabIndex = 10;
            this.lblMod.Text = "[Module]";
            // 
            // lblAssessID
            // 
            this.lblAssessID.AutoSize = true;
            this.lblAssessID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessID.Location = new System.Drawing.Point(326, 35);
            this.lblAssessID.Name = "lblAssessID";
            this.lblAssessID.Size = new System.Drawing.Size(131, 19);
            this.lblAssessID.TabIndex = 11;
            this.lblAssessID.Text = "[Assessment ID] ";
            // 
            // lblAssessDesc
            // 
            this.lblAssessDesc.AutoSize = true;
            this.lblAssessDesc.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessDesc.Location = new System.Drawing.Point(326, 127);
            this.lblAssessDesc.Name = "lblAssessDesc";
            this.lblAssessDesc.Size = new System.Drawing.Size(194, 19);
            this.lblAssessDesc.TabIndex = 12;
            this.lblAssessDesc.Text = "[Assessment Description]";
            // 
            // lblDa
            // 
            this.lblDa.AutoSize = true;
            this.lblDa.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDa.Location = new System.Drawing.Point(326, 183);
            this.lblDa.Name = "lblDa";
            this.lblDa.Size = new System.Drawing.Size(90, 19);
            this.lblDa.TabIndex = 13;
            this.lblDa.Text = "[Due Date]";
            // 
            // lblAssessType
            // 
            this.lblAssessType.AutoSize = true;
            this.lblAssessType.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessType.Location = new System.Drawing.Point(326, 239);
            this.lblAssessType.Name = "lblAssessType";
            this.lblAssessType.Size = new System.Drawing.Size(147, 19);
            this.lblAssessType.TabIndex = 14;
            this.lblAssessType.Text = "[Assessment Type]";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(326, 296);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(154, 19);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "[Assessment Status]";
            // 
            // cmbSubmitStatus
            // 
            this.cmbSubmitStatus.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubmitStatus.FormattingEnabled = true;
            this.cmbSubmitStatus.Location = new System.Drawing.Point(330, 342);
            this.cmbSubmitStatus.Name = "cmbSubmitStatus";
            this.cmbSubmitStatus.Size = new System.Drawing.Size(215, 27);
            this.cmbSubmitStatus.TabIndex = 16;
            // 
            // dtaRescheduled
            // 
            this.dtaRescheduled.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtaRescheduled.Location = new System.Drawing.Point(281, 385);
            this.dtaRescheduled.Name = "dtaRescheduled";
            this.dtaRescheduled.Size = new System.Drawing.Size(264, 26);
            this.dtaRescheduled.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PowderBlue;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Select Due Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PowderBlue;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Select Assessment Status";
            // 
            // frmSubmissionAssessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 516);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtaRescheduled);
            this.Controls.Add(this.cmbSubmitStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAssessType);
            this.Controls.Add(this.lblDa);
            this.Controls.Add(this.lblAssessDesc);
            this.Controls.Add(this.lblAssessID);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubmissionAssessments";
            this.Text = "frmSubmissionAssessments";
            this.Load += new System.EventHandler(this.frmSubmissionAssessments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label lblAssessID;
        private System.Windows.Forms.Label lblAssessDesc;
        private System.Windows.Forms.Label lblDa;
        private System.Windows.Forms.Label lblAssessType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbSubmitStatus;
        private System.Windows.Forms.DateTimePicker dtaRescheduled;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}