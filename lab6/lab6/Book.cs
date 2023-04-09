using lab6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Book : IBook, IComparable<Book>
    {
        public string TenSach { get; set; }
        public string TenTacGia { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public int SoHieuISBN { get; set; }
        public string DanhMuc { get; set; }

        public int CompareTo(Book other)
        {
            return this.TenSach.CompareTo(other.TenSach);
        }

        public void nhap()
        {
        }
        public void xuat()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Ten sach: " + TenSach);
            Console.WriteLine("Ten tac gia: " + TenTacGia);
            Console.WriteLine("Nha xuat ban: " + NhaXuatBan);
            Console.WriteLine("Nam xuat ban: " + NamXuatBan);
            Console.WriteLine("So hieu ISBN: " + SoHieuISBN);
            Console.WriteLine("Danh muc: " + DanhMuc);
        }
    }
}