using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTON1
{
    internal class Xe
    {
        private string dongXe;
        private int soChoNgoi;
        private DateTime ngaySX;
        private double giaSan = 400;

        public string DongXe { get => dongXe; set => dongXe = value; }
        public int SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }
        public DateTime NgaySX { get => ngaySX; set => ngaySX = value; }
        public double GiaSan { get => giaSan; set => giaSan = value; }

        public Xe(string dongXe, int soChoNgoi, DateTime ngaySX, double giaSan)
        {
            this.dongXe = dongXe;
            this.soChoNgoi = soChoNgoi;
            this.ngaySX = ngaySX;
        }

        public Xe()
        {
        }

        public double tinhGiaBan()
        {
            if (DateTime.Now.Year - ngaySX.Year > 2)
            {
                return giaSan * 1.15;
            }
            if (DateTime.Now.Year - ngaySX.Year > 1)
            {
                return giaSan * 1.3;
            }
            else
            {
                return giaSan * 1.5;
            }
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập dòng xe: ");
            dongXe = Console.ReadLine();
            do
            {
                Console.WriteLine("Nhập số chỗ ngồi: ");
                soChoNgoi = int.Parse(Console.ReadLine());
            } while (soChoNgoi <= 0);
            Console.WriteLine("Nhập ngày sản xuất: ");
            ngaySX = DateTime.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"Dòng xe: {dongXe}\nSố chỗ ngồi: {soChoNgoi}\n Ngày sản xuất: {ngaySX}\n Giá bán: {tinhGiaBan()}");
        }
    }

    interface Phi
    {
        double phiTruocBa { get; set; }

        double tinhPhiTruocBa();
    }

    class XeVinfast : Xe, Phi
    {
        private string noiDangKy;

        //base -> lớp cha
        public XeVinfast() : base()
        {
        }


        public double phiTruocBa { get; set; }
        public string NoiDangKy { get => noiDangKy; set => noiDangKy = value; }



        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập nơi đăng ký");
            noiDangKy = Console.ReadLine();
            Console.WriteLine("Nhập phí trước bạ");
            phiTruocBa = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Nơi đăng ký: {noiDangKy}");
        }

        public double tinhPhiTruocBa()
        {
            return phiTruocBa * tinhGiaBan();
        }

        public double giaLanBanh()
        {
            double giaBanXe = tinhGiaBan();
            double tienPhi = tinhPhiTruocBa();
            double phiDangKy;
            // Có thể ùng noiDangKy.Contains("Ha Noi")
            if(noiDangKy == "Ha Noi")
            {
                phiDangKy = giaBanXe * 0.12;
            }
            else
            {
                phiDangKy = giaBanXe * 0.1;
            }
            return giaBanXe + tienPhi + phiDangKy;
        }

        public int soSanh(XeVinfast xe2)
        {
            // Với trường hợp giảm dần
            // a < b -> return 1
            // a == b -> return 0
            // a > b -> return -1
            if (this.giaLanBanh() < xe2.giaLanBanh()) return 1;
            if (this.giaLanBanh() == xe2.giaLanBanh()) return 0;
            else return -1;
        }
    }

    class DsXe
    {
        private List<XeVinfast> dsXe = new List<XeVinfast>();
        private int n;

        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhập số lượng xe (0 < n < 20): ");
                n = int.Parse(Console.ReadLine());
            } while (!(n > 0 && n < 20)); //n <= 0 || n >= 20
            for(int i = 1; i <= n; i++)
            {
                //Xe xe = new Xe() -> Xe xe = new XeVinfast(); Xe xe2 = new XeHonda();
                XeVinfast xe = new XeVinfast();
                xe.Nhap();
                dsXe.Add(xe);
            }
        }

        public void sapXep()
        {
            //Chạy từ 0 đến n-1, phần từ cuối đã được kiểm tra ở lần thứ n-1, kh cần kiểm tra nữa
            for(int i = 0; i < n-1; i++)
            {
                if (dsXe[i].soSanh(dsXe[i + 1]) == 1){
                    XeVinfast xetmp = dsXe[i];
                    dsXe[i] = dsXe[i + 1];
                    dsXe[i + 1] = xetmp;
                }
            }
        }

        public void XuatDS()
        {
            for(int i = 0; i < n; i++)
            {
                dsXe[i].Xuat();
            }
        }

        public void themXe()
        {
            Console.Write("Nhập vị trí xe muốn thêm vào: ");
            int p = int.Parse(Console.ReadLine());
            XeVinfast xe = new XeVinfast();
            xe.Nhap();
            dsXe.Insert(p, xe);
        }

        public void xoaDongXe()
        {
            string dongXeCanXoa = Console.ReadLine();
            for(int i = 0; i < n; i++)
            {
                if (dsXe[i].DongXe == dongXeCanXoa)
                {
                    dsXe.RemoveAt(i);
                    //Hoặc dsXe.Remove(dsXe[i])
                }
            }
        }
    }
}
