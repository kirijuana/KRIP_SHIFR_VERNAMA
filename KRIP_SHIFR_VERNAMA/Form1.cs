using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace KRIP_SHIFR_VERNAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Shifr_Click(object sender, EventArgs e)
        {
            char[] text = Text.Text.ToCharArray();
            char[] binaryStr_key = keyBox.Text.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (byte b in System.Text.Encoding.Unicode.GetBytes(text))
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));

            string binaryStr_16 = sb.ToString();
            int size_binaryStr_8 = binaryStr_16.Length * 1 / 2;
            char[] binaryStr_8 = new char[size_binaryStr_8];
            int check_binaryStr_8 = 0;
            for (int i = 0, k = 0; i < binaryStr_16.Length; i++)
            {
                if (check_binaryStr_8 != 8)
                {
                    check_binaryStr_8++;
                    binaryStr_8[k] = binaryStr_16[i];
                    k++;
                }
                else
                {
                    i = i + 8 - 1;
                    check_binaryStr_8 = 0;
                }
            }
            char[] binaryStr_Shifr = new char[size_binaryStr_8]; 
            for (int i = 0; i < binaryStr_8.Length; i++)
            {
                if ((binaryStr_8[i] == '1' && binaryStr_key[i] == '1') || (binaryStr_8[i] == '0' && binaryStr_key[i] == '0'))
                    binaryStr_Shifr[i] = '0';
                if ((binaryStr_8[i] == '1' && binaryStr_key[i] == '0') || (binaryStr_8[i] == '0' && binaryStr_key[i] == '1'))
                    binaryStr_Shifr[i] = '1';
            }


            string text1 = new string(binaryStr_Shifr);
            ShifrText.Text = text1;
           
        }

        private void button_unShifr_Click(object sender, EventArgs e)
        {
            char[] binaryStr_Shifr = Text.Text.ToCharArray();
            char[] binaryStr_key = keyBox.Text.ToCharArray();
         
            char[] text = new char[binaryStr_Shifr.Length];
            for (int i = 0; i < text.Length; i++)
            {
                if ((binaryStr_Shifr[i] == '1' && binaryStr_key[i] == '1') || (binaryStr_Shifr[i] == '0' && binaryStr_key[i] == '0'))
                    text[i] = '0';
                if ((binaryStr_Shifr[i] == '1' && binaryStr_key[i] == '0') || (binaryStr_Shifr[i] == '0' && binaryStr_key[i] == '1'))
                    text[i] = '1';
            }
            string text1 = new string(text);
            var stringArray = Enumerable.Range(0, text1.Length / 8).Select(i => Convert.ToByte(text1.Substring(i * 8, 8), 2)).ToArray();
            var str = Encoding.ASCII.GetString(stringArray);          
            ShifrText.Text = str;
        }

        private void GenerationKey_Click(object sender, EventArgs e)
        {
            char[] text = Text.Text.ToCharArray();
            char[] binaryStr_key = new char[text.Length * 8];
            Random rnd = new Random();
            int value = 0;
            for (int i = 0; i < binaryStr_key.Length; i++)
            {

                value = rnd.Next(0, 2);
                binaryStr_key[i] = Convert.ToChar(value.ToString()); ;
            }
            string text1 = new string(binaryStr_key);
            BoxGenerationKey.Text = text1;
        }
    }
}
