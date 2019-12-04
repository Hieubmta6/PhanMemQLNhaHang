using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DALL
{

    public class KhachHang_DAL : datacontext
    {
        public List<KhachHang> LoadDL()
        {
            return qlsv.KhachHangs.Select(t => t).ToList<KhachHang>();
        }
    }

}