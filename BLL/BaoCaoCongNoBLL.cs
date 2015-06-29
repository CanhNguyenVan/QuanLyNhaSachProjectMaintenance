using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaoCaoCongNoBLL
    {
        BaoCaoCongNoDAL baoCaoCongNoDAL = new BaoCaoCongNoDAL();

        //Hiển thị danh sách các báo cáo tồn
        public DataTable SelectAll()
        {
            return baoCaoCongNoDAL.SelectAll();
        }

        //Hiển thị danh sách các báo cáo tồn theo tháng
        public DataTable SelectAllByMonth()
        {
            return baoCaoCongNoDAL.SelectByMonth();
        }
    }
}
