using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BackupAndRestoreBLL
    {
        DataConnecter conn = new DataConnecter();
        public int Backup(string fileName)
        {
            return conn.Backup(fileName);
        }

        public int Restore(string fileName)
        {
            return conn.Restore(fileName);
        }
    }
}
