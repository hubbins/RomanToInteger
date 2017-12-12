using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace RomanToInteger
{
    public class Solution
    {
        private static readonly Dictionary<char, int> Numerals = new Dictionary<char, int>()
        {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
        };

        public int RomanToInt(string s)
        {
            var total = 0;  // accumulator
            var i = 0;      // string index

            // accumulate total as we inspect each numeral
            // if smaller numeral before larger numeral means subtract smaller from larger, then add result, else add the numeral

            while (i < s.Length)
            {
                // look at current numeral and next numeral, if current is less process both together
                if (i < s.Length - 1 && Numerals[s[i]] < Numerals[s[i + 1]])
                {
                    total += (Numerals[s[i + 1]] - Numerals[s[i]]);
                    i++;    // skip an extra numeral, we processed two
                }
                else
                {
                    total += Numerals[s[i]];
                }

                i++;
            }

            return total;
        }
    }
}
