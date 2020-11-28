using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Businisse.IBLL;
using QL_KTX.Entities;
using QL_KTX.Businisse;
using QL_KTX.DataAcessLayer;

namespace QL_KTX.Presentation
{
    class FormPhong
    {
        private BLLphong pbll = new BLLphong();
        GD gd = new GD(100, 50);
        public void menuphong()
        {

            for (int i = 8; i < 22; ++i)
            {

                gd.pain("║", 7, i);
                gd.pain("║", 92, i);
            }

            gd.pain("╠════════════════════════════════════════════════════════════════════════════════════╣", 7, 7);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
            gd.pain("╠═══════════════════════════════╦═══════════════════════════════════════════════════╣", 7, 13);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 19);

            for (int i = 11; i < 22; ++i)
            {

                gd.pain("║", 39, i);
            }
            gd.pain("╠═══════════════════════════════╩════════════════════════════════════════════════════╣", 7, 22);
            gd.pain("CÁC THAO TÁC QUẢN LÍ PHÒNG KÍ TÚC", 30, 9);
            gd.pain("F1", 9, 12); gd.pain("THÊM PHÒNG KÍ TÚC", 60, 12);
            gd.pain("F2", 9, 15); gd.pain("XÓA PHÒNG KÍ TÚC", 60, 15);
            gd.pain("F3", 9, 18); gd.pain("HIỆN THÔNG TIN", 60, 18);
            gd.pain("F4", 9, 21); gd.pain("TRỞ LẠI", 60, 21);
        Phong: ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1: Console.Clear(); themt(); break;
                case ConsoleKey.F2: Console.Clear(); hien(); break;
                case ConsoleKey.F3: Console.Clear();suaphong(); break;
                default:
                    goto Phong;
            }
        }
        public void themt()
        {
            Phongkt ph = new Phongkt();
            for (int i = 8; i < 25; ++i)
            {
                gd.pain("║", 7, i);
                gd.pain("║", 92, i);

            }
            gd.pain("╠════════════════════════════════════════════════════════════════════════════════════╗", 7, 7);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
            gd.pain("╠═══════════════════════════════╬════════════════════════════════════════════════════╣", 7, 13);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 19);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 22);

            for (int i = 8; i < 25; ++i)
            {

                gd.pain("║", 39, i);
            }
            gd.pain("╚═══════════════════════════════╩════════════════════════════════════════════════════╝", 7, 25);
        maph: gd.pain("", 60, 9); ;
            try
            {
                Console.SetCursorPosition(9, 12); Console.WriteLine("Nhập mã phòng");

                Console.SetCursorPosition(50, 12); ph.Maph = Console.ReadLine();
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("khong co thong tin mi nhap lai");
                goto maph;
            }

        tenday: gd.pain("", 50, 15);
            try
            {
                Console.SetCursorPosition(9, 15); Console.WriteLine("Nhập ten day");
                Console.SetCursorPosition(50, 15); ph.Tenday = Console.ReadLine();
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("khong co thong tin mi nhap lai");
                goto tenday;
            }
        slmax: gd.pain("", 50, 18);
            try
            {
                Console.SetCursorPosition(9, 18); Console.WriteLine("Nhập sl hoc sinh max");
                Console.SetCursorPosition(50, 18); ph.Soluongmax = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu hoặc dữ liệu là chữ,mời nhập lại");
                goto slmax;
            }
        dango: gd.pain("", 50, 21);
            try
            {
                Console.SetCursorPosition(9, 21); Console.WriteLine("Nhập sl hoc sinh đang ở");
                Console.SetCursorPosition(50, 21); ph.Dango = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu hoặc dữ liệu là chữ,mời nhập lại");
                goto dango;
            }
        tinhtrang: gd.pain("", 50, 24);
            try
            {
                Console.SetCursorPosition(9, 24); Console.WriteLine("Cho biết trạng thái của  phòng");
                Console.SetCursorPosition(50, 24); ph.Tinhtrang = Console.ReadLine();
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu ,mời nhập lại");
                goto tinhtrang;
            }
            pbll.themphong(ph);

            gd.pain("F1", 20, 27); gd.pain("THÊM VÀ NHẬP TIẾP", 30, 27);
            gd.pain("F2", 20, 28); gd.pain("HIỆN THÔNG TIN", 30, 28);
            gd.pain("F3", 20, 29); gd.pain("TRỞ LẠI", 30, 29);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1: pbll.themphong(ph); Console.Clear(); themt(); Console.Clear(); break;
                case ConsoleKey.F2: Console.Clear(); hien(); break;
                case ConsoleKey.F3: Console.Clear(); menuphong(); break;
                default:
                    return;
            }
        }
        public void hien()
        {
            List<Phongkt> list = pbll.LPhong();
            foreach (var p in list)
            {
                //gd.ve(10, 9); Console.Write(p.Maph); gd.ve(25, 9); Console.Write(p.Tenday); gd.ve(40,9); Console.Write(p.Soluongmax);
                //gd.ve(55, 9); Console.Write(p.Dango); gd.ve(76, 9); Console.Write(p.Tinhtrang);
                Console.WriteLine(p.Maph + "\t\t" + p.Tenday + "\t\t" + p.Soluongmax + "\t\t" + p.Dango + "\t\t" + p.Tinhtrang);
            }
            for (int i = 5; i < 45; ++i)
            {
                gd.pain("║", 7, i);
                gd.pain("║", 91, i);
            }
            gd.pain("MÃ PHÒNG", 10, 6); gd.pain("TÊN DÃY", 25, 6); gd.pain("SỐ LƯỢNG TỐI ĐA", 38, 6); gd.pain("ĐANG Ở HIỆN TẠI", 56, 6); gd.pain("TÌNH TRẠNG", 75, 6);

            gd.pain("╔══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╗", 7, 4);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 7);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 10);
            //gd.pain("╠══════════════╦════════════╬══════════════════╦═══════════════════╦════════════════╣", 7, 13);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 16);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 19);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 22);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 25);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 28);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 31);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 34);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 37);
            //for (int i = 5; i < 45; ++i)
            //{
            //    gd.pain("║", 22, i);
            //    gd.pain("║", 35, i);
            //    gd.pain("║", 54, i);
            //    gd.pain("║", 74, i);
            //}
            gd.pain("╚══════════════╩════════════╩══════════════════╩═══════════════════╩════════════════╝", 7, 45);
            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU PHÒNG", 20, 47);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.Tab: Console.Clear(); menuphong(); break;
                default:
                    return;
            }

        }
        public void suaphong()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN PHONG");
            List<Phongkt> list = pbll.LPhong();
            string map;
            Console.Write("Nhap ma san pham can sua:");
            map = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Maph == map) break;

            if (i < list.Count)
            {
                Phongkt p = new Phongkt(list[i]);
                Console.Write("Nhap ten day:");
                string day = Console.ReadLine();
                if (!string.IsNullOrEmpty(day)) p.Tenday = day;
                Console.Write("Nhap so luong nguoi o moi");
                int sno = int.Parse(Console.ReadLine());
                if (sno > 0) p.Dango = sno;
                Console.WriteLine("Tinh trang phong");
                string ttp = Console.ReadLine();
                if (!string.IsNullOrEmpty(ttp)) p.Tinhtrang = ttp;
                pbll.suaphong(p);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }

            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU PHÒNG", 20, 47);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F2: Console.Clear();suaphong();break;
                case ConsoleKey.Tab: Console.Clear(); menuphong(); break;
                default:
                    return;
            }
        }
    }
}
  

