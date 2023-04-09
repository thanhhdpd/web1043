using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class BookList
    {
        private List<Book> danhsach;
        public void Sort()
        {
            danhsach.Sort();
        }
        public void SortMultiple()
        {
            danhsach.Sort(new BookComparer());
        }
             
        public void Xuat()
        {
            foreach(var i in danhsach)
            {
                i.xuat();
            }
        }
        public void Nhap()
        {
            danhsach = new List<Book>()
            {
                new Book(){TenSach="Sherlock Holmes",TenTacGia="Arthur Conan Doyle", NhaXuatBan="Kim Dong", NamXuatBan=1997, SoHieuISBN=1125, DanhMuc="Truyen trinh tham"},
                new Book(){TenSach="An mang tren chuyen tau toc hanh Phuong Dong",TenTacGia="Agatha Christie", NhaXuatBan="Kim Dong", NamXuatBan=1934, SoHieuISBN=1125, DanhMuc="Truyen trinh tham"},
                new Book(){TenSach="Phia sau nghi can X",TenTacGia="Keigo Higashino", NhaXuatBan="Kim Dong", NamXuatBan=2005, SoHieuISBN=1125, DanhMuc="Truyen trinh tham"},
            };
        }
    }
}
