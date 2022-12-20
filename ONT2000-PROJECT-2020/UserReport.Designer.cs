
namespace ONT2000_PROJECT_2020
{
    partial class UserReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchByType = new System.Windows.Forms.Button();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.txtUsersName = new System.Windows.Forms.TextBox();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.dgvDisplayUsers = new System.Windows.Forms.DataGridView();
            this.errorSearchByUserDetails = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSearchByUserDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search By User Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search By User ID:";
            // 
            // btnSearchByType
            // 
            this.btnSearchByType.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSearchByType.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByType.Location = new System.Drawing.Point(626, 44);
            this.btnSearchByType.Name = "btnSearchByType";
            this.btnSearchByType.Size = new System.Drawing.Size(124, 55);
            this.btnSearchByType.TabIndex = 6;
            this.btnSearchByType.Text = "Search By Type";
            this.btnSearchByType.UseVisualStyleBackColor = false;
            this.btnSearchByType.Click += new System.EventHandler(this.btnSearchByType_Click);
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSearchByID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByID.Location = new System.Drawing.Point(783, 44);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(124, 55);
            this.btnSearchByID.TabIndex = 7;
            this.btnSearchByID.Text = "Search By ID";
            this.btnSearchByID.UseVisualStyleBackColor = false;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // txtUsersName
            // 
            this.txtUsersName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsersName.Location = new System.Drawing.Point(306, 96);
            this.txtUsersName.Name = "txtUsersName";
            this.txtUsersName.Size = new System.Drawing.Size(281, 26);
            this.txtUsersName.TabIndex = 8;
            // 
            // cmbUserType
            // 
            this.cmbUserType.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Location = new System.Drawing.Point(304, 36);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(283, 27);
            this.cmbUserType.TabIndex = 9;
            // 
            // dgvDisplayUsers
            // 
            this.dgvDisplayUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayUsers.Location = new System.Drawing.Point(40, 158);
            this.dgvDisplayUsers.Name = "dgvDisplayUsers";
            this.dgvDisplayUsers.Size = new System.Drawing.Size(939, 226);
            this.dgvDisplayUsers.TabIndex = 10;
            // 
            // errorSearchByUserDetails
            // 
            this.errorSearchByUserDetails.ContainerControl = this;
            // 
            // UserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ONT2000_PROJECT_2020.Properties.Resources.coding;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 409);
            this.Controls.Add(this.dgvDisplayUsers);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.txtUsersName);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.btnSearchByType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserReport";
            this.Text = "UserReport";
            this.Load += new System.EventHandler(this.UserReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSearchByUserDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchByType;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.TextBox txtUsersName;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.DataGridView dgvDisplayUsers;
        private System.Windows.Forms.ErrorProvider errorSearchByUserDetails;
    }
}