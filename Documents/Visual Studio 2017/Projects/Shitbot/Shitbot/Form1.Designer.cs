namespace Shitbot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.setIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.webBrowser5 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Left;
            this.webBrowser1.Location = new System.Drawing.Point(0, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(106, 375);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://gaiaonline.com/auth/", System.UriKind.Absolute);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripComboBox1,
            this.setIntervalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "500",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "3500",
            "4000",
            "4500",
            "5000"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // setIntervalToolStripMenuItem
            // 
            this.setIntervalToolStripMenuItem.Name = "setIntervalToolStripMenuItem";
            this.setIntervalToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.setIntervalToolStripMenuItem.Text = "Set Interval";
            this.setIntervalToolStripMenuItem.Click += new System.EventHandler(this.setIntervalToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(106, 27);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 375);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(215, 27);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 375);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Left;
            this.webBrowser2.Location = new System.Drawing.Point(109, 27);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(106, 375);
            this.webBrowser2.TabIndex = 3;
            this.webBrowser2.Url = new System.Uri("http://gaiaonline.com/auth/", System.UriKind.Absolute);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(324, 27);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 375);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Left;
            this.webBrowser3.Location = new System.Drawing.Point(218, 27);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(106, 375);
            this.webBrowser3.TabIndex = 5;
            this.webBrowser3.Url = new System.Uri("http://gaiaonline.com/auth/", System.UriKind.Absolute);
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(433, 27);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 375);
            this.splitter4.TabIndex = 8;
            this.splitter4.TabStop = false;
            // 
            // webBrowser4
            // 
            this.webBrowser4.Dock = System.Windows.Forms.DockStyle.Left;
            this.webBrowser4.Location = new System.Drawing.Point(327, 27);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(106, 375);
            this.webBrowser4.TabIndex = 7;
            this.webBrowser4.Url = new System.Uri("http://gaiaonline.com/auth/", System.UriKind.Absolute);
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(542, 27);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(3, 375);
            this.splitter5.TabIndex = 10;
            this.splitter5.TabStop = false;
            // 
            // webBrowser5
            // 
            this.webBrowser5.Dock = System.Windows.Forms.DockStyle.Left;
            this.webBrowser5.Location = new System.Drawing.Point(436, 27);
            this.webBrowser5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser5.Name = "webBrowser5";
            this.webBrowser5.Size = new System.Drawing.Size(106, 375);
            this.webBrowser5.TabIndex = 9;
            this.webBrowser5.Url = new System.Uri("http://gaiaonline.com/auth/", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 402);
            this.Controls.Add(this.splitter5);
            this.Controls.Add(this.webBrowser5);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.webBrowser4);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shit bot - Reload Gold Grabber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem setIntervalToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.WebBrowser webBrowser5;
    }
}

