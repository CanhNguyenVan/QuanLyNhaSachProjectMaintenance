namespace test
{
    partial class FormDangKy
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
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.txt_MK1 = new System.Windows.Forms.TextBox();
            this.txt_MK2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Refresh = new DevComponents.DotNetBar.ButtonX();
            this.btn_DangKy = new DevComponents.DotNetBar.ButtonX();
            this.btn_QuayLai = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDN.Location = new System.Drawing.Point(165, 18);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(238, 26);
            this.txt_TenDN.TabIndex = 0;
            // 
            // txt_MK1
            // 
            this.txt_MK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK1.Location = new System.Drawing.Point(165, 48);
            this.txt_MK1.Name = "txt_MK1";
            this.txt_MK1.Size = new System.Drawing.Size(238, 26);
            this.txt_MK1.TabIndex = 1;
            // 
            // txt_MK2
            // 
            this.txt_MK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK2.Location = new System.Drawing.Point(165, 79);
            this.txt_MK2.Name = "txt_MK2";
            this.txt_MK2.Size = new System.Drawing.Size(238, 26);
            this.txt_MK2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại Mật Khẩu:";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(16, 132);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(102, 31);
            this.btn_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_DangKy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.Location = new System.Drawing.Point(165, 132);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(102, 31);
            this.btn_DangKy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_DangKy.TabIndex = 4;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_QuayLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_QuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.Location = new System.Drawing.Point(301, 132);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(102, 31);
            this.btn_QuayLai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_QuayLai.TabIndex = 5;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 196);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MK2);
            this.Controls.Add(this.txt_MK1);
            this.Controls.Add(this.txt_TenDN);
            this.Name = "FormDangKy";
            this.Text = "Đăng Ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.TextBox txt_MK1;
        private System.Windows.Forms.TextBox txt_MK2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btn_Refresh;
        private DevComponents.DotNetBar.ButtonX btn_DangKy;
        private DevComponents.DotNetBar.ButtonX btn_QuayLai;
    }
}