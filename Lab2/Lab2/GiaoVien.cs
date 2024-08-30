using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class GiaoVien
    {
        public string MaSo {  get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public DanhSachMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhSachMonHoc();
            NgoaiNgu = new string[10];
        }
        public GiaoVien(string maSo, string hoTen, DateTime ngaySinh, DanhSachMonHoc dsMonHoc, string gioiTinh, string[] ngoaiNgu, string soDT, string mail)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            this.dsMonHoc = dsMonHoc;
            GioiTinh = gioiTinh;
            NgoaiNgu = ngoaiNgu;
            SoDT = soDT;
            Mail = mail;
        }
        public override string ToString()
        {
            string s = "Mã Số: " + MaSo + "\n" + "Họ tên: " + HoTen + "\n" + "Ngày Sinh: " + NgaySinh.ToString() + "\n" + "Giới Tính: " + GioiTinh + "\n" + "Số ĐT: " + SoDT + "\n" + "Mail: " + Mail + "\n";
            string sNN = "Ngoại ngữ: ";
            foreach (string n in NgoaiNgu)
                sNN += n + ";";
            string monDay = "Danh sách môn dạy: ";
            foreach (MonHoc mh in dsMonHoc.ds)
                monDay += mh + ";";
            s += "\n" + sNN + "\n" + monDay;
            return s;
        }
    }
}
