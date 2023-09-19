using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class SinhVien
    {
        //Field
        private string maSo;
        private string hoTen;
        private string chuyenNganh;
        private int namSinh;
        private float diemTB;
        private string loai;
        //Properties
        public string MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public float DiemTB { get => diemTB; set
            {
                if (KiemTraDiemTB(value))
                {
                    diemTB = value;
                }
                XepLoai();
            }
        }
        public string Loai { get => loai; set => loai = value; }
        //Constructor
        public SinhVien() { }
        public SinhVien(string ms, string ht, string cn, int ns, float dtb)
        {
            this.maSo = ms;
            this.hoTen = ht;
            this.chuyenNganh = cn;
            this.namSinh = ns;
            this.diemTB = dtb;
            XepLoai();
        }
        public SinhVien(SinhVien sv)
        {
            this.maSo = sv.maSo;
            this.hoTen = sv.hoTen;
            this.chuyenNganh = sv.chuyenNganh;
            this.namSinh = sv.namSinh;
            this.diemTB = sv.diemTB;
            this.loai = sv.loai;
            XepLoai();
        }
        //Method
        private bool CheckFormatName(string s)
        {
            var pattern = @"^[a-zA-Z0-9_]+$";
            return new Regex(pattern).IsMatch(s);
        }
        public bool KiemTraNamSinh(int ns)
        {
            int age = DateTime.Now.Year - namSinh;
            return age >= 17 && age <= 70;
        }
        public bool KiemTraDiemTB(float dtb) => dtb >= 0 && dtb <= 10;
        public void Nhap()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhập MSSV: ");
            MaSo = Console.ReadLine();
            do
            {
                Console.Write("Nhập tên sinh viên: ");
                HoTen = Console.ReadLine();
            } while (!CheckFormatName(HoTen));
            Console.Write("Nhập chuyên ngành: ");
            ChuyenNganh = Console.ReadLine();
            do
            {
                Console.Write("Nhập năm sinh: ");
                NamSinh = int.Parse(Console.ReadLine());
            } while (!KiemTraNamSinh(NamSinh));
            do
            {
                Console.Write("Nhập điểm trung bình: ");
                DiemTB = float.Parse(Console.ReadLine());
            } while (!KiemTraDiemTB(DiemTB));
            XepLoai();
        }
        public void Xuat()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"MSSV: {maSo} - Tên SV: {hoTen} - Chuyên ngành: {chuyenNganh} - Năm sinh: {namSinh} - Điểm TB: {diemTB} - Loại: {loai}");
        }
        public void XepLoai()
        {
            if (diemTB < 5)
            {
                Loai = "Kém";
            }
            else if (diemTB < 7)
            {
                Loai = "Trung Bình";
            }
            else if (diemTB < 8)
            {
                Loai = "Khá";
            }
            else
            {
                Loai = "Giỏi";
            }
        }
    }
}
