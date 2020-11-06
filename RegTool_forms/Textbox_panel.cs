using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegTool_forms
{
    
    class Textbox_panel
    {
        public TextBox[] textbox_panel;
        private int numofShowvalue=0;
        public Textbox_panel(int numofShowvalue_in,int row)
        {
            numofShowvalue = numofShowvalue_in;
            textbox_panel = new TextBox[numofShowvalue];
            Init_textbox_panel(row);
        }
        public void Init_textbox_panel(int row)
        {
            int numofshowrow = numofShowvalue / row, numofshowcol = numofShowvalue / numofshowrow;
            int textbox_count = 0;
            for (int c = 0; c < numofshowcol; c++)
            {
                for (int i = 0; i < numofshowrow; i++)
                {
                    textbox_panel[textbox_count] = new TextBox();
                    textbox_panel[textbox_count].Name = "Label" + i.ToString();
                    textbox_panel[textbox_count].Location = new Point(30 + i * 25, 40 + c * 80);
                    textbox_panel[textbox_count].Width = 15;
                    textbox_panel[textbox_count].Height = 10;
                    textbox_count++;
                }
            }
        }
        public void set_textbox_text(int index,String txt)
        {
            textbox_panel[index].Text=txt;
            if (Int32.Parse(txt) > 0)
            {
                textbox_panel[index].Font = new Font(textbox_panel[index].Font, FontStyle.Bold);
                textbox_panel[index].BackColor = Color.FromArgb(255, 209, 207, 205);
            }
            else
            {
                textbox_panel[index].Font = new Font(textbox_panel[index].Font, FontStyle.Regular);
                textbox_panel[index].BackColor = Color.FromArgb(255, 255, 255, 255);
            }
        }
        public void clear_textbox_text()
        {
            for(int index=0;index< numofShowvalue; index++)
            {
                textbox_panel[index].Text = "0";
                textbox_panel[index].Font = new Font(textbox_panel[index].Font, FontStyle.Regular);
                textbox_panel[index].BackColor = Color.FromArgb(255, 255, 255, 255);
            }
                
        }
        public int get_textbox_panel_num()
        {
            int return_val=0;
            string binary_str = "";
            for(int loc=0;loc< numofShowvalue;loc++)
            {
                binary_str += textbox_panel[loc].Text;
            }
            try {
                return_val = Convert.ToInt32(binary_str, 2);
            }
            catch (Exception xx)
            {
                return_val = 0;
            }            
            return return_val;
        }
    }
}
