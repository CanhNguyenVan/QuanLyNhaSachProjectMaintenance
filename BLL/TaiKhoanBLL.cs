using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public DataTable SelectAll()
        {
            return taiKhoanDAL.SelectAll();
        }

        public DataTable SelectLastMaTK()
        {
            return taiKhoanDAL.SelectLastMaTK();
        }

        public int InsertTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            return taiKhoanDAL.InsertTaiKhoan(taiKhoanDTO);
        }

        public int UpdateTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            return taiKhoanDAL.UpdateTaiKhoan(taiKhoanDTO);
        }

        public int DeleteTaiKhoan(string maTK)
        {
            return taiKhoanDAL.DeleteTaiKhoan(maTK);
        }
    }
}
