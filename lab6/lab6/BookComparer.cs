using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare (Book x, Book y)
        {
            int result = x.TenTacGia.CompareTo(y.TenTacGia);
            if(result == 0)
            {
                result = x.TenSach.CompareTo(y.TenSach);
            }
            if(result == 0)
            {
                result = x.NamXuatBan.CompareTo(y.NamXuatBan);
            }
            return result;
        }
    }
}
