using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi5
{
    internal class ThuaSoNT
    {
        public void tSNT()
        {
            Console.WriteLine("Nhập số nguyên n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Phân tích {0} thành các thừa số nguyên tố: ", n);
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
        }
    }
}
