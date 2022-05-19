using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{
    public class ObjectPairsSolution
    {
        public static string convertToRoman(int num)
        {
            Dictionary<string, int> romanNumObj = new Dictionary<string, int>(){
                { "I", 1 },
                { "IV", 4},
                { "V", 5 },
                { "VI",6 },
                { "IX", 9 },
                { "X", 10 },
                { "XL", 40 },
                { "L", 50 },
                { "LX", 60 },
                { "XC", 90 },
                { "C", 100 },
                { "CD", 400 },
                { "D", 500 },
                { "DC", 600 },
                { "CM", 900 },
                { "M", 1000 },
                { "_I_V", 4000 },
                { "_V", 5000 },
                { "_V_I", 6000 },
                { "_I_X", 9000 },
                { "_X", 10000 },
                { "_X_L", 40000 },
                { "_L", 50000 },
                { "_L_X", 60000 },
                { "_X_C", 90000 },
                { "_C", 100000 },
                { "_C_D", 400000 },
                { "_D", 500000 },
                { "_D_C", 600000 },
                { "_C_M", 900000 },
                { "_M", 1000000 }
            };

            var romanKeys = romanNumObj.Keys.ToArray();
            var romanValues = romanNumObj.Values.ToArray();

            List<string> romanNumArr = new List<string>();

            for (int i=romanValues.Length-1; i>=0; i--) {
                // what I did was from the bottom of the object to subtract with number
                // so greatest numbers subtract the given num
                while (num - romanValues[i] >= 0) {
                    num = num - romanValues[i];
                    romanNumArr.Add(romanKeys[i]);
                }
            }

            return string.Join("", romanNumArr);
        }
    }
}
