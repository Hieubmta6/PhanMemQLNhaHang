using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class DMKHO_DALL : datacontext
    {
        DMKho H = new DMKho();
        public List<DMKho> LoadDL(){
            return qlsv.DMKhos.Select(t => t).ToList<DMKho>();
        }
        public void them(string makho , string tenkhov, bool khomacdinh)
        {
           
            H.MaKho = makho;
            H.TenKho_V = tenkhov;
            H.KhoMacDinh = khomacdinh;
            qlsv.DMKhos.InsertOnSubmit(H);
            qlsv.SubmitChanges();

        }
        public void Xoa(string makho)
        {
            H = qlsv.DMKhos.Where(t => t.MaKho == makho).FirstOrDefault();
            qlsv.DMKhos.DeleteOnSubmit(H);
            qlsv.SubmitChanges();
        }
        public void sua(string makho, string tenkho,bool kmd)
        {
            H = qlsv.DMKhos.Where(t => t.MaKho == makho).FirstOrDefault();
            H.MaKho = makho;
            H.TenKho_V = tenkho;
            H.KhoMacDinh = kmd;
            qlsv.SubmitChanges();
        }
    }
}
