using System;
using System.Collections.Generic;

namespace Discount
{
    public static class DiscountCounter
    {
        public static string ApplyDiscount(List<int> inputList, int discountPercent)
        {
            inputList.Sort();
            inputList.Reverse();
            float sum = 0f;
            for (int i = 0; i < inputList.Count; i++)
            {
                if (i < inputList.Count / 3)
                {
                    sum += inputList[i] * (1f - (discountPercent / 100f));
                }
                else
                {
                    sum += inputList[i];
                }
            }

            string decimalSum = Convert.ToInt32(sum*100f).ToString();
            return decimalSum.Insert(decimalSum.Length - 2, ".");
        }
    }
}