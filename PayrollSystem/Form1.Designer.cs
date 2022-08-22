namespace PayrollSytem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsPayroll = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsReport = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.AdminName = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEmployee,
            this.tsPayroll,
            this.tsUser,
            this.tsReport,
            this.tsLogin,
            this.AdminName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(133, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(160, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(160, 622);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsEmployee
            // 
            this.tsEmployee.AutoSize = false;
            this.tsEmployee.Enabled = false;
            this.tsEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsEmployee.Image")));
            this.tsEmployee.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEmployee.Name = "tsEmployee";
            this.tsEmployee.Size = new System.Drawing.Size(110, 80);
            this.tsEmployee.Text = "Employees";
            this.tsEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEmployee.Click += new System.EventHandler(this.tsEmployee_Click);
            // 
            // tsPayroll
            // 
            this.tsPayroll.AutoSize = false;
            this.tsPayroll.Enabled = false;
            this.tsPayroll.Image = ((System.Drawing.Image)(resources.GetObject("tsPayroll.Image")));
            this.tsPayroll.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsPayroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPayroll.Name = "tsPayroll";
            this.tsPayroll.Size = new System.Drawing.Size(110, 80);
            this.tsPayroll.Text = "Payroll";
            this.tsPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPayroll.Click += new System.EventHandler(this.tsPayroll_Click);
            // 
            // tsUser
            // 
            this.tsUser.AutoSize = false;
            this.tsUser.Enabled = false;
            this.tsUser.Image = ((System.Drawing.Image)(resources.GetObject("tsUser.Image")));
            this.tsUser.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(110, 80);
            this.tsUser.Text = "Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsReport
            // 
            this.tsReport.AutoSize = false;
            this.tsReport.Enabled = false;
            this.tsReport.Image = ((System.Drawing.Image)(resources.GetObject("tsReport.Image")));
            this.tsReport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(110, 80);
            this.tsReport.Text = "Reports";
            this.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReport.Click += new System.EventHandler(this.tsReport_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.AutoSize = false;
            this.tsLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsLogin.Image")));
            this.tsLogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(110, 80);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // AdminName
            // 
            this.AdminName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AdminName.AutoSize = false;
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(108, 15);
            this.AdminName.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(982, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Done by:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1140, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Abid Khan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1140, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ghouse";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1140, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ganesh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 622);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll System - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsEmployee;
        private System.Windows.Forms.ToolStripButton tsPayroll;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsReport;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel AdminName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

