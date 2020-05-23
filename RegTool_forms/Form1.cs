using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegTool_forms
{
    public partial class Form1 : Form
    {
        int numofShowvalue = 64;
        public Form1()
        {
            InitializeComponent();
        }


        private void button_translate_Click(object sender, EventArgs e)
        {
            

            if(textBox_input.TextLength> 0)
            {
                ComputeReg test = new ComputeReg(textBox_input.Text);
                label1.Text = "hex : " + test.getHex().ToString() + "\n\n" + test.getBinary();
                generateGriditem(2, test.getBinary());
            }

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void layer1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_test_Click(object sender, EventArgs e)
        {
            generateGriditem(2,"00100");
        }
        private void generateGriditem(int row,string ouputBinary)
        {
            ouputBinary = AddzeroLeft(ouputBinary);

            int numofshowrow = numofShowvalue / row, numofshowcol = numofShowvalue / numofshowrow;
            panel_main.BackgroundImage = null;
            panel_main.Controls.Clear();
            int strcount = 0;
            for (int c = 0; c < numofshowcol; c++)
            {
                for (int i = 0; i < numofshowrow; i++)
                {
                    TextBox textbox = new TextBox();
                    textbox.Name = "Label" + i.ToString();
                    textbox.Location = new Point(30 + i * 25, 40+c*80);
                    textbox.Text = ouputBinary[strcount].ToString();
                    textbox.Width = 15;
                    textbox.Height = 10;
                    panel_main.Controls.Add(textbox);
                    strcount++;
                }
            }
           
            panel_main.BackgroundImage = Image.FromFile(@"C:\Users\zhengwei\Pictures\test.png");
            panel_main.BackgroundImageLayout = ImageLayout.Stretch;
            panel_main.Show();
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
    }


}
