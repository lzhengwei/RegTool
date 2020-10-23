using System;
using System.Linq;
using System.Windows.Forms;

namespace RegTool_forms
{
    public class ComputeReg
    {
        int value_dec, value_hex;
        string binary_str;
        
        public bool set_new_inputstr(string inputstr,int flag)
        {
            //flag - 0 : hex mode
            //flag - 1 : dec mode
            try
            {
                inputstr = inputstrprocess(inputstr);
                if (flag == 0)
                    value_dec = Convert.ToInt32(inputstr, 16);
                else
                {
                    value_dec = Int32.Parse(inputstr);
                    inputstr = Convert.ToString(value_dec, 16);
                }
                    
                binary_str = String.Join(String.Empty,
                inputstr.Select(
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
        public int getDec()
        {
            return value_dec;
        }
        public string getHex()
        {
            return Convert.ToString(value_dec,16);
        }
        public string getBinary()
        {
            return binary_str;
        }
        private string inputstrprocess(string str)
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
