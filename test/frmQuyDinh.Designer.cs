namespace test
{
    partial class frmQuyDinh
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
            this.btn_TDQD = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TonToiThieuSauBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_TienNoToiDa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TonToiDaTruocKhiNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SLNhapItNhat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.check_SuDungQD4 = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_SuDungQD4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TDQD
            // 
            this.btn_TDQD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_TDQD.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_TDQD.Location = new System.Drawing.Point(206, 284);
            this.btn_TDQD.Name = "btn_TDQD";
            this.btn_TDQD.Size = new System.Drawing.Size(75, 23);
            this.btn_TDQD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_TDQD.TabIndex = 7;
            this.btn_TDQD.Text = "Thay đổi";
            this.btn_TDQD.Click += new System.EventHandler(this.btn_TDQD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TonToiThieuSauBan);
            this.groupBox2.Controls.Add(this.txt_TienNoToiDa);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 96);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quy Định 2";
            // 
            // txt_TonToiThieuSauBan
            // 
            // 
            // 
            // 
            this.txt_TonToiThieuSauBan.Border.Class = "TextBoxBorder";
            this.txt_TonToiThieuSauBan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TonToiThieuSauBan.Location = new System.Drawing.Point(194, 64);
            this.txt_TonToiThieuSauBan.Name = "txt_TonToiThieuSauBan";
            this.txt_TonToiThieuSauBan.Size = new System.Drawing.Size(279, 20);
            this.txt_TonToiThieuSauBan.TabIndex = 3;
            this.txt_TonToiThieuSauBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_TienNoToiDa
            // 
            // 
            // 
            // 
            this.txt_TienNoToiDa.Border.Class = "TextBoxBorder";
            this.txt_TienNoToiDa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TienNoToiDa.Location = new System.Drawing.Point(194, 22);
            this.txt_TienNoToiDa.Name = "txt_TienNoToiDa";
            this.txt_TienNoToiDa.Size = new System.Drawing.Size(279, 20);
            this.txt_TienNoToiDa.TabIndex = 2;
            this.txt_TienNoToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TienNoToiDa_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 66);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(153, 13);
            this.label30.TabIndex = 1;
            this.label30.Text = "Lượng tồn tối thiểu sau khi bán";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 26);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(73, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "Tiền nợ tối đa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_SuDungQD4);
            this.groupBox3.Location = new System.Drawing.Point(12, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 49);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quy Định 4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TonToiDaTruocKhiNhap);
            this.groupBox1.Controls.Add(this.txt_SLNhapItNhat);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quy Định 1";
            // 
            // txt_TonToiDaTruocKhiNhap
            // 
            // 
            // 
            // 
            this.txt_TonToiDaTruocKhiNhap.Border.Class = "TextBoxBorder";
            this.txt_TonToiDaTruocKhiNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TonToiDaTruocKhiNhap.Location = new System.Drawing.Point(194, 73);
            this.txt_TonToiDaTruocKhiNhap.Name = "txt_TonToiDaTruocKhiNhap";
            this.txt_TonToiDaTruocKhiNhap.Size = new System.Drawing.Size(279, 20);
            this.txt_TonToiDaTruocKhiNhap.TabIndex = 3;
            this.txt_TonToiDaTruocKhiNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_SLNhapItNhat
            // 
            // 
            // 
            // 
            this.txt_SLNhapItNhat.Border.Class = "TextBoxBorder";
            this.txt_SLNhapItNhat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SLNhapItNhat.Location = new System.Drawing.Point(194, 30);
            this.txt_SLNhapItNhat.Name = "txt_SLNhapItNhat";
            this.txt_SLNhapItNhat.Size = new System.Drawing.Size(279, 20);
            this.txt_SLNhapItNhat.TabIndex = 2;
            this.txt_SLNhapItNhat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 75);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(156, 13);
            this.label32.TabIndex = 1;
            this.label32.Text = "Lượng tồn tối đa trước khi nhập";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 32);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(110, 13);
            this.label33.TabIndex = 0;
            this.label33.Text = "Số lượng nhập ít nhất";
            // 
            // check_SuDungQD4
            // 
            this.check_SuDungQD4.Location = new System.Drawing.Point(29, 19);
            this.check_SuDungQD4.Name = "check_SuDungQD4";
            this.check_SuDungQD4.Properties.Caption = "Sử dụng quy định số tiền thu không vượt quá số tiền khách đang nợ";
            this.check_SuDungQD4.Size = new System.Drawing.Size(417, 19);
            this.check_SuDungQD4.TabIndex = 0;
            // 
            // frmQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 314);
            this.Controls.Add(this.btn_TDQD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuyDinh";
            this.Text = "Quy Định";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_SuDungQD4.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_TDQD;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TonToiThieuSauBan;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TienNoToiDa;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TonToiDaTruocKhiNhap;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SLNhapItNhat;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private DevExpress.XtraEditors.CheckEdit check_SuDungQD4;
    }
}