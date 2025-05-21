namespace PLD_Project
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
        ///  Required method for Designer support - do not modify the
        ///  contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            documentationToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            labelSource = new Label();
            textBox1 = new RichTextBox();
            tabControl1 = new TabControl();
            tabPageParseTree = new TabPage();
            listBox1 = new ListBox();
            tabPageLexical = new TabPage();
            listBox2 = new ListBox();
            toolStrip1 = new ToolStrip();
            btnParse = new ToolStripButton();
            btnClear = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageParseTree.SuspendLayout();
            tabPageLexical.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
        
            menuStrip1.BackColor = Color.FromArgb(0, 128, 128);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(954, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
          
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
           
            openToolStripMenuItem.BackColor = Color.FromArgb(0, 128, 128); 
            openToolStripMenuItem.ForeColor = Color.White;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(181, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
          
            saveToolStripMenuItem.BackColor = Color.FromArgb(0, 128, 128); 
            saveToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
        
            saveAsToolStripMenuItem.BackColor = Color.FromArgb(0, 128, 128); 
            saveAsToolStripMenuItem.ForeColor = Color.White;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(181, 26);
            saveAsToolStripMenuItem.Text = "Save &As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
      
            toolStripSeparator1.BackColor = Color.FromArgb(0, 128, 128);
            toolStripSeparator1.ForeColor = Color.White;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
 
            exitToolStripMenuItem.BackColor = Color.FromArgb(0, 128, 128); 
            exitToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(181, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentationToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.ForeColor = Color.White;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            
           
            documentationToolStripMenuItem.BackColor = Color.FromArgb(0, 128, 128); 
            documentationToolStripMenuItem.ForeColor = Color.White;
            documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            documentationToolStripMenuItem.Size = new Size(195, 26);
            documentationToolStripMenuItem.Text = "&Documentation";
            documentationToolStripMenuItem.Click += documentationToolStripMenuItem_Click;
     
            aboutToolStripMenuItem.BackColor = Color.FromArgb(0, 128, 128); 
            aboutToolStripMenuItem.ForeColor = Color.White;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(195, 26);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;

            statusStrip1.BackColor = Color.FromArgb(0, 128, 128); 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 601);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(954, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
           
            statusLabel.ForeColor = Color.White;
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(50, 20);
            statusLabel.Text = "Ready";
         
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 55);
            splitContainer1.Name = "splitContainer1";
           
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1MinSize = 200;
            
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Panel2MinSize = 200;
            splitContainer1.Size = new Size(954, 546);
            splitContainer1.SplitterDistance = 450;
            splitContainer1.TabIndex = 2;
          
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(labelSource);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(450, 546);
            panel1.TabIndex = 0;
            
            labelSource.AutoSize = true;
            labelSource.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSource.ForeColor = Color.White;
            labelSource.Location = new Point(10, 10);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(95, 20);
            labelSource.TabIndex = 1;
            labelSource.Text = "Source Code";
       
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(0, 64, 64); 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Consolas", 10F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(10, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(430, 503);
            textBox1.TabIndex = 0;
            textBox1.Text = "";
            textBox1.TextChanged += textBox1_TextChanged;
           
            tabControl1.Controls.Add(tabPageParseTree);
            tabControl1.Controls.Add(tabPageLexical);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(500, 546);
            tabControl1.TabIndex = 0;
            
            
            tabPageParseTree.BackColor = Color.FromArgb(0, 64, 64); 
            tabPageParseTree.Controls.Add(listBox1);
            tabPageParseTree.Location = new Point(4, 29);
            tabPageParseTree.Name = "tabPageParseTree";
            tabPageParseTree.Padding = new Padding(10);
            tabPageParseTree.Size = new Size(492, 513);
            tabPageParseTree.TabIndex = 0;
            tabPageParseTree.Text = "Syntax Analysis ";

            listBox1.BackColor = Color.FromArgb(0, 64, 64); 
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Consolas", 9F);
            listBox1.ForeColor = Color.FromArgb(64, 255, 224); 
            listBox1.FormattingEnabled = true;
            listBox1.IntegralHeight = false;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(10, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(472, 493);
            listBox1.TabIndex = 2;

            tabPageLexical.BackColor = Color.FromArgb(0, 64, 64);
            tabPageLexical.Controls.Add(listBox2);
            tabPageLexical.Location = new Point(4, 29);
            tabPageLexical.Name = "tabPageLexical";
            tabPageLexical.Padding = new Padding(10);
            tabPageLexical.Size = new Size(492, 513);
            tabPageLexical.TabIndex = 1;
            tabPageLexical.Text = "Lexical Analysis";

            listBox2.BackColor = Color.FromArgb(0, 64, 64); 
            listBox2.BorderStyle = BorderStyle.FixedSingle;
            listBox2.Dock = DockStyle.Fill;
            listBox2.Font = new Font("Consolas", 9F);
            listBox2.ForeColor = Color.FromArgb(128, 255, 255); 
            listBox2.FormattingEnabled = true;
            listBox2.IntegralHeight = false;
            listBox2.ItemHeight = 18;
            listBox2.HorizontalScrollbar = true;
            listBox2.Location = new Point(10, 10);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(472, 493);
            listBox2.TabIndex = 3;
       
            toolStrip1.BackColor = Color.FromArgb(0, 128, 128);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnParse, btnClear });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(954, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
         
            btnParse.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnParse.ForeColor = Color.White;
            btnParse.ImageTransparentColor = Color.Magenta;
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(47, 24);
            btnParse.Text = "Parse";
            btnParse.Click += btnParse_Click;
        
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnClear.ForeColor = Color.White;
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 24);
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
       
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64); 
            ClientSize = new Size(954, 627);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            Text = "PLD Parser";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageParseTree.ResumeLayout(false);
            tabPageLexical.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label labelSource;
        private ToolStrip toolStrip1;
        private ToolStripButton btnParse;
        private ToolStripButton btnClear;
        private RichTextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPageParseTree;
        private ListBox listBox1;
        private TabPage tabPageLexical;
        private ListBox listBox2;
    }
}
