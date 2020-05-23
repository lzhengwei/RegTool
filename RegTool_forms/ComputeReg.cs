using System;
using System.Linq;
using System.Windows.Forms;

namespace RegTool_forms
{
    public class ComputeReg
    {
        int value_dec, value_hex;
        string binary_str;
        public ComputeReg(string inputstr)
        {
            inputstr = inputstrprocess(inputstr);
            value_dec = Convert.ToInt32(inputstr, 16);
            try
            {
                binary_str = String.Join(String.Empty,
                inputstr.Select(
                c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                ));
            }
            catch (Exception e)
            {
                MessageBox.Show("Input invalid");
            }

            string inputstrprocess(string str)
            {
                if (str[0] == '0' && (str[1] == 'x' || str[1] == 'X'))
                    str = str.Substring(2);
                str = str.PadLeft(4, '0');
                return str;
            }
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

    }
    
}
