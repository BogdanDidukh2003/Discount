using System.Collections.Generic;
using System.Linq;

namespace Discount
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                return;
            }
            string[] data = FileReader.ReadFile(args[0]);
            List<int> prices = FileReader.ConvertStringToInt(data[0]).ToList();
            int discount = FileReader.ConvertStringToInt(data[1])[0];
            string result = DiscountCounter.ApplyDiscount(prices, discount);
            FileReader.WriteFile(args[0].Replace(".in", ".out"), result);
        }
    }
}