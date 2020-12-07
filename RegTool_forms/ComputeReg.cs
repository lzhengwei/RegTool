using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RegTool_forms
{
    public class ComputeReg
    {
        ulong value_dec;
        string binary_str,hex_str;
        
        public bool set_new_inputstr(ulong inputdec)
        {
            //flag - 0 : hex mode
            //flag - 1 : dec mode
            try
            {
                value_dec = inputdec;
                hex_str = value_dec.ToString("X");
                binary_str = String.Join(String.Empty,
                hex_str.Select(
                c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                ));
            }
            catch (Exception e)
            {
                MessageBox.Show("Input invalid");
                return false;
            }            
            return true;
        }
        public ulong getDec()
        {
            return value_dec;
        }
        public string getHex()
        {
            return hex_str;
        }
        public string getBinary()
        {
            return binary_str;
        }
        public string inputstrprocess(string str)
        {
            if (str[0] == '0' && (str[1] == 'x' || str[1] == 'X'))
                str = str.Substring(2);
           
            for (int ch = 0; ch < str.Length; ch++)
            {
                if (!check_is_hex(str[ch]))
                {
                    str = str.Remove(ch, 1);
                    ch--;
                }
            }

            str = str.PadLeft(4, '0');
            return str;
        }
        private bool check_is_hex(char str)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str.ToString(), @"\A\b[0-9a-fA-F]+\b\Z");
        }
        
    }
    
}
