using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //SinhVien sv = new SinhVien();
            //sv.ShowListSV();

            //SoNguyenTo soNT = new SoNguyenTo();
            //soNT.timSoNguyenTo();

            bsc_usc ub = new bsc_usc();
            ub.BSC_USC();





            Console.ReadKey();
        }
       
    }
}
