
namespace ONT2000_PROJECT_2020
{
    partial class DashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLayout = new System.Windows.Forms.Panel();
            this.llacc = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManageModule = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnLecMod = new System.Windows.Forms.Button();
            this.btnStudMod = new System.Windows.Forms.Button();
            this.btnModuleType = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnModuleType);
            this.panel1.Controls.Add(this.btnStudMod);
            this.panel1.Controls.Add(this.btnLecMod);
            this.panel1.Controls.Add(this.btnManageUsers);
            this.panel1.Controls.Add(this.btnManageModule);
            this.panel1.Location = new System.Drawing.Point(2, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 533);
            this.panel1.TabIndex = 0;
            // 
            // pnlLayout
            // 
            this.pnlLayout.Location = new System.Drawing.Point(217, 119);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(1016, 533);
            this.pnlLayout.TabIndex = 1;
            // 
            // llacc
            // 
            this.llacc.AutoSize = true;
            this.llacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llacc.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.llacc.Location = new System.Drawing.Point(865, 89);
            this.llacc.Name = "llacc";
            this.llacc.Size = new System.Drawing.Size(0, 24);
            this.llacc.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ONT2000_PROJECT_2020.Properties.Resources.thumbnail_image001;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1231, 112);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnManageModule
            // 
            this.btnManageModule.BackColor = System.Drawing.Color.PowderBlue;
            this.btnManageModule.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageModule.Location = new System.Drawing.Point(3, 0);
            this.btnManageModule.Name = "btnManageModule";
            this.btnManageModule.Size = new System.Drawing.Size(203, 61);
            this.btnManageModule.TabIndex = 0;
            this.btnManageModule.Text = "Manage Modules";
            this.btnManageModule.UseVisualStyleBackColor = false;
            this.btnManageModule.Click += new System.EventHandler(this.btnManageModule_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.PowderBlue;
            this.btnManageUsers.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnManageUsers.Location = new System.Drawing.Point(3, 79);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(203, 61);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLecMod
            // 
            this.btnLecMod.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLecMod.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnLecMod.Location = new System.Drawing.Point(3, 156);
            this.btnLecMod.Name = "btnLecMod";
            this.btnLecMod.Size = new System.Drawing.Size(203, 59);
            this.btnLecMod.TabIndex = 2;
            this.btnLecMod.Text = "Assign Lecturers to Modules";
            this.btnLecMod.UseVisualStyleBackColor = false;
            this.btnLecMod.Click += new System.EventHandler(this.btnLecMod_Click);
            // 
            // btnStudMod
            // 
            this.btnStudMod.BackColor = System.Drawing.Color.PowderBlue;
            this.btnStudMod.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudMod.Location = new System.Drawing.Point(3, 233);
            this.btnStudMod.Name = "btnStudMod";
            this.btnStudMod.Size = new System.Drawing.Size(203, 60);
            this.btnStudMod.TabIndex = 3;
            this.btnStudMod.Text = "Assign Student to Modules";
            this.btnStudMod.UseVisualStyleBackColor = false;
            this.btnStudMod.Click += new System.EventHandler(this.btnStudMod_Click);
            // 
            // btnModuleType
            // 
            this.btnModuleType.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModuleType.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleType.Location = new System.Drawing.Point(3, 311);
            this.btnModuleType.Name = "btnModuleType";
            this.btnModuleType.Size = new System.Drawing.Size(203, 62);
            this.btnModuleType.TabIndex = 4;
            this.btnModuleType.Text = "Manage Module Type";
            this.btnModuleType.UseVisualStyleBackColor = false;
            this.btnModuleType.Click += new System.EventHandler(this.btnModuleType_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.PowderBlue;
            this.btnReports.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(6, 395);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(203, 56);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogOut.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnLogOut.Location = new System.Drawing.Point(3, 475);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(203, 55);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button8_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1236, 656);
            this.Controls.Add(this.llacc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlLayout);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLayout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llacc;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnModuleType;
        private System.Windows.Forms.Button btnStudMod;
        private System.Windows.Forms.Button btnLecMod;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageModule;
    }
}