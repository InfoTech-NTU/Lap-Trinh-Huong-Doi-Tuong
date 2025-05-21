using BTON1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DsXe dsXe = new DsXe();
            dsXe.Nhap();
            dsXe.sapXep();
            dsXe.XuatDS();
            dsXe.themXe();
            dsXe.XuatDS();
            dsXe.xoaDongXe();
            dsXe.XuatDS();
            Console.ReadKey();
        }
    }
}