using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._3_Array
{
    class Program
    {
        /*
        * Phần 1: Mảng 1 chiều
        *
        *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
        *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
        *
        *  2. Khai báo 1 mảng trong Csharp:
        *          - Cách 1:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
        *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
        *          - Cách 2: 
        *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
        *
        *          - Cách 3:
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
        *
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
        *
        *  3. Truy xuất các phần tử trong mảng
        *      - Gán giá trị cho mảng:
        *           <tên mảng>[index] = Giá trị cần gán;
        *   
        *     - Lấy giá trị trong mảng:
        *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
        *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
        *
        *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
        *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
        */
        static void Main(string[] args)
        {
            //Phần 1: Khai báo mảng
            int[] arrNumber1;//Khai báo 1 mảng
            arrNumber1 = new int[5];//Khởi tạo mảng có 5 phần tử

            string[] arrNames = new string[5];//Khởi tạo 1 mảng chuỗi có 5 phần tử

            int[] arrYears = new[] {2021, 2022, 2023};
            double[] arrDiem = { 8.6,7.2,7.3};

            var arrNumber3 = new int[5];//Đây là một mảng int

            //Phần 2: Gán giá trị cho mảng
            //arrNumber1 = 5; Sai vì không chỉ rõ lưu giá trị vào đâu
            arrNumber1[0] = 5;//Gán giá trị 5 cho vị trí số 0 trong mảng
            arrNumber1[1] = 2;
            arrNumber1[0] = 15;//Ghi đè giá trị

            //Phần 3: Lấy giá trị
            Console.WriteLine(arrNumber1[0]);//Lấy 1 giá trị đơn

            //Lấy nhiều giá trị trong mảng in ra màn hình
            for (int i = 0; i < arrNumber1.Length; i++)
            {
                Console.Write(arrNumber1[i] +" ");
            }

            Console.WriteLine();
            //Vòng lặp foreach fore + tab
            foreach (int x in arrNumber1)
            {
                Console.Write(x +" ");
            }

        }
    }
}
