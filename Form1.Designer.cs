namespace myNewPRO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            treeView1 = new TreeView();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 帮助ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1343, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(44, 21);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(44, 21);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 738);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1343, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(131, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(131, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripTextBox1, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1343, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            //toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(52, 22);
            toolStripButton1.Text = "抓取";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(600, 25);
            toolStripTextBox1.Text = "https://m.qqxsw.tv/chapters_34237/";
            // 
            // toolStripButton2
            // 
            //toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(52, 22);
            toolStripButton2.Text = "浏览";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            //toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(76, 22);
            toolStripButton3.Text = "网页获取";
            // 
            // toolStripButton4
            // 
            //toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(123, 22);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1343, 688);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1335, 658);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(webView21);
            splitContainer1.Panel2MinSize = 0;
            splitContainer1.Size = new Size(1329, 652);
            splitContainer1.SplitterDistance = 443;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.BackColor = SystemColors.InactiveCaption;
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(443, 652);
            treeView1.TabIndex = 0;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.BackColor = SystemColors.Control;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(880, 652);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1335, 658);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(43, 35);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(857, 532);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 760);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private TabPage tabPage2;
        private TreeView treeView1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private RichTextBox richTextBox1;
    }
}
