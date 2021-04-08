using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._1_LINQ_COBAN
{
    class Service
    {
        private List<SinhVien> lsSinhViens = new List<SinhVien>();
        public Service()
        {
            fakeData();
        }
        void fakeData()
        {
            SinhVien sv1 = new SinhVien("Tiến", "PH00555", 2000, 1);
            SinhVien sv2 = new SinhVien("Long", "PH00556", 2000, 2);
            SinhVien sv3 = new SinhVien("Hoàng", "PH00557", 2000, 3);
            SinhVien sv4 = new SinhVien("Anh", "PH00558", 2000, 4);
            SinhVien sv5 = new SinhVien("Dũng", "PH00559", 2000, 5);
            SinhVien sv6 = new SinhVien("Lương", "PH005510", 2000, 6);
            SinhVien sv7 = new SinhVien("Huyền", "PH005511", 2000, 7);
            lsSinhViens.Add(sv1);
            lsSinhViens.Add(sv2);
            lsSinhViens.Add(sv3);
            lsSinhViens.Add(sv4);
            lsSinhViens.Add(sv5);
            lsSinhViens.Add(sv6);
            lsSinhViens.Add(sv7);
        }

        void sortSinhVien()
        {
           var lstTempSort = lsSinhViens.OrderBy(c => c.Ten);
            // Sử dụng sắp xếp bằng LINQ
            foreach (var x in lsSinhViens.OrderBy(c=>c.Ten))
            {
                x.inRaManHinh();
            }
        }

        void timKiemTheoMa()
        {
            Console.WriteLine("Mời bạn nhập mã sinh viên: ");
            string msv = Console.ReadLine();

            //Cách tìm kiếm sử dụng vòng lặp
            foreach (var x in lsSinhViens)
            {
                if (x.Msv == msv)
                {
                    x.inRaManHinh();
                }
            }
            //Sử dụng Linq để in 1 đối tượng ra màn hình dựa vào điều kiện tìm kiếm
            lsSinhViens.Where(c=>c.Msv == msv).FirstOrDefault().inRaManHinh();
            
        }

        void xoaTheoMa()
        {
            Console.WriteLine("Mời bạn nhập mã sinh viên: ");
            string msv = Console.ReadLine();
            //Cách 1:
            for (int i = 0; i < lsSinhViens.Count; i++)
            {
                if (lsSinhViens[i].Msv == msv)
                {
                    lsSinhViens.RemoveAt(i);
                }
            }
            //Cách 2: Dùng LINQ 
            lsSinhViens.RemoveAt(lsSinhViens.FindIndex(c=>c.Msv == msv));
        }
    }
}
