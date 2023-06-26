using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi5
{
    internal class SinhVien
    {
        
        public string SVname;
        public double dtb;
        public string hocLuc;

        public void nhapSV()
        {
            Console.Write("Nhập tên sinh viên: ");
            this.SVname = Console.ReadLine();

            Console.Write("Nhập điểm sinh viên: ");
            this.dtb = double.Parse(Console.ReadLine());

        }

        public void showSV()
        {
            if (this.dtb >= 8)
            {
                this.hocLuc = "Giỏi";
            }
            else if (this.dtb >= 6.5)
            {
                this.hocLuc = "Khá";
            }
            else if (this.dtb >= 5)
            {
                this.hocLuc = "Trung Bình";
            }
            else
            {
                this.hocLuc = "Yếu";
            }

            
            Console.WriteLine("{0,-25} {1, -15} {2, 0}", this.SVname, this.dtb , this.hocLuc);
        }

        public void ShowListSV()
        {
            Console.WriteLine("Nhập số sinh viên:");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] sv = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                sv[i] = new SinhVien();
                Console.WriteLine("Nhập sinh viên thứ {0}:", i+1);
                sv[i].nhapSV();
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("--------------------------***Thông Tin SV***--------------------------");
            Console.WriteLine("{0,-25} {1, -15} {2, 0}", "Họ và tên", "Điểm TB", "Học lực");
            for (int i = 0; i < n; i++)
            {
                sv[i].showSV();
            }
        }
    }

    
}
