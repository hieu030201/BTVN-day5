using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi5
{
    internal class SoNguyenTo
    {
        public void timSoNguyenTo()
        {
        lap:
            Console.Write("Nhập số nguyên tố: ");
            int a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Số {0} không phải số nguyên dương. Nhan y để nhập lại ESC để thoát!", a);
                ConsoleKeyInfo keyInfor = Console.ReadKey();
                if(keyInfor.Key == ConsoleKey.Y)
                {
                    Console.WriteLine(Environment.NewLine);
                    goto lap;
                }
                else if(keyInfor.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

            }
            else
            {
                if(isPrimeNumber(a) == 1)
                {
                    Console.WriteLine("{0} là số nguyên tố!",a);
                }
                else
                {
                    Console.WriteLine("{0} không là số nguyên tố!", a);
                }
            }
            



        }

        public int isPrimeNumber(int a)
        {
            int i;
            int squareRoot = (int)Math.Sqrt(a);
            for (i = 2; i <= squareRoot; i++)
            {
                if (a % i == 0)
                {
                    return 0;
                }
            }
            return 1;
           
        }
    }
}
