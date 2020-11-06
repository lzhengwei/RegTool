﻿using RegTool_forms.Properties;
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
        Textbox_panel main_textbox_Panel;
        public Form1()
        {
            InitializeComponent();
            panel_main.Paint += new PaintEventHandler(panel1_Paint);
            main_textbox_Panel = new Textbox_panel(numofShowvalue, 2);
            //textbox_panel = new TextBox[numofShowvalue];
            //Init_textbox_panel(2);
            panel_main.Controls.AddRange(main_textbox_Panel.textbox_panel);

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
                    textbox_panel[textbox_count].MouseClick += textbox_panel_MouseClick;
                    textbox_count++;
                }
            }
            panel_main.Controls.AddRange(textbox_panel);
            
        }

        private void textbox_panel_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_dec.Text = ""; textBox_hex.Text = "";
        }

        private void button_translate_Click(object sender, EventArgs e)
        {
            translate_func();
        }

        private void translate_func()
        {
            if (Check_translate_is_fine())
            {
                textBox_hex.Text = "0x" + main_computeReg.getHex();
                textBox_dec.Text = main_computeReg.getDec().ToString();
                generateGriditem(2, main_computeReg.getBinary());
            }
            //GC.Collect();
        }

        private bool Check_translate_is_fine()
        {
            bool rv;
            String inputstr;
            int[] reveal_val = new int[3];
            try
            {
                inputstr = main_computeReg.inputstrprocess(textBox_dec.Text);
                reveal_val[1] = Int32.Parse(inputstr);
            }
            catch (Exception e)
            {
            }
            try
            {
                inputstr = main_computeReg.inputstrprocess(textBox_hex.Text);
                reveal_val[0] = Convert.ToInt32(inputstr, 16);
            }
            catch (Exception e)
            {
            }
            reveal_val[2] = main_textbox_Panel.get_textbox_panel_num();

            rv = main_computeReg.set_new_inputstr(reveal_val[get_which_diff(reveal_val)]);

            return rv;
        }

        private int get_which_diff(int[] reveal_val)
        {
            int return_index=0;
            if (reveal_val[0] == reveal_val[1])
            {
                return_index = 2;
            }
            else if (reveal_val[0] == reveal_val[2])
            {
                return_index = 1;
            }
            else
            {
                return_index = 0;
            }

            return return_index;
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
                    main_textbox_Panel.set_textbox_text(strcount, ouputBinary[strcount].ToString());
                    strcount++;
                }
            }

            //panel_main.BackgroundImage = Resources.regtool_background;
            //panel_main.BackgroundImageLayout = ImageLayout.Stretch;
            //panel_main.Show();
            panel_main.Refresh();
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
                main_computeReg.set_new_inputstr(binary_shift_left);
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
                main_computeReg.set_new_inputstr(binary_shift_right);
                generateGriditem(2, main_computeReg.getBinary());
                textBox_hex.Text = "0x" + main_computeReg.getHex();
                textBox_dec.Text = main_computeReg.getDec().ToString();

            }
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

        private void textBox_hex_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString().Equals("Return"))
            {
                translate_func();
            }
        }

        private void textBox_dec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                translate_func();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            main_textbox_Panel.clear_textbox_text();
            panel_main.Refresh();
        }
    }


}
