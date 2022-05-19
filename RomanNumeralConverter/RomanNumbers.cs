using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RomanNumeralConverter
{
    public class RomanNumbers
    {
        public static int maxIntegerLimit = 4000;

        public static int romanToArabic(string roman)
        {
            int ans = 0;
            bool valueCheck = false;
            char[] romanCharacter = { 'I','V', 'X', 'L', 'C', 'D', 'M' };
            List<int> skipIndex = new List<int>();
            int penaltyCount = 0;
            List<int> romanCharacterLevel = new List<int>();

            if (string.IsNullOrWhiteSpace(roman))
                return -1;

            // Check start from behind
            for (int i = roman.Length-1; i >= 0; i--)
            {
                char currentCharacter = roman[i];
                char nextCharacter = '\0';
                int currentCharacterIndex = Array.IndexOf(romanCharacter, currentCharacter);
                int nextCharacterIndex = currentCharacterIndex;

                // Check fault letter
                if (romanCharacter.Contains(currentCharacter) == false)
                {
                    ans = -1;
                    break;
                }

                if (skipIndex.Contains(i))
                {
                    continue;
                }

                if (i-1 >= 0)
                {
                    nextCharacter = roman[i-1];
                    nextCharacterIndex = Array.IndexOf(romanCharacter, nextCharacter);

                    if (romanCharacter.Contains(nextCharacter) == false)
                    {
                        ans = -1;
                        break;
                    }
                }
                
                // Check if next roman Character is smaller than current one
                // Allow for special handling case
                if (nextCharacterIndex < currentCharacterIndex)
                {
                    penaltyCount += 1;
                }

                if (currentCharacter == 'I')
                {
                    romanCharacterLevel.Add(1);
                    ans += 1;
                    valueCheck = true;
                    continue;
                }

                if (currentCharacter == 'V')
                {
                    // Special handling 4 value
                    if (nextCharacter == 'I')
                    {
                        romanCharacterLevel.Add(1);
                        ans += 4;
                        valueCheck = true;
                        penaltyCount -= 1;
                        skipIndex.Add(i - 1);
                        continue;
                    }

                    romanCharacterLevel.Add(2);
                    ans += 5;
                    valueCheck = true;
                    continue;
                }

                if (currentCharacter == 'X')
                {
                    // Special handling 9 value
                    if (nextCharacter == 'I')
                    {
                        romanCharacterLevel.Add(2);
                        ans += 9;
                        valueCheck = true;
                        penaltyCount -= 1;
                        skipIndex.Add(i - 1);
                        continue;
                    }

                    romanCharacterLevel.Add(3);
                    ans += 10;
                    valueCheck = true;
                    continue;
                }

                if (currentCharacter == 'L')
                {
                    // Special handling 4x value
                    if (nextCharacter == 'X')
                    {
                        romanCharacterLevel.Add(3);
                        ans += 40;
                        valueCheck = true;
                        penaltyCount -= 1;
                        skipIndex.Add(i - 1);
                        continue;
                    }

                    romanCharacterLevel.Add(4);
                    ans += 50;
                    valueCheck = true;
                    continue;
                }

                if (currentCharacter == 'C')
                {
                    // Special handling 9x value
                    if (nextCharacter == 'X')
                    {
                        romanCharacterLevel.Add(4);
                        ans += 90;
                        valueCheck = true;
                        penaltyCount -= 1;
                        skipIndex.Add(i - 1);
                        continue;
                    }

                    romanCharacterLevel.Add(5);
                    ans += 100;
                    valueCheck = true;
                    continue;
                }

                if (currentCharacter == 'D')
                {
                    // Special handling 4xx value
                    if (nextCharacter == 'C')
                    {
                        romanCharacterLevel.Add(5);
                        ans += 400;
                        valueCheck = true;
                        penaltyCount -= 1;
                        skipIndex.Add(i - 1);
                        continue;
                    }

                    romanCharacterLevel.Add(6);
                    ans += 500;
                    valueCheck = true;
                    continue;
                }

                if (currentCharacter == 'M')
                {
                    // Special handling 9xx value
                    if (nextCharacter == 'C')
                    {
                        romanCharacterLevel.Add(6);
                        ans += 900;
                        valueCheck = true;
                        penaltyCount -= 1;
                        skipIndex.Add(i - 1);
                        continue;
                    }

                    romanCharacterLevel.Add(7);
                    ans += 1000;
                    valueCheck = true;
                    continue;
                }
            }

            if (valueCheck == false)
                ans = -1;

            if (ans >= maxIntegerLimit)
                ans = -1;

            if (penaltyCount > 0)
                ans = -1;

            // no repeat more than 3 times on same level
            var q = from x in romanCharacterLevel
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };

            foreach (var x in q)
            {
                if (x.Count > 3)
                {
                    ans = -1;
                }
            }

            Debug.WriteLine(roman + " romanCharacterLevel = " + string.Join(",", romanCharacterLevel));

            // double check answer from arabicToRoman
            string testAnswer = arabicToRoman(ans);
            if (testAnswer != roman)
                ans = -1;

            return ans;
        }

        public static string arabicToRoman(int arabic)
        {
            string ans = "";
            
            while (arabic > 0)
            {
                // Error handling
                if (arabic >= maxIntegerLimit)
                {
                    ans = "Error";
                    break;
                }

                // Differentiate special handling for value divisible by 4
                bool specialHandlingCase = false;
                int firstDigit = (int)(arabic / Math.Pow(10, (int)Math.Floor(Math.Log10(arabic))));

                // First digit checking for apply reverse method
                if ((firstDigit % 4 == 0 && firstDigit != 8) || firstDigit % 9 == 0)
                {
                    specialHandlingCase = true;
                }
                
                if (arabic >= 1000)
                {
                    ans += "M";
                    arabic -= 1000;
                    continue;
                }

                // Special handling 9xx
                if (specialHandlingCase == true && arabic - 900 >= 0)
                {
                    ans += "CM";
                    arabic -= 900;
                    continue;
                }
                else if (specialHandlingCase == false && arabic - 500 >= 0)
                {
                    ans += "D";
                    arabic -= 500;
                    continue;
                }

                // Special handling 4xx
                if (specialHandlingCase == true && arabic - 400 >= 0)
                {
                    ans += "CD";
                    arabic -= 400;
                    continue;
                }
                else if (specialHandlingCase == false && arabic - 100 >= 0)
                {
                    ans += "C";
                    arabic -= 100;
                    continue;
                }

                // Special handling 9x
                if (specialHandlingCase == true && arabic - 90 >= 0)
                {
                    ans += "XC";
                    arabic -= 90;
                    continue;
                }
                else if (specialHandlingCase == false && arabic - 50 >= 0)
                {
                    ans += "L";
                    arabic -= 50;
                    continue;
                }

                // Special handling 4x
                if (specialHandlingCase == true && arabic - 40 >= 0)
                {
                    ans += "XL";
                    arabic -= 40;
                    continue;
                }
                else if (specialHandlingCase == false && arabic - 10 >= 0)
                {
                    ans += "X";
                    arabic -= 10;
                    continue;
                }

                // Special handling 9
                if (specialHandlingCase == true && arabic - 9 >= 0)
                {
                    ans += "IX";
                    arabic -= 9;
                    continue;
                }
                else if (specialHandlingCase == false && arabic < 9 && arabic - 5 >= 0)
                {
                    ans += "V";
                    arabic -= 5;
                    continue;
                }

                // Special handling 4
                if (specialHandlingCase == true && arabic < 5)
                {
                    ans += "IV";
                    arabic -= 4;
                    continue;
                }
                else
                {
                    ans += "I";
                    arabic -= 1;
                    continue;
                }
            }

            if (string.IsNullOrWhiteSpace(ans))
                ans = "Error";

            return ans;
        }
    }
}
