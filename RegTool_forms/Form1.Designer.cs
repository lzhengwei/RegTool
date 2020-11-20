namespace RegTool_forms
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_sidemenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_translate = new System.Windows.Forms.Button();
            this.button_shift_left = new System.Windows.Forms.Button();
            this.button_shift_right = new System.Windows.Forms.Button();
            this.textBox_hex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_dec = new System.Windows.Forms.TextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_record = new System.Windows.Forms.ListBox();
            this.menuStrip_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip_main.TabIndex = 1;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layer1ToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // layer1ToolStripMenuItem
            // 
            this.layer1ToolStripMenuItem.Name = "layer1ToolStripMenuItem";
            this.layer1ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.layer1ToolStripMenuItem.Text = "layer1";
            this.layer1ToolStripMenuItem.Click += new System.EventHandler(this.layer1ToolStripMenuItem_Click);
            // 
            // button_sidemenu
            // 
            this.button_sidemenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_sidemenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sidemenu.Location = new System.Drawing.Point(873, 12);
            this.button_sidemenu.Name = "button_sidemenu";
            this.button_sidemenu.Size = new System.Drawing.Size(21, 344);
            this.button_sidemenu.TabIndex = 15;
            this.button_sidemenu.Text = "<\r\n<\r\n<\r\n";
            this.button_sidemenu.UseVisualStyleBackColor = true;
            this.button_sidemenu.Click += new System.EventHandler(this.button_sidemenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(26, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(841, 105);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(60, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 71);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hex";
            // 
            // button_translate
            // 
            this.button_translate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_translate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_translate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_translate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_translate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_translate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_translate.Location = new System.Drawing.Point(411, 261);
            this.button_translate.Name = "button_translate";
            this.button_translate.Size = new System.Drawing.Size(184, 74);
            this.button_translate.TabIndex = 0;
            this.button_translate.Text = "Translate";
            this.button_translate.UseVisualStyleBackColor = false;
            this.button_translate.Click += new System.EventHandler(this.button_translate_Click);
            // 
            // button_shift_left
            // 
            this.button_shift_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_shift_left.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_shift_left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button_shift_left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_shift_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shift_left.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_shift_left.Location = new System.Drawing.Point(629, 257);
            this.button_shift_left.Name = "button_shift_left";
            this.button_shift_left.Size = new System.Drawing.Size(71, 37);
            this.button_shift_left.TabIndex = 6;
            this.button_shift_left.Text = "<<<";
            this.button_shift_left.UseVisualStyleBackColor = false;
            this.button_shift_left.Click += new System.EventHandler(this.button_shift_left_Click);
            // 
            // button_shift_right
            // 
            this.button_shift_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_shift_right.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_shift_right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button_shift_right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_shift_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shift_right.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_shift_right.Location = new System.Drawing.Point(629, 298);
            this.button_shift_right.Name = "button_shift_right";
            this.button_shift_right.Size = new System.Drawing.Size(71, 37);
            this.button_shift_right.TabIndex = 7;
            this.button_shift_right.Text = ">>>";
            this.button_shift_right.UseVisualStyleBackColor = false;
            this.button_shift_right.Click += new System.EventHandler(this.button_shift_right_Click);
            // 
            // textBox_hex
            // 
            this.textBox_hex.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hex.Location = new System.Drawing.Point(69, 289);
            this.textBox_hex.Name = "textBox_hex";
            this.textBox_hex.Size = new System.Drawing.Size(140, 26);
            this.textBox_hex.TabIndex = 10;
            this.textBox_hex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_hex_KeyDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(225, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dec";
            // 
            // textBox_dec
            // 
            this.textBox_dec.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dec.Location = new System.Drawing.Point(239, 289);
            this.textBox_dec.Name = "textBox_dec";
            this.textBox_dec.Size = new System.Drawing.Size(140, 26);
            this.textBox_dec.TabIndex = 9;
            this.textBox_dec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_dec_KeyDown);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Controls.Add(this.button_clear);
            this.panel_main.Location = new System.Drawing.Point(26, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(841, 226);
            this.panel_main.TabIndex = 5;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(760, 182);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(71, 37);
            this.button_clear.TabIndex = 14;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.panel_main);
            this.groupBox1.Controls.Add(this.button_sidemenu);
            this.groupBox1.Controls.Add(this.textBox_dec);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_hex);
            this.groupBox1.Controls.Add(this.button_shift_right);
            this.groupBox1.Controls.Add(this.button_shift_left);
            this.groupBox1.Controls.Add(this.button_translate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(75, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 366);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // listBox_record
            // 
            this.listBox_record.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_record.FormattingEnabled = true;
            this.listBox_record.ItemHeight = 20;
            this.listBox_record.Location = new System.Drawing.Point(975, 39);
            this.listBox_record.MultiColumn = true;
            this.listBox_record.Name = "listBox_record";
            this.listBox_record.Size = new System.Drawing.Size(100, 344);
            this.listBox_record.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 395);
            this.Controls.Add(this.listBox_record);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_main;
            this.Name = "Form1";
            this.Text = "RegTool";
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layer1ToolStripMenuItem;
        private System.Windows.Forms.Button button_sidemenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_translate;
        private System.Windows.Forms.Button button_shift_left;
        private System.Windows.Forms.Button button_shift_right;
        private System.Windows.Forms.TextBox textBox_hex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_dec;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_record;
    }
}

