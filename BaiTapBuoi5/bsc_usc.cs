using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi5
{
    internal class bsc_usc
    {
        public int bSCNN(int a,int b)
        {
            int bCNN = (a > b) ? a : b;
          
            while (true)
            {
                if (bCNN % a == 0 && bCNN % b == 0)
                {
                   return bCNN;
                }
                bCNN++;
            }
        }

        public int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int usc = b;
                b = a % b;
                a = usc;
            }

            return a;
        }

        public void BSC_USC()
        {
        lap:
            Console.WriteLine("Nhập 2 số a và b:");
            Console.Write("Nhập a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b:");
            int b = int.Parse(Console.ReadLine());

            if (a < 0 && b < 0 )
            {
                Console.WriteLine("Số {0} hoặc {1} không phải số nguyên dương. Nhan y để nhập lại ESC để thoát!", a,b);
                ConsoleKeyInfo keyInfor = Console.ReadKey();
                if (keyInfor.Key == ConsoleKey.Y)
                {
                    Console.WriteLine(Environment.NewLine);
                    goto lap;
                }
                else if (keyInfor.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

            }

            Console.Write("BSCNN cua {0} va {1} la: {2} \n", a, b, bSCNN(a, b));
            Console.Write("USCLN cua {0} va {1} la: {2} \n", a, b, USCLN(a, b));

        }
    }
}
