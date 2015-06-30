using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace test
{
    public partial class frmBaoCaoCongNo : Form
    {
        public frmBaoCaoCongNo()
        {
            InitializeComponent();
        }

        private void BaoCaoCongNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhaSachMaintenanceDataSet1.BaoCaoTon_SelectAllByThang' table. You can move, or remove it, as needed.
            this.baoCaoTon_SelectAllByThangTableAdapter.Fill(this.quanLyNhaSachMaintenanceDataSet1.BaoCaoTon_SelectAllByThang);
            // TODO: This line of code loads data into the 'quanLyNhaSachMaintenanceDataSet1.BaoCaoTon_SelectThang' table. You can move, or remove it, as needed.
            this.baoCaoTon_SelectThangTableAdapter.Fill(this.quanLyNhaSachMaintenanceDataSet1.BaoCaoTon_SelectThang);
            // TODO: This line of code loads data into the 'quanLyNhaSachMaintenanceDataSet.BaoCaoCongNo_SelectThang' table. You can move, or remove it, as needed.
            this.baoCaoCongNo_SelectThangTableAdapter.Fill(this.quanLyNhaSachMaintenanceDataSet.BaoCaoCongNo_SelectThang);
            // TODO: This line of code loads data into the 'quanLyNhaSachMaintenanceDataSet.BaoCaoCongNo_SelectAllByThang' table. You can move, or remove it, as needed.
            this.baoCaoCongNo_SelectAllByThangTableAdapter.Fill(this.quanLyNhaSachMaintenanceDataSet.BaoCaoCongNo_SelectAllByThang);

            this.rpvBaoCaoCongNo.RefreshReport();
            Setparameters(cbThang.Text);
            this.rpvBaoCaoCongNo.RefreshReport();
        }

        private void Setparameters(string thang)
        {
            ReportParameter rp = new ReportParameter("Thang");
            rp.Values.Add(thang);
            this.rpvBaoCaoCongNo.LocalReport.SetParameters(rp);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Setparameters(cbThang.Text);
            this.rpvBaoCaoCongNo.RefreshReport();
        }


    }
}
