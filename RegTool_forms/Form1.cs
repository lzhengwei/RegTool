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
using System.Windows.Input;

namespace RegTool_forms
{
    public partial class Form1 : Form
    {
        int numofShowvalue = 64, record_item_click_idx=0;
        ComputeReg main_computeReg = new ComputeReg();
        Textbox_panel main_textbox_Panel;
        public Form1()
        {
            InitializeComponent();
            groupBox1.Paint += PaintBorderlessGroupBox;
            panel_main.Paint += new PaintEventHandler(panel1_Paint);
            main_textbox_Panel = new Textbox_panel(numofShowvalue, 2);

            panel_main.Controls.AddRange(main_textbox_Panel.textbox_panel);

            listBox_record.Columns.Add("Hex");
            listBox_record.Columns.Add("Dec");
            listBox_record.Columns[0].Width = 95;
            listBox_record.Columns[1].Width = 95;

            listview_rightclick_menu.Items.Add("Check");
            listview_rightclick_menu.Items.Add("Save");
            listview_rightclick_menu.Items.Add("Remove");
            listview_rightclick_menu.Items.Add("Clear All");


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.None, Keys.Enter);       //Register Hotkey: Enter
        }
        private void FrmSale_Leave(object sender, EventArgs e)
        {
            HotKey.UnregisterHotKey(Handle, 100);       //Register Hotkey: Enter
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:       //Press Enter event
                            translate_func();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }      
        private void textbox_panel_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_dec.Text = ""; textBox_hex.Text = "";
        }

        private void translate_func()
        {
            if (Check_translate_is_fine())
            {
                print_new_number();
                if (listBox_record.Items.Count == 15)
                    listBox_record.Items.Clear();
               
                listBox_record.Items.Add(new ListViewItem(new string[] { "0x" + main_computeReg.getHex(), main_computeReg.getDec().ToString() }));
            }
        }

        private void print_new_number()
        {
            textBox_hex.Text = "";
            textBox_dec.Text = "";
            textBox_hex.Text = "0x" + main_computeReg.getHex();
            textBox_dec.Text = main_computeReg.getDec().ToString();
            Fill_in_binary(2, main_computeReg.getBinary());
        }

        private bool Check_translate_is_fine()
        {
            bool rv;
            String inputstr;
            ulong[] reveal_val = new ulong[3];
            try
            {
                inputstr = main_computeReg.inputstrprocess(textBox_dec.Text);
                reveal_val[1] = UInt64.Parse(inputstr);
            }
            catch (Exception e)
            {
            }
            try
            {
                inputstr = main_computeReg.inputstrprocess(textBox_hex.Text);
                reveal_val[0] = Convert.ToUInt64(inputstr, 16);
            }
            catch (Exception e)
            {
            }
            reveal_val[2] = main_textbox_Panel.get_textbox_panel_num();

            rv = main_computeReg.set_new_inputstr(reveal_val[get_which_diff(reveal_val)]);

            return rv;
        }

        private int get_which_diff(ulong[] reveal_val)
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
            MessageBox.Show("Test");
        }

        private void Fill_in_binary(int row,string ouputBinary)
        {
            ouputBinary = AddzeroLeft(ouputBinary);

            int numofshowrow = numofShowvalue / row, numofshowcol = numofShowvalue / numofshowrow;
            int strcount = 0;
            for (int c = 0; c < numofshowcol; c++)
            {
                for (int i = 0; i < numofshowrow; i++)
                {
                    main_textbox_Panel.set_textbox_text(strcount, ouputBinary[strcount].ToString());
                    strcount++;
                }
            }
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
            ulong binary_shift_left = main_computeReg.getDec();
            if (binary_shift_left!= null)
            {
                binary_shift_left *= 2;
                main_computeReg.set_new_inputstr(binary_shift_left);
                print_new_number();
            }
        }

        private void button_shift_right_Click(object sender, EventArgs e)
        {
            ulong binary_shift_right = main_computeReg.getDec();
            if (binary_shift_right != null)
            {
                binary_shift_right /= 2;
                main_computeReg.set_new_inputstr(binary_shift_right);
                print_new_number();

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
        private void button_clear_Click(object sender, EventArgs e)
        {
            main_textbox_Panel.clear_textbox_text();
            textBox_dec.Text = "";
            textBox_hex.Text = "";
            panel_main.Refresh();
        }

        private void button_sidemenu_Click(object sender, EventArgs e)
        {
            
            if(groupBox1.Location.X == 75)
            {
                groupBox1.Location = new Point(-5, groupBox1.Location.Y);
                listBox_record.Location = new Point(890, listBox_record.Location.Y);
                listBox_record.Size = new Size(200, 344);
                button_sidemenu.Text = "▶";
            }

            else
            {
                groupBox1.Location = new Point(75, groupBox1.Location.Y);
                listBox_record.Location = new Point(970, listBox_record.Location.Y);
                listBox_record.Size = new Size(88, 344);
                button_sidemenu.Text = "◀";
            }
                
            //this.Size = new System.Drawing.Size(this.Size.Width+50, this.Size.Height);
        }
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void listBox_record_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listBox_record.Columns[e.ColumnIndex].Width;
        }

        private void listBox_record_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var senderList = (ListView)sender;
            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                main_computeReg.set_new_inputstr(Convert.ToUInt64(clickedItem.Text, 16));
                print_new_number();
                //do something
            }
        }

        private void listBox_record_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        if(listBox_record.GetItemAt(e.X, e.Y)!=null)
                            record_item_click_idx = listBox_record.GetItemAt(e.X, e.Y).Index;
                        listview_rightclick_menu.Show(this, new Point(e.X + ((Control)sender).Left, e.Y + ((Control)sender).Top));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void textBox_hex_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_hex.BackColor = Color.FromArgb(252, 255, 204);
            textBox_dec.BackColor = Color.White;
        }

        private void textBox_dec_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_dec.BackColor = Color.FromArgb(252, 255, 204);
            textBox_hex.BackColor = Color.White;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                translate_func();
            }
        }

        private void listview_rightclick_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if (e.ClickedItem.Text == "Check")
            {
                if(listBox_record.Items.Count> record_item_click_idx)
                {
                    main_computeReg.set_new_inputstr(Convert.ToUInt64(listBox_record.Items[record_item_click_idx].Text, 16));
                    print_new_number();
                }
            }
            else if (e.ClickedItem.Text == "Save")
            {

            }
            else if (e.ClickedItem.Text == "Remove")
            {
                if (listBox_record.Items.Count > record_item_click_idx)
                {
                    listBox_record.Items.Remove(listBox_record.Items[record_item_click_idx]);
                }
                    
            }
            else if (e.ClickedItem.Text == "Clear All")
            {
                listBox_record.Items.Clear();
            }
        }

        private void button_translate_Click(object sender, EventArgs e)
        {
            translate_func();
        }
    }
}
