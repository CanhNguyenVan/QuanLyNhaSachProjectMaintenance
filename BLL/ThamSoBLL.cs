using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO; 

namespace BLL
{
    public class ThamSoBLL
    {
        private ThamSoDAL thamSoDAL = new ThamSoDAL();

        public DataTable SelectAll()
        {
            return thamSoDAL.SelectAll();
        }
        public int UpdateThamSo(ThamSoDTO thamSoDTO)
        {
            return thamSoDAL.UpdateThamSo(thamSoDTO);
        }
    }
}
