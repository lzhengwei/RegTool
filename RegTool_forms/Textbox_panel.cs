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
        public Textbox_panel(int numofShowvalue,int row)
        {
            textbox_panel = new TextBox[numofShowvalue];
            Init_textbox_panel(numofShowvalue, row);
        }
        public void Init_textbox_panel(int numofShowvalue, int row)
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
                    textbox_panel[textbox_count].MouseClick += textbox_panel_MouseClick;
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
        private void textbox_panel_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
