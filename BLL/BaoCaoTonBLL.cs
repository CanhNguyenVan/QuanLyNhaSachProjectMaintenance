using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaoCaoTonBLL
    {
        BaoCaoTonDAL baoCaoTonDAL = new BaoCaoTonDAL();

        //Hiển thị danh sách các báo cáo tồn
        public List<BaoCaoTonDTO> SelectAll()
        {
            return baoCaoTonDAL.SelectAll();
        }

        //Hiển thị danh sách các báo cáo tồn theo tháng
        public List<BaoCaoTonDTO> SelectAllByMonth()
        {
            return baoCaoTonDAL.SelectByMonth();
        }
    }
}
