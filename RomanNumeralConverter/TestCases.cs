using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{
    public class TestCases
    {
        
        public List<string> testRomanToArabic()
        {
            string[] input = {null, "", "I", "V", "XXXIII", "DCCXLVII", "CMXXIX", "MCCXXXII", "MMMCMXCIX", "MMMMXI", "KMXI",
                "VX", "VL", "VC", "VD", "VM", "LC", "LD", "LM", "DM", "IL", "IC", "ID", "IM", "XD", "XM", "CXLV", "MIXI", "IXI", "MXIII", "MMMM", "IIII", "_I_XCMXCIX", "_VV"};
            int[] expectedOutput = { -1, -1, 1, 5, 33, 747, 929, 1232, 3999, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 145, -1, -1, 1013, -1, -1, 9999, 5005 };
            List<string> testMsg = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                int k = RomanNumbers4M.romanToArabic(input[i]);

                string result;
                if (k == expectedOutput[i])
                {
                    result = "OK";
                }
                else
                {
                    result = "NG";
                }

                result += " | Input: " + input[i] + " | Output: " + k.ToString();

                if (k != expectedOutput[i])
                {
                    result += " | Expected: " + expectedOutput[i];
                }

                testMsg.Add(result);
            }

            return testMsg;
        }
        
        public List<string> testArabicToRoman()
        {
            int[] input = { -1, 1, 4, 5, 9, 33, 44, 97, 400, 747, 891, 929, 1232, 3999, 4000, 5005, 9999 };
            string[] expectedOutput = { "Error", "I", "IV", "V", "IX", "XXXIII", "XLIV", "XCVII", "CD", "DCCXLVII", "DCCCXCI", "CMXXIX", "MCCXXXII", "MMMCMXCIX", "_I_V", "_VV", "_I_XCMXCIX" };
            List<string> testMsg = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string k = ObjectPairsSolution.convertToRoman(input[i]);

                string result;
                if (k == expectedOutput[i])
                {
                    result = "OK";
                }
                else
                {
                    result = "NG";
                }

                result += " | Input: " + input[i] + " | Output: " + k.ToString();

                if (k != expectedOutput[i])
                {
                    result += " | Expected: " + expectedOutput[i];
                }

                testMsg.Add(result);
            }

            return testMsg;
        }
    }
}
