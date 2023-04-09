using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookList danhsach = new BookList();
            danhsach.Nhap();
            danhsach.Xuat();
            danhsach.Sort();
            danhsach.Xuat();
            danhsach.SortMultiple();
            danhsach.Xuat();
            Console.ReadKey(true);
        }
    }
}
