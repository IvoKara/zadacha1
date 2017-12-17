using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var workedDaysInMonth = int.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var currency = double.Parse(Console.ReadLine());
            var averageProfit = 0;
            //usd to bgn//
            var monthProfit = workedDaysInMonth * moneyPerDay;
            var yearProfit = monthProfit * 12 + monthProfit * 2.5;
            var tax = (25/100) * yearProfit;
            var clearProfit = yearProfit * currency;
            var averageProfitPerDay = clearProfit / 365;
            Console.WriteLine(averageProfitPerDay);

        }
    }
}
