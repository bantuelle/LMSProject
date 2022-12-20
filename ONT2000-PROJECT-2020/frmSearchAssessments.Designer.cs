
namespace ONT2000_PROJECT_2020
{
    partial class frmSearchAssessments
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
            this.cmbSearchAssess = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchingResults = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchingResults)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSearchAssess
            // 
            this.cmbSearchAssess.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchAssess.FormattingEnabled = true;
            this.cmbSearchAssess.Location = new System.Drawing.Point(377, 91);
            this.cmbSearchAssess.Name = "cmbSearchAssess";
            this.cmbSearchAssess.Size = new System.Drawing.Size(374, 27);
            this.cmbSearchAssess.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Assessment Type";
            // 
            // dgvSearchingResults
            // 
            this.dgvSearchingResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchingResults.Location = new System.Drawing.Point(45, 189);
            this.dgvSearchingResults.Name = "dgvSearchingResults";
            this.dgvSearchingResults.Size = new System.Drawing.Size(904, 300);
            this.dgvSearchingResults.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(768, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSearchAssessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ONT2000_PROJECT_2020.Properties.Resources.images21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSearchingResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSearchAssess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchAssessments";
            this.Text = "frmSearchAssessments";
            this.Load += new System.EventHandler(this.frmSearchAssessments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchingResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSearchAssess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchingResults;
        private System.Windows.Forms.Button button1;
    }
}