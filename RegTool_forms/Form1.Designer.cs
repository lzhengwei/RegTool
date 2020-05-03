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
            this.button_translate = new System.Windows.Forms.Button();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_test = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.menuStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_translate
            // 
            this.button_translate.Location = new System.Drawing.Point(479, 347);
            this.button_translate.Name = "button_translate";
            this.button_translate.Size = new System.Drawing.Size(114, 53);
            this.button_translate.TabIndex = 0;
            this.button_translate.Text = "Translate";
            this.button_translate.UseVisualStyleBackColor = true;
            this.button_translate.Click += new System.EventHandler(this.button_translate_Click);
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(799, 24);
            this.menuStrip_main.TabIndex = 1;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layer1ToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // layer1ToolStripMenuItem
            // 
            this.layer1ToolStripMenuItem.Name = "layer1ToolStripMenuItem";
            this.layer1ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.layer1ToolStripMenuItem.Text = "layer1";
            this.layer1ToolStripMenuItem.Click += new System.EventHandler(this.layer1ToolStripMenuItem_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(273, 364);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(135, 35);
            this.textBox_input.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(271, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 117);
            this.label1.TabIndex = 3;
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(135, 364);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(75, 23);
            this.button_test.TabIndex = 4;
            this.button_test.Text = "button1";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // panel_main
            // 
            this.panel_main.Location = new System.Drawing.Point(0, 27);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(799, 314);
            this.panel_main.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 444);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.button_translate);
            this.Controls.Add(this.menuStrip_main);
            this.MainMenuStrip = this.menuStrip_main;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_translate;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layer1ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Panel panel_main;
    }
}

