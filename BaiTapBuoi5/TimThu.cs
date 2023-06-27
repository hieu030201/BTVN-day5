using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi5
{
    internal class TimThu
    {
        public void timThu()
        {
            Console.WriteLine("Enter a day in 2023");
            Console.Write("Enter date: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());
           
            if (DateTime.TryParse($"{month}/{day}/{2023}", out DateTime date))
            {
                Console.WriteLine("Valid date.");

                DateTime dateTime = new DateTime(2023, month, day);
                Console.WriteLine("It's " + dateTime.DayOfWeek);
            }
            else
            {
                Console.WriteLine("Ngày tháng không hợp lệ.");
            }
        }
    }
}
