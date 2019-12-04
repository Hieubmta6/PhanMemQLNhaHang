using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class HangHoa_DAL : datacontext
    {
        HangHoa mh = new HangHoa();
        public List<HangHoa> LoadDL()
        {
            return qlsv.HangHoas.Select(t => t).ToList<HangHoa>();
        }
        public void Them(string mahang, string tenhh, string tenta, string dvt, string nhomhang, string cachtinhvon, float giaban, int sTT ,bool sd, bool ht , bool ttk )
        {
            try
            {
                
                mh.MaHang = mahang;
                mh.TenHang_V = tenhh;
                mh.TenHang_E = tenta;
                mh.DVT = dvt;
                mh.NhomHang = nhomhang;
                mh.CachTinhGiaVon = cachtinhvon;
                mh.GiaBan = giaban;
                mh.STT = sTT;
                mh.SuDung = bool.Parse(sd.ToString());
                mh.HienThi = bool.Parse(ht.ToString());
                mh.TinhTonKho = bool.Parse(ttk.ToString());
                qlsv.HangHoas.InsertOnSubmit(mh);
                qlsv.SubmitChanges();
            }
            catch
            {

            }

        }
        public void Xoa(string mahang)
        {
            mh = qlsv.HangHoas.Where(t => t.MaHang == mahang).FirstOrDefault();
            qlsv.HangHoas.DeleteOnSubmit(mh);
            qlsv.SubmitChanges();
        }
        public void sua( string mahang ,string tenhang , string tenE, string dvt , string nhomhang,string cachtinhgiavon,float dongia,int SL )
        {
            mh = qlsv.HangHoas.Where(t => t.MaHang == mahang).FirstOrDefault();
            mh.TenHang_V = tenhang;
            mh.TenHang_E = tenE;
            mh.NhomHang = nhomhang;
            mh.GiaBan = dongia;
            mh.STT = SL;
            mh.DVT = dvt;
            mh.CachTinhGiaVon = cachtinhgiavon;
            qlsv.SubmitChanges();
        }
    }
}
