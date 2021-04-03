using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Bai_2._9_PhuongThu_Method;

namespace Bai_2._9_PhuongThuc_Method
{
    class Program
    {
        /*
       *  Bài 2.9 Phương thức - Method
       *  Định nghĩa: 1 tập các câu lệnh cùng nhau thực hiện 1 tác vụ nào đó.
       *  LỢI ÍCH: - Giúp quản lý code tốt hơn
       *           - Tái sử dụng
       *
       *  Công thức chung:
       *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
       *  {
       *          Body code
       *  }
         *
       * <Phạm vi truy cập> - Access Specifier:Public,Private,Protected, Default, Internal
       *
       * <Kiểu trả về> : có 2 kiểu trả về và không trả về
       *          - Kiểu không trả về: void
       *          - Kiểu trả về: là giá trị đơn(int,string,double....) hoặc tập giá trị(Array,List.....) hoặc đối tượng(class) và còn nhiều kiểu khác.
       *
       * <Tên phương thức>: Tên động từ viết thường + tên.
       * <Danh sách tham số>: Phương thức có thể có tham hoặc không tham số và lưu ý khi sử dụng tham số thì khi gọi phương thức thì phải truyền đúng vị trí của tham số và kiểu dữ liệu.
        

        PHƯƠNG THỨC KHÔNG ĐƯỢC TRÙNG TÊN NHƯNG ĐƯỢC PHÉP TRÙNG TÊN VÀ KHÁC THAM SỐ
       */
        private int a;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            PhuongThucKhongTraVe pt = new PhuongThucKhongTraVe();
            PhuongThucTraVe ptTraVe = new PhuongThucTraVe();
            #region Phần 1: Phương thức không trả về
            //Phần 1: Phương thức không trả về
            //Cách gọi phương thức: Cần biết tên phương thức và cuối của phương thức luôn là dấu ();
            //pt.tinhTong2So();

            //Sử dụng phương có tham số cần lưu ý:
            // 1. Truyền  tham số đúng vị trí,
            // 2. Đúng kiểu dữ liệu,
            // 3. Đủ tham số đầu vào không được thiếu

            //pt.tinhTongSo(5);//Truyền thiếu tham số gây lỗi
            //pt.tinhTongSo("5","5");//Sai kiểu dữ liệu truyền
            //pt.tinhTongSo(5, 5);

            //Lưu ý: Số lượng tham số sẽ quyết định gọi vào phương thức nào


            #endregion

            #region Phần 2: Phương thức trả về
            /*
             * Lưu ý: Phải coi phương thức trả về là giá trị hoặc tập trị....
             *
             * */

            //ptTraVe.tinhTong();//Khi nó là giá trị không thể tự in chính nó
            //Console.WriteLine(ptTraVe.tinhTong());//ptTraVe.tinhTong() có kiểu dữ liệu in và nó là giá trị sau khi tính toán


            //Sử dụng phương thức trả về là 1 mảng
            string[] temparr = ptTraVe.getYears();
            foreach (var x in ptTraVe.getYears())
            {
                Console.WriteLine(x + " ");
            }

            //Sử dụng phương thức trả về là 1 đối tượng
            ptTraVe.getSV().inRaManHinh();
            #endregion
            
        }
    }
}
