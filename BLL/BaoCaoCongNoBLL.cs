using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaoCaoCongNoBLL
    {
        BaoCaoCongNoDAL baoCaoCongNoDAL = new BaoCaoCongNoDAL();

        //Hiển thị danh sách các báo cáo tồn
        public List<BaoCaoCongNoDTO> SelectAll()
        {
            return baoCaoCongNoDAL.SelectAll();
        }

        //Hiển thị danh sách các báo cáo tồn theo tháng
        public List<BaoCaoCongNoDTO> SelectAllByMonth()
        {
            return baoCaoCongNoDAL.SelectByMonth();
        }
    }
}
