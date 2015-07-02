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
    public partial class frmBaoCaoTon : Form
    {
        public frmBaoCaoTon()
        {
            InitializeComponent();
        }

        private void frmBaoCaoTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyNhaSachMaintenanceDataSet.BaoCaoTon_SelectThang' table. You can move, or remove it, as needed.
            this.baoCaoTon_SelectThangTableAdapter.Fill(this.QuanLyNhaSachMaintenanceDataSet.BaoCaoTon_SelectThang);
            // TODO: This line of code loads data into the 'QuanLyNhaSachMaintenanceDataSet.BaoCaoTon_SelectAllByThang' table. You can move, or remove it, as needed.
            this.BaoCaoTon_SelectAllByThangTableAdapter.Fill(this.QuanLyNhaSachMaintenanceDataSet.BaoCaoTon_SelectAllByThang);

            this.rpvBCT.RefreshReport();

            Setparameters(cmbThang.Text);
            this.rpvBCT.RefreshReport();
        }

        private void Setparameters(string thang)
        {
            ReportParameter rp = new ReportParameter("Thang");
            rp.Values.Add(thang);
            rpvBCT.LocalReport.SetParameters(rp);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Setparameters(cmbThang.Text);
            this.rpvBCT.RefreshReport();
        }


    }
}
