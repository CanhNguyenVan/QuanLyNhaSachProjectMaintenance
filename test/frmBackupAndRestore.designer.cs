namespace test
{
    partial class frmBackupAndRestore
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
            this.grbBackup = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbRestore = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.grbBackup.SuspendLayout();
            this.grbRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBackup
            // 
            this.grbBackup.Controls.Add(this.btnBackup);
            this.grbBackup.Controls.Add(this.txtLocation);
            this.grbBackup.Controls.Add(this.label1);
            this.grbBackup.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBackup.Location = new System.Drawing.Point(12, 12);
            this.grbBackup.Name = "grbBackup";
            this.grbBackup.Size = new System.Drawing.Size(591, 110);
            this.grbBackup.TabIndex = 0;
            this.grbBackup.TabStop = false;
            this.grbBackup.Text = "Backup";
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(475, 47);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(85, 29);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(120, 47);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(318, 27);
            this.txtLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location :";
            // 
            // grbRestore
            // 
            this.grbRestore.Controls.Add(this.btnRestore);
            this.grbRestore.Controls.Add(this.btnBrowsePath);
            this.grbRestore.Controls.Add(this.txtPath);
            this.grbRestore.Controls.Add(this.lblPath);
            this.grbRestore.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRestore.Location = new System.Drawing.Point(12, 139);
            this.grbRestore.Name = "grbRestore";
            this.grbRestore.Size = new System.Drawing.Size(591, 106);
            this.grbRestore.TabIndex = 1;
            this.grbRestore.TabStop = false;
            this.grbRestore.Text = "Restore";
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(475, 73);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(85, 29);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePath.Location = new System.Drawing.Point(475, 17);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(85, 29);
            this.btnBrowsePath.TabIndex = 6;
            this.btnBrowsePath.Text = "Browse";
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            this.btnBrowsePath.Click += new System.EventHandler(this.btnBrowsePath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(117, 44);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(318, 27);
            this.txtPath.TabIndex = 5;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(30, 47);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(51, 20);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Path :";
            // 
            // frmBackupAndRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 250);
            this.Controls.Add(this.grbRestore);
            this.Controls.Add(this.grbBackup);
            this.Name = "frmBackupAndRestore";
            this.Text = "frmBackupAndRestore";
            this.grbBackup.ResumeLayout(false);
            this.grbBackup.PerformLayout();
            this.grbRestore.ResumeLayout(false);
            this.grbRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBackup;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBrowsePath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
    }
}