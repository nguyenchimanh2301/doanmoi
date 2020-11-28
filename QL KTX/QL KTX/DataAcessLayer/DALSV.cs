using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Entities;
using System.IO;
namespace QL_KTX.DataAcessLayer
{
    class DALSV
    {
        private string filesv = "Data/Sinhvien.txt";
        public List<SV> LSinhvien()
        {
            List<SV> list = new List<SV>();
            StreamReader sr = File.OpenText(filesv);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new SV(a[0], a[1], a[2], a[3], a[4], a[5], a[6]));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void Themsv(SV sv)
        {
            StreamWriter fwrite = File.AppendText(filesv);
            fwrite.WriteLine();
            fwrite.Write(sv.Maph+ "#" + sv.Masv+ "#" + sv.Tensv + "#" +sv.Gioitinh + "#" +sv.Diachi + "#" +sv.Tenlop + "#" +sv.Sdt1);
            fwrite.Close();
        }
    }
}
