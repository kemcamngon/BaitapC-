using System;

namespace Chuong3_part1_bt6
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSach ds = new DanhSach();
            ds.Nhap();
            ds.Xuat();
            ds.SapXep();
            Console.Read();
        }
    }
}
