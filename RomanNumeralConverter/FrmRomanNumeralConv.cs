using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralConverter
{
    public partial class FrmRomanNumeralConv : Form
    {
        public FrmRomanNumeralConv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestCases tcs = new TestCases();
            List<string> message = tcs.testRomanToArabic();

            for (int i = 0; i < message.Count; i++)
            {
                lsbMessage.Items.Add(message[i]);
            }

            lsbMessage.SelectedIndex = lsbMessage.Items.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestCases tcs = new TestCases();
            List<string> message = tcs.testArabicToRoman();

            for (int i = 0; i < message.Count; i++)
            {
                lsbMessage.Items.Add(message[i]);
            }

            lsbMessage.SelectedIndex = lsbMessage.Items.Count - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lsbMessage.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputTextString = inputText.Text;

            if (string.IsNullOrWhiteSpace(inputTextString))
            {
                MessageBox.Show("Please input text for testing");
            }
            else
            {
                int arabicNumber;
                bool testNumber = int.TryParse(inputTextString, out arabicNumber);
                string outputText;

                if (testNumber == true)
                {
                    outputText = RomanNumbers4M.arabicToRoman(arabicNumber);
                }
                else
                {
                    int arabicAnswer = RomanNumbers4M.romanToArabic(inputTextString);

                    if (arabicAnswer == -1)
                    {
                        outputText = "Error";
                    }
                    else
                    {
                        outputText = arabicAnswer.ToString();
                    }
                }
                
                string result = "Input: " + inputTextString + " | Output: " + outputText;

                lsbMessage.Items.Add(result);
            }

            lsbMessage.SelectedIndex = lsbMessage.Items.Count - 1;
        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                string s = lsbMessage.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, s);
            }
        }
    }
}
