using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._7_ArrayList
{
    class Program
    {
        /*
         *  ArrayList
         *  Định nghĩa: Là một Collections giúp lưu trữ và quản lý một
                        danh sách các đối tượng theo kiểu mảng (truy
                        cập các phần tử bên trong thông qua chỉ số
                        index)
            Ưu điểm:    Cho phép thêm hoặc xoá các phần tử một cách
                        linh hoạt và có thể tự điều chỉnh kích cỡ một
                        cách tự động.
            Sử dụng:    Để sử dụng các Collections trong .NET ta cần
                        thêm thư viện System.Collections

            Từ khóa: ArrayList arrLst<Tên> =  new ArrayList();
         */

        /*
          * A. CÁC PHƯƠNG THỨC TRONG ArrayList
          * 1. Add(object Value): Thêm đối tượng vào cuối.
          * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
          * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
          * 4. Clear(): Xóa tất cả các phần tử.
          * 5. Clone(): Tạo 1 bản sao của danh sách đó.
          * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
          * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
          * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
          */
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phần 1: Khai báo và khởi tạo
            ArrayList arrlstKhongDinhKieu;//Khai báo
            arrlstKhongDinhKieu = new ArrayList();//Khởi tạo 1 

            //Phần 2: Gán giá trị cho ArrayList sử dụng phương thức add
            arrlstKhongDinhKieu.Add(1);//Thêm kiểu số nguyên vào ArrayList
            arrlstKhongDinhKieu.Add("Kiểu String");
            arrlstKhongDinhKieu.Add(true);
            arrlstKhongDinhKieu.Add(false);
            arrlstKhongDinhKieu.Add(8.6);
            arrlstKhongDinhKieu.Add('a');

            //Phần 3: Lấy giá trị giống như mảng tĩnh
            //arrlstKhongDinhKieu = new ArrayList(); khi khởi tạo lại thì dữ liệu sẽ bị xóa trắng
            Console.WriteLine(arrlstKhongDinhKieu[0]);
            foreach (var x in arrlstKhongDinhKieu)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
            //arrlstKhongDinhKieu.Clear();//Dùng để xóa các phần tử trong danh sách
            Console.WriteLine("Số phần tử trong ArrayList: " + arrlstKhongDinhKieu.Count);//Size của mảng
            
            //Phàn 4: Xóa phần tử
            arrlstKhongDinhKieu.RemoveAt(0);//Xóa phần tử đầu tiên trong danh sách
            Console.WriteLine(arrlstKhongDinhKieu[0]);

        }
    }
}
