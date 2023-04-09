using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal interface IBook
    {
        string TenSach { get; set; }
        string TenTacGia { get; set; }
        string NhaXuatBan { get; set; }
        int NamXuatBan { get; set; }
        int SoHieuISBN { get; set; }
        string DanhMuc { get; set; }
        void nhap();
        void xuat();
    }
}
