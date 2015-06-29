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
            // TODO: This line of code loads data into the 'quanLyNhaSachDataSet.BaoCaoCongNo_SelectAllByThang' table. You can move, or remove it, as needed.
            this.BaoCaoCongNo_SelectAllByThangTableAdapter.Fill(this.quanLyNhaSachDataSet.BaoCaoCongNo_SelectAllByThang);
            // TODO: This line of code loads data into the 'quanLyNhaSachDataSet.BaoCaoCongNo_SelectThang' table. You can move, or remove it, as needed.
            this.baoCaoCongNo_SelectThangTableAdapter.Fill(this.quanLyNhaSachDataSet.BaoCaoCongNo_SelectThang);

            this.reportViewerBCCN.RefreshReport();
            this.reportViewerBCCN.RefreshReport();
            SetParameters(cbThang.Text);
            this.reportViewerBCCN.RefreshReport();
        }

        private void SetParameters(string thang)
        {
            ReportParameter rp = new ReportParameter("Thang");
            rp.Values.Add(thang);
            this.reportViewerBCCN.LocalReport.SetParameters(rp);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SetParameters(cbThang.Text);
            this.reportViewerBCCN.RefreshReport();
        }
    }
}
