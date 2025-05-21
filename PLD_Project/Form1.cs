using com.calitha.goldparser;
using System.Text;

namespace PLD_Project
{
    public partial class Form1 : Form
    {
        MyParser parser;
        private string currentFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            parser = new MyParser("PLD_Proj.cgt", listBox1, listBox2);           
            this.Text = "PLD Parser";
           
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            parser.Parse(textBox1.Text);
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            statusLabel.Text = "Parsing...";
            parser.Parse(textBox1.Text);
            statusLabel.Text = "Parse complete";
            
            tabControl1.SelectedIndex = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the text?", "Confirm Clear", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Clear();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                statusLabel.Text = "Editor cleared";
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        textBox1.Text = File.ReadAllText(openFileDialog.FileName);
                        currentFilePath = openFileDialog.FileName;
                        statusLabel.Text = $"Opened: {Path.GetFileName(currentFilePath)}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                SaveFile(currentFilePath);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveFile(saveFileDialog.FileName);
                }
            }
        }
        
        private void SaveFile(string filePath)
        {
            try
            {
                File.WriteAllText(filePath, textBox1.Text);
                currentFilePath = filePath;
                statusLabel.Text = $"Saved: {Path.GetFileName(currentFilePath)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string docText = @"# Zlang: Python-Like Syntax

## Grammar Information
- Name: Zlang Python-Like Syntax
- Author: Ziad Yousef
- Version: 1.0
- About: A Python-like syntax grammar

## Language Overview

Zlang is a programming language with Python-like syntax. It supports basic programming constructs such as variable assignment, conditional statements, loops, and output operations.

## Syntax Elements

### Statements
The language supports:
- Variable Assignment: let identifier = expression;
- Conditional Statements: if expression: ...
- While Loop: while expression: ...
- Print Statement: print expression;

### Expressions
- Variables (identifiers)
- Numbers
- String literals
- Mathematical operations: +, -, *, /
- Parenthesized expressions: (expression)

### Data Types
- Identifiers: Variable names (e.g., x, counter, _private)
- Numbers: Sequences of digits (e.g., 123, 0, 42)
- String Literals: Text in double quotes (e.g., ""Hello, World!"")

### Syntax Requirements
- Variable assignments use 'let' and end with semicolon
- Print statements end with semicolon
- Conditional statements and loops use colon after condition
- Blocks are defined by newlines

For more information, see the full documentation file.";

            Form docForm = new Form
            {
                Text = "Zlang Grammar Documentation",
                Size = new Size(700, 500),
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            RichTextBox docTextBox = new RichTextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = RichTextBoxScrollBars.Vertical,
                Dock = DockStyle.Fill,
                Text = docText,
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.White,
                Font = new Font("Consolas", 10)
            };

            docTextBox.SelectionStart = 0;
            docTextBox.SelectionLength = docText.Length;
            docTextBox.SelectionColor = Color.White;
            
            FormatHeading(docTextBox, "# Zlang: Python-Like Syntax", Color.Cyan, 14);
            FormatHeading(docTextBox, "## Grammar Information", Color.LightCyan, 12);
            FormatHeading(docTextBox, "## Language Overview", Color.LightCyan, 12);
            FormatHeading(docTextBox, "## Syntax Elements", Color.LightCyan, 12);
            FormatHeading(docTextBox, "### Statements", Color.LightGreen, 11);
            FormatHeading(docTextBox, "### Expressions", Color.LightGreen, 11);
            FormatHeading(docTextBox, "### Data Types", Color.LightGreen, 11);
            FormatHeading(docTextBox, "### Syntax Requirements", Color.LightGreen, 11);
            
            HighlightKeywords(docTextBox, new[] { "let", "if", "else", "while", "print" }, Color.Orange);

            docForm.Controls.Add(docTextBox);
            docForm.ShowDialog();
        }

        private void FormatHeading(RichTextBox rtb, string text, Color color, float size)
        {
            int start = rtb.Find(text);
            if (start >= 0)
            {
                rtb.SelectionStart = start;
                rtb.SelectionLength = text.Length;
                rtb.SelectionColor = color;
                rtb.SelectionFont = new Font(rtb.Font.FontFamily, size, FontStyle.Bold);
            }
        }

        private void HighlightKeywords(RichTextBox rtb, string[] keywords, Color color)
        {
            int originalStart = rtb.SelectionStart;
            int originalLength = rtb.SelectionLength;
            
            foreach (string keyword in keywords)
            {
                int start = 0;
                while ((start = rtb.Find(keyword, start, RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord)) != -1)
                {
                    rtb.SelectionStart = start;
                    rtb.SelectionLength = keyword.Length;
                    rtb.SelectionColor = color;
                    start += keyword.Length;
                }
            }
            
            rtb.SelectionStart = originalStart;
            rtb.SelectionLength = originalLength;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PLD Parser\nVersion 1.0\n\nA tool for parsing PLD language.", 
                "About PLD Parser", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
