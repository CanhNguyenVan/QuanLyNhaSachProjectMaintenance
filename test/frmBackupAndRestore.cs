using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace test
{
    public partial class frmBackupAndRestore : Form
    {
        BackupAndRestoreBLL backupAndRestoreBll = new BackupAndRestoreBLL();
        public frmBackupAndRestore()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdg = new SaveFileDialog();
            if (sdg.ShowDialog() == DialogResult.OK)
            {
                backupAndRestoreBll.Backup(sdg.FileName);
            }
            if (backupAndRestoreBll.Backup(sdg.FileName) > 0)
            {
                MessageBox.Show("Backup thành công.");
            }
        }

        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Chọn đường dẫn file cần restore.");
                return;
            }
            if (backupAndRestoreBll.Restore(txtPath.Text) > 0)
            {
                MessageBox.Show("Restore thành công.");
            }
        }
    }
}
