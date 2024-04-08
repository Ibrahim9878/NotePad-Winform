namespace WinFormsApp1
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
            labelFont = new Label();
            labelSize = new Label();
            labelFontStyle = new Label();
            labelAlignment = new Label();
            FontComboBox = new ComboBox();
            SizeComboBox = new ComboBox();
            buttonBold = new Button();
            buttonUnderLine = new Button();
            buttonItalic = new Button();
            buttonRight = new Button();
            buttonCenter = new Button();
            buttonLeft = new Button();
            labelColor = new Label();
            ColorComboBox = new ComboBox();
            LoadBox = new TextBox();
            textBox1 = new TextBox();
            buttonLoad = new Button();
            buttonSave = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // labelFont
            // 
            labelFont.AutoSize = true;
            labelFont.Location = new Point(29, 7);
            labelFont.Name = "labelFont";
            labelFont.Size = new Size(31, 15);
            labelFont.TabIndex = 0;
            labelFont.Text = "Font";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(122, 7);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(27, 15);
            labelSize.TabIndex = 1;
            labelSize.Text = "Size";
            // 
            // labelFontStyle
            // 
            labelFontStyle.AutoSize = true;
            labelFontStyle.Location = new Point(191, 7);
            labelFontStyle.Name = "labelFontStyle";
            labelFontStyle.Size = new Size(56, 15);
            labelFontStyle.TabIndex = 2;
            labelFontStyle.Text = "FontStyle";
            // 
            // labelAlignment
            // 
            labelAlignment.AutoSize = true;
            labelAlignment.Location = new Point(297, 7);
            labelAlignment.Name = "labelAlignment";
            labelAlignment.Size = new Size(63, 15);
            labelAlignment.TabIndex = 3;
            labelAlignment.Text = "Alignment";
            // 
            // FontComboBox
            // 
            FontComboBox.BackColor = SystemColors.MenuBar;
            FontComboBox.ForeColor = SystemColors.ControlLight;
            FontComboBox.FormattingEnabled = true;
            FontComboBox.Location = new Point(3, 25);
            FontComboBox.Name = "FontComboBox";
            FontComboBox.Size = new Size(100, 23);
            FontComboBox.TabIndex = 4;
            // 
            // SizeComboBox
            // 
            SizeComboBox.BackColor = SystemColors.MenuBar;
            SizeComboBox.FormattingEnabled = true;
            SizeComboBox.Location = new Point(109, 25);
            SizeComboBox.Name = "SizeComboBox";
            SizeComboBox.Size = new Size(55, 23);
            SizeComboBox.TabIndex = 5;
            // 
            // buttonBold
            // 
            buttonBold.BackColor = SystemColors.MenuBar;
            buttonBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBold.Location = new Point(180, 25);
            buttonBold.Name = "buttonBold";
            buttonBold.Size = new Size(25, 23);
            buttonBold.TabIndex = 6;
            buttonBold.Text = "B";
            buttonBold.UseVisualStyleBackColor = false;
            // 
            // buttonUnderLine
            // 
            buttonUnderLine.BackColor = SystemColors.MenuBar;
            buttonUnderLine.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            buttonUnderLine.Location = new Point(211, 25);
            buttonUnderLine.Name = "buttonUnderLine";
            buttonUnderLine.Size = new Size(25, 23);
            buttonUnderLine.TabIndex = 7;
            buttonUnderLine.Text = "U";
            buttonUnderLine.UseVisualStyleBackColor = false;
            // 
            // buttonItalic
            // 
            buttonItalic.BackColor = SystemColors.MenuBar;
            buttonItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonItalic.Location = new Point(242, 25);
            buttonItalic.Name = "buttonItalic";
            buttonItalic.Size = new Size(25, 23);
            buttonItalic.TabIndex = 8;
            buttonItalic.Text = "/";
            buttonItalic.UseVisualStyleBackColor = false;
            // 
            // buttonRight
            // 
            buttonRight.BackColor = SystemColors.MenuBar;
            buttonRight.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonRight.Location = new Point(347, 25);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(25, 23);
            buttonRight.TabIndex = 11;
            buttonRight.Text = "R";
            buttonRight.UseVisualStyleBackColor = false;
            // 
            // buttonCenter
            // 
            buttonCenter.BackColor = SystemColors.MenuBar;
            buttonCenter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCenter.Location = new Point(316, 25);
            buttonCenter.Name = "buttonCenter";
            buttonCenter.Size = new Size(25, 23);
            buttonCenter.TabIndex = 10;
            buttonCenter.Text = "C";
            buttonCenter.UseVisualStyleBackColor = false;
            // 
            // buttonLeft
            // 
            buttonLeft.BackColor = SystemColors.MenuBar;
            buttonLeft.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLeft.Location = new Point(285, 25);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(25, 23);
            buttonLeft.TabIndex = 9;
            buttonLeft.Text = "L";
            buttonLeft.UseVisualStyleBackColor = false;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(404, 7);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(36, 15);
            labelColor.TabIndex = 12;
            labelColor.Text = "Color";
            // 
            // ColorComboBox
            // 
            ColorComboBox.BackColor = SystemColors.MenuBar;
            ColorComboBox.FormattingEnabled = true;
            ColorComboBox.Location = new Point(387, 25);
            ColorComboBox.Name = "ColorComboBox";
            ColorComboBox.Size = new Size(80, 23);
            ColorComboBox.TabIndex = 13;
            ColorComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LoadBox
            // 
            LoadBox.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            LoadBox.Location = new Point(510, 6);
            LoadBox.Name = "LoadBox";
            LoadBox.PlaceholderText = "Enter name and Load file..";
            LoadBox.Size = new Size(156, 20);
            LoadBox.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(510, 32);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tap to Enter name and save.. ";
            textBox1.Size = new Size(156, 20);
            textBox1.TabIndex = 15;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.MenuBar;
            buttonLoad.Location = new Point(682, 3);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 16;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.MenuBar;
            buttonSave.Location = new Point(682, 32);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 17;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(785, 399);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(buttonSave);
            Controls.Add(buttonLoad);
            Controls.Add(textBox1);
            Controls.Add(LoadBox);
            Controls.Add(ColorComboBox);
            Controls.Add(labelColor);
            Controls.Add(buttonRight);
            Controls.Add(buttonCenter);
            Controls.Add(buttonLeft);
            Controls.Add(buttonItalic);
            Controls.Add(buttonUnderLine);
            Controls.Add(buttonBold);
            Controls.Add(SizeComboBox);
            Controls.Add(FontComboBox);
            Controls.Add(labelAlignment);
            Controls.Add(labelFontStyle);
            Controls.Add(labelSize);
            Controls.Add(labelFont);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFont;
        private Label labelSize;
        private Label labelFontStyle;
        private Label labelAlignment;
        private ComboBox FontComboBox;
        private ComboBox SizeComboBox;
        private Button buttonBold;
        private Button buttonUnderLine;
        private Button buttonItalic;
        private Button buttonRight;
        private Button buttonCenter;
        private Button buttonLeft;
        private Label labelColor;
        private ComboBox ColorComboBox;
        private TextBox LoadBox;
        private TextBox textBox1;
        private Button buttonLoad;
        private Button buttonSave;
        private RichTextBox richTextBox1;
    }
}