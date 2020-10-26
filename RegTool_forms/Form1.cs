using RegTool_forms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegTool_forms
{
    public partial class Form1 : Form
    {
        int numofShowvalue = 64;
        TextBox[] textbox_panel;
        ComputeReg main_computeReg = new ComputeReg();
        public Form1()
        {
            InitializeComponent();
            panel_main.Paint += new PaintEventHandler(panel1_Paint);
            textbox_panel = new TextBox[numofShowvalue];
            Init_textbox_panel(2);
        }

        private void Init_textbox_panel(int row)
        {

            int numofshowrow = numofShowvalue / row, numofshowcol = numofShowvalue / numofshowrow;
            panel_main.BackgroundImage = null;
            panel_main.Controls.Clear();
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
            panel_main.Controls.AddRange(textbox_panel);
            
        }

        private void button_translate_Click(object sender, EventArgs e)
        {
            //panel_main.creategraphics();
            
            //panel_main.Refresh();
            bool rv = false;
            if(textBox_dec.TextLength>0)
            {
                rv = main_computeReg.set_new_inputstr(textBox_dec.Text, 1);                
            }
                
            else if (textBox_hex.TextLength> 0)
            {
                rv = main_computeReg.set_new_inputstr(textBox_hex.Text,0);               
            }      
            if(rv)
            {
                textBox_hex.Text = "0x" + main_computeReg.getHex();
                textBox_dec.Text = main_computeReg.getDec().ToString();
                generateGriditem(2, main_computeReg.getBinary());
            }
            GC.Collect();

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void layer1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateGriditem(int row,string ouputBinary)
        {
            ouputBinary = AddzeroLeft(ouputBinary);

            int numofshowrow = numofShowvalue / row, numofshowcol = numofShowvalue / numofshowrow;
            //panel_main.BackgroundImage = null;
            //panel_main.Controls.Clear();
            int strcount = 0;
            for (int c = 0; c < numofshowcol; c++)
            {
                for (int i = 0; i < numofshowrow; i++)
                {
                    Textbox_fill_num(ouputBinary, strcount);
                    strcount++;
                }
            }

            //panel_main.BackgroundImage = Resources.regtool_background;
            //panel_main.BackgroundImageLayout = ImageLayout.Stretch;
            //panel_main.Show();
            panel_main.Refresh();
        }

        private void Textbox_fill_num(string ouputBinary, int strcount)
        {
            textbox_panel[strcount].Text = ouputBinary[strcount].ToString();
            if (Int32.Parse(ouputBinary[strcount].ToString()) > 0)
            {
                textbox_panel[strcount].Font = new Font(textbox_panel[strcount].Font, FontStyle.Bold);
                textbox_panel[strcount].BackColor = Color.FromArgb(255, 209, 207, 205);
            }
            else
            {
                textbox_panel[strcount].Font = new Font(textbox_panel[strcount].Font, FontStyle.Regular);
                textbox_panel[strcount].BackColor = Color.FromArgb(255, 255, 255, 255);
            }
            
        }

        private string AddzeroLeft(string ouputBinary)
        {
            int addzeronum = numofShowvalue - ouputBinary.Length;
            for (int i = 0; i < addzeronum; i++)
            {
                ouputBinary = $"0{ouputBinary}";
            }

            return ouputBinary;
        }

        private void button_shift_left_Click(object sender, EventArgs e)
        {          
            int binary_shift_left = main_computeReg.getDec();
            if (binary_shift_left!= null)
            {
                binary_shift_left *= 2;
                main_computeReg.set_new_inputstr(Convert.ToString(binary_shift_left, 16),0);
                generateGriditem(2, main_computeReg.getBinary());
                textBox_hex.Text = "0x" + main_computeReg.getHex();
                textBox_dec.Text = main_computeReg.getDec().ToString();
            }
        }

        private void button_shift_right_Click(object sender, EventArgs e)
        {
            int binary_shift_right = main_computeReg.getDec();
            if (binary_shift_right != null)
            {
                binary_shift_right /= 2;
                main_computeReg.set_new_inputstr(Convert.ToString(binary_shift_right, 16),0);
                generateGriditem(2, main_computeReg.getBinary());
                textBox_hex.Text = "0x" + main_computeReg.getHex();
                textBox_dec.Text = main_computeReg.getDec().ToString();

            }
        }

        private void textBox_hex_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_dec.Text = "";
        }

        private void textBox_dec_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_hex.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {           
            var p = sender as Panel;
            var g = e.Graphics;
            FontFamily fam = new FontFamily("Calibri");
            var sbr = new SolidBrush(Color.Blue);
            Font font = new System.Drawing.Font(fam, 12, FontStyle.Bold);
            int loc_x=0, loc_y = 0;
            for(int py=0;py<2;py++)
            {
                for (int px = 0; px < 8; px++)
                {
                    loc_x = px * 100;
                    loc_y = py * 80;
                    g.DrawRectangle(new Pen(Color.FromArgb(255, Color.Black), 1), 28 + loc_x, 30 + loc_y, 94, 45);
                    g.DrawString((63 - (4 * px)- (32*py)).ToString(), font, sbr, 28 + loc_x, 80 + loc_y);
                    g.DrawString((63 - (4 * px) - 3 - (32 * py)).ToString(), font, sbr, 100 + loc_x, 80 + loc_y);
                }
            }
            g.Dispose();
            GC.Collect();
        }
    }


}
