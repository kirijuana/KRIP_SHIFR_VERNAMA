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
          

         
           // byte[] result;
         
           
            StringBuilder sb = new StringBuilder();
            foreach (byte b in System.Text.Encoding.Unicode.GetBytes(text))
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
        
            string binaryStr_16 = sb.ToString();
            int size_binaryStr_8 = binaryStr_16.Length * 1 / 2;
            char[] binaryStr_8 = new char[size_binaryStr_8];
            int check_binaryStr_8 = 0;
            for (int i = 0, k = 0; i < binaryStr_16.Length; i++)
            {
                if(check_binaryStr_8 != 8)
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

            //StringBuilder bit = new StringBuilder();
            //Random rnd = new Random();
            //for (int i = 0; i < text.Length; i++)
            //    bit.Append(rnd.Next(0, 2));
            Random rnd = new Random();
           string bit = Convert.ToString(rnd.Next(256, 127), 2);
            keyBox.Text = bit.ToString();
            
            ShifrText.Text = binaryStr_16;
        }

        private void button_unShifr_Click(object sender, EventArgs e)
        {

        }
    }
}
