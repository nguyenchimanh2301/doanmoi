using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using QL_KTX.DataAcessLayer;
using QL_KTX.Entities;

namespace QL_KTX.DataAcessLayer
{
    class DALhoadon
    {
        private string hdfile = "Data/hoadon.txt";
        public  List<Hoadon>   Lhoadon()
        {
            List<Hoadon> list = new List<Hoadon>();
            StreamReader sr = File.OpenText(hdfile);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Hoadon(a[0], double.Parse(a[1]), double.Parse(a[2]), double.Parse(a[3]), double.Parse(a[4]), int.Parse(a[5]), double.Parse(a[6]), double.Parse(a[7]))); ;
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void themhd(Hoadon hd)
        {
            StreamWriter fwrite = File.AppendText(hdfile);
            fwrite.WriteLine();
            fwrite.Write(hd.Maph+ "#" +hd.Tienphong+ "#" +hd.Tiendien+ "#"+hd.Tiennuoc+ "#"+hd.Tienvesinh+ "#"+hd.Tgiano+"#"+hd.Tkhac+"#"+hd.Tongt);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<Hoadon> list)
        { 
            StreamWriter sw = File.CreateText(hdfile);
            for (int i = 0; i < list.Count; ++i)
                sw.WriteLine(list[i].Maph + "#" + list[i].Tienphong + "#" + list[i].Tiendien+ "#"+list[i].Tiennuoc + "#" + list[i].Tienvesinh+ "#" + list[i].Tgiano+"#"+list[i].Tkhac+"#"+list[i].Tongt);
            sw.Close();
        }
    }

}
