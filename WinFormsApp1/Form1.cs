using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string font = string.Empty;
        bool BoldCheck;
        bool LineCheck;
        bool ItalicCheck;
        bool LeftCheck;
        bool RightCheck;
        bool CenterCheck;
        public Form1()
        {
            InitializeComponent();
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                Color knownColor = Color.FromKnownColor(color);
                ColorComboBox.Items.Add(knownColor);
            }
            foreach (var item in FontFamily.Families)
            {
                FontComboBox.Items.Add(item.Name);
            }
            for (int i = 1; i < 73; i++)
            {
                SizeComboBox.Items.Add(i);
            }
            BoldCheck = false;
            LineCheck = false;
            ItalicCheck = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = (Color)ColorComboBox.SelectedItem;
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font f = new(FontComboBox.SelectedItem.ToString(), richTextBox1.Font.Size, richTextBox1.Font.Style, richTextBox1.Font.Unit, richTextBox1.Font.GdiCharSet, richTextBox1.Font.GdiVerticalFont);
            richTextBox1.Font = f;
        }

        private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font f = new(richTextBox1.Font.Name, (int)SizeComboBox.SelectedItem, richTextBox1.Font.Style, richTextBox1.Font.Unit, richTextBox1.Font.GdiCharSet, richTextBox1.Font.GdiVerticalFont);
            richTextBox1.Font = f;
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            if (BoldCheck)
                BoldCheck = false;
            else BoldCheck = true;
            if (BoldCheck)
            {
                buttonBold.BackColor = Color.Gray;
                font += "bold";
                if (font.Contains("line") && font.Contains("I"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                else if (font.Contains("line"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
                else if (font.Contains("I"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic);
                else
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold);
            }
            else
            {
                int start = 0;

                for (int i = 0; i < font.Length; i++)
                {
                    if (font[i] == 'b')
                        start = i;
                }
                font = font.Remove(start, 4);
                buttonBold.BackColor = SystemColors.MenuBar;
                if (font.Contains("line") && font.Contains("I"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Underline | FontStyle.Italic);
                else if (font.Contains("line"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Underline);
                else if (font.Contains("I"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Italic);
                else
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Regular);
            }

        }

        private void buttonUnderLine_Click(object sender, EventArgs e)
        {
            if (LineCheck)
                LineCheck = false;
            else LineCheck = true;
            if (LineCheck)
            {
                buttonUnderLine.BackColor = Color.Gray;
                font += "line";
                if (font.Contains("bold") && font.Contains("I"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                else if (font.Contains("bold"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
                else if (font.Contains("I"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Underline | FontStyle.Italic);
                else
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Underline);
            }
            else
            {
                int start = 0;

                for (int i = 0; i < font.Length; i++)
                {
                    if (font[i] == 'l')
                        start = i;
                }
                font = font.Remove(start, 4);
                buttonUnderLine.BackColor = SystemColors.MenuBar;
                if (font.Contains("bold") && font.Contains("I"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic);
                else if (font.Contains("bold"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold);
                else if (font.Contains("I"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Italic);
                else
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Regular);
            }

        }

        private void buttonItalic_Click(object sender, EventArgs e)
        {
            if (ItalicCheck)
                ItalicCheck = false;
            else ItalicCheck = true;
            if (ItalicCheck)
            {
                buttonItalic.BackColor = Color.Gray;
                font += "I";
                if (font.Contains("bold") && font.Contains("line"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                else if (font.Contains("bold"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic);
                else if (font.Contains("line"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Underline | FontStyle.Italic);
                else
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Italic);
            }
            else
            {
                int start = 0;

                for (int i = 0; i < font.Length; i++)
                {
                    if (font[i] == 'I')
                        start = i;
                }
                font = font.Remove(start, 1);
                buttonItalic.BackColor = SystemColors.MenuBar;
                if (font.Contains("bold") && font.Contains("line"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
                else if (font.Contains("bold"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Bold);
                else if (font.Contains("line"))
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Underline);
                else
                    richTextBox1.SelectionFont = new(richTextBox1.Font, FontStyle.Regular);
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (LeftCheck) LeftCheck = false;
            else LeftCheck = true;
            if (LeftCheck)
            {
                buttonLeft.BackColor = Color.Gray;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                buttonLeft.BackColor = SystemColors.MenuBar;
            }
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            if (CenterCheck) CenterCheck = false;
            else CenterCheck = true;
            if (CenterCheck)
            {
                buttonCenter.BackColor = Color.Gray;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
                buttonCenter.BackColor = SystemColors.MenuBar;
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (RightCheck) RightCheck = false;
            else RightCheck = true;
            if (RightCheck)
            {
                buttonRight.BackColor = Color.Gray;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
            else
            {
                buttonRight.BackColor = SystemColors.MenuBar;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(SaveBox.Text+".txt", richTextBox1.Text);
            SaveBox.Text = string.Empty;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(LoadBox.Text+".txt");
            LoadBox.Text = string.Empty;
        }
    }
}