using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
     public class KhuVuc_DALL:datacontext
    {
        KhuVuc v = new KhuVuc();
        public List<KhuVuc> LoadDL()
        {
            return qlsv.KhuVucs.Select(t => t).ToList<KhuVuc>();
        }
        public void them(string makv, string tenkv, bool sd,string mayin)
        {

            v.MaKV = makv;
            v.TenKV_V = tenkv;
            v.MayIn = mayin;
            v.SuDung = sd;
            qlsv.KhuVucs.InsertOnSubmit(v);
            qlsv.SubmitChanges();

        }
        public void Xoa(string makv)
        {
            v = qlsv.KhuVucs.Where(t => t.MaKV == makv).FirstOrDefault();
            qlsv.KhuVucs.DeleteOnSubmit(v);
            qlsv.SubmitChanges();
        }
        public void sua(string makv, string tenkv, bool sd, string mayin)
        {
            v = qlsv.KhuVucs.Where(t => t.MaKV == makv).FirstOrDefault();
            v.MaKV = makv;
            v.TenKV_V = tenkv;
            v.MayIn = mayin;
            v.SuDung = sd;
            qlsv.SubmitChanges();
        }
    }
}
