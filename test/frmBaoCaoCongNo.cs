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

        private void frmBaoCaoCongNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhaSachMaintenanceDataSet.BaoCaoCongNo_SelectAllByThang' table. You can move, or remove it, as needed.
            this.BaoCaoCongNo_SelectAllByThangTableAdapter.Fill(this.quanLyNhaSachMaintenanceDataSet.BaoCaoCongNo_SelectAllByThang);
            // TODO: This line of code loads data into the 'quanLyNhaSachMaintenanceDataSet.BaoCaoCongNo_SelectThang' table. You can move, or remove it, as needed.
            this.baoCaoCongNo_SelectThangTableAdapter.Fill(this.quanLyNhaSachMaintenanceDataSet.BaoCaoCongNo_SelectThang);

            this.rpvBCCN.RefreshReport();

            Setparameters(cmbThang.Text);
            this.rpvBCCN.RefreshReport();
        }

        private void Setparameters(string thang)
        {
            ReportParameter rp = new ReportParameter("Thang");
            rp.Values.Add(thang);
            rpvBCCN.LocalReport.SetParameters(rp);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Setparameters(cmbThang.Text);
            this.rpvBCCN.RefreshReport();
        }
    }
}
