using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{

    public class ThoiDiemBan_DAL : datacontext
    {
        ThoiDiem t = new ThoiDiem();
        public List<ThoiDiem> LoadDL()
        {
            return qlsv.ThoiDiems.Select(t => t).ToList<ThoiDiem>();
        }
        public void add(string thoidiem,string tentd,DateTime GioBD)
        {
            
            t.MaThoiDiem = thoidiem;
            t.TenThoiDiem = tentd;
            t.GioBD = TimeSpan.Parse(GioBD.ToShortTimeString());
            qlsv.ThoiDiems.InsertOnSubmit(t);
            qlsv.SubmitChanges();
        }
        public void Xoa(string matd)
        {
            t = qlsv.ThoiDiems.Where(t => t.MaThoiDiem == matd).FirstOrDefault();
            qlsv.ThoiDiems.DeleteOnSubmit(t);
            qlsv.SubmitChanges();
        }
        public void sua(string thoidiem, string tentd, DateTime GioBD)
        {
            t = qlsv.ThoiDiems.Where(t => t.MaThoiDiem == thoidiem).FirstOrDefault();
            t.MaThoiDiem = thoidiem;
            t.TenThoiDiem = tentd;
            t.GioBD = TimeSpan.Parse(GioBD.ToShortTimeString());
            qlsv.SubmitChanges();
        }

    }

}