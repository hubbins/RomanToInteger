using System;
using System.Collections.Generic;
using System.Text;

namespace RomanToInteger
{
    public class Solution
    {
        public enum Numerals { I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000 }

        public int RomanToInt(string s)
        {
            int total = 0;  // accumulator
            int i = 0;      // string index

            // accumulate total as we inspect each numeral
            // smaller numeral before larger numeral means subtraction, else addition

            while (i < s.Length)
            {
                // look at current numeral and next numeral, if current is less process both together
                if (i < s.Length - 1 && GetValue(s[i]) < GetValue(s[i + 1]))
                {
                    total += (GetValue(s[i + 1]) - GetValue(s[i]));
                    i++;    // skip an extra numeral, we processed two
                }
                else
                {
                    total += GetValue(s[i]);
                }

                i++;
            }

            return total;
        }

        private int GetValue(char numeral)
        {
            return (int)Enum.Parse(typeof(Numerals), "" + numeral);
        }
    }
}
