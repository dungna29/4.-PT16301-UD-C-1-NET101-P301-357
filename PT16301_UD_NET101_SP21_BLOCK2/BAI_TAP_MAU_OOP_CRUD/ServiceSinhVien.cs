using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OOP_CRUD
{
    class ServiceSinhVien
    {
        private List<Student> _lstStudents = new List<Student>();
        private Student _student;
        private string _input;
        public ServiceSinhVien()
        {
            Student st1 = new Student("Nguyễn", "Hoàng", "Long", "0123456","long@gmail", "PH00111", 5.6);
            Student st2 = new Student("Nguyễn", "Hoàng", "Tú", "0123456","Tu@gmail", "PH00112", 5.8);
            _lstStudents.Add(st1);
            _lstStudents.Add(st2);
        }

        public void themSV()
        {
            Console.WriteLine("Mời bạn nhập lượng: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _student = new Student();
                Console.WriteLine("Mời bạn nhập Họ: ");
                _student.Ho = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Tên Đệm: ");
                _student.TenDem = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Tên: ");
                _student.Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Sđt: ");
                _student.Sdt = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Email: ");
                _student.Email = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Msv: ");
                _student.Msv = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Điểm C#1: ");
                _student.DiemCharp = Convert.ToDouble(Console.ReadLine());
                _lstStudents.Add(_student);
            }
        }

        public void xuatDanhSachSv()
        {
            inds(_lstStudents);//Gọi phương thức inDs để in danh sách sinh viên
        }

        public void sapXepDsSVTheoTen()
        {
            inds(_lstStudents.OrderBy(c=>c.Ten).ToList());
        }

        public void timKiemSV()
        {
            Console.WriteLine("Mời bạn nhập mã cần tìm: ");
            _input = Console.ReadLine();
            int temp = getIndexSV(_input);
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại");
                return;
            }
            _lstStudents[temp].inRaManHinh();
        }
        public void xoaSV()
        {
            Console.WriteLine("Mời bạn nhập mã cần xóa: ");
            _input = Console.ReadLine();
            int temp = getIndexSV(_input);
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại");
                return;
            }
            _lstStudents.RemoveAt(temp);
            Console.WriteLine("Đã xóa thành công");
        }
        public void suaSV()
        {
            Console.WriteLine("Mời bạn nhập mã cần sửa: ");
            _input = Console.ReadLine();
            int temp = getIndexSV(_input);
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại");
                return;
            }
            _lstStudents[temp].inRaManHinh();
            do
            {
                Console.WriteLine("1. Họ");
                Console.WriteLine("2. Tên Đệm");
                Console.WriteLine("3. Tên");
                Console.WriteLine("4. Sđt");
                Console.WriteLine("5. Thoát");
                Console.WriteLine("Bạn muốn sửa gì?");
                _input = Console.ReadLine();
                switch (_input)
                {
                    case "1":
                        Console.WriteLine("Họ cũ :" + _lstStudents[temp].Ho);
                        Console.WriteLine("Mơi bạn nhập họ cần sửa: ");
                        _lstStudents[temp].Ho = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Tên đệm :" + _lstStudents[temp].TenDem);
                        Console.WriteLine("Mơi bạn nhập tên đệm cần sửa: ");
                        _lstStudents[temp].TenDem = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Tên Cũ :" + _lstStudents[temp].Ten);
                        Console.WriteLine("Mơi bạn nhập tên cần sửa: ");
                        _lstStudents[temp].Ten = Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Sdt Cũ :" + _lstStudents[temp].Sdt);
                        Console.WriteLine("Mơi bạn nhập Sdt cần sửa: ");
                        _lstStudents[temp].Sdt = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            } while (!(_input == "5"));
        }

        //Phương thức dùng để tái sử dụng đầu vào phải truyền 1 danh sách đối tượng sinh Viên
        public void inds(List<Student> lstStudents)
        {
            foreach (var x in lstStudents)
            {
                x.inRaManHinh();
            }
        }
        //Phương thức trả ra index dựa vào mã sinh viên nhập vào
        public int getIndexSV(string msv)
        {
            //Cách 1:
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Msv == msv)
                {
                    return i;//Tìm thấy sẽ trả ra index của đối tượng trong danh sách
                }
            }
            return -1;//Không thìm thấy thì trả về -1
        }
    }
}
