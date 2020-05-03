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
            inputstr=inputstr.PadLeft(4, '0');
            value_dec = Convert.ToInt32(inputstr, 16);
            if (inputstr[0] == '0' && (inputstr[1] == 'x' || inputstr[1] == 'X'))
                inputstr = inputstr.Substring(2, inputstr.Length - 2);
            try {
                binary_str = String.Join(String.Empty,
                inputstr.Select(
                c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                ));
            }
            catch (Exception e)
            {
                MessageBox.Show("Input invalid");
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
