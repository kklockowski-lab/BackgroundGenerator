namespace BackgroundGenerator
{
    partial class Main
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
            pb = new PictureBox();
            btnDraw = new Button();
            btnFont = new Button();
            btnStartBackColor = new Button();
            btnEndBakColor = new Button();
            btnEndCharColor = new Button();
            btnStartCharColor = new Button();
            panel = new Panel();
            btnSave = new Button();
            grbChar = new GroupBox();
            grBoxBackground = new GroupBox();
            grbFont = new GroupBox();
            label1 = new Label();
            comboBoxFont = new ComboBox();
            nuFontSize = new NumericUpDown();
            colorDialog = new ColorDialog();
            fontDialog = new FontDialog();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            panel.SuspendLayout();
            grbChar.SuspendLayout();
            grBoxBackground.SuspendLayout();
            grbFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuFontSize).BeginInit();
            SuspendLayout();
            // 
            // pb
            // 
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Dock = DockStyle.Fill;
            pb.Location = new Point(0, 0);
            pb.Name = "pb";
            pb.Size = new Size(930, 689);
            pb.TabIndex = 0;
            pb.TabStop = false;
            // 
            // btnDraw
            // 
            btnDraw.Dock = DockStyle.Bottom;
            btnDraw.Location = new Point(0, 655);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(930, 34);
            btnDraw.TabIndex = 1;
            btnDraw.Text = "Rysuj";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(6, 77);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(214, 23);
            btnFont.TabIndex = 2;
            btnFont.Text = "Edytor";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnStartBackColor
            // 
            btnStartBackColor.Location = new Point(2, 22);
            btnStartBackColor.Name = "btnStartBackColor";
            btnStartBackColor.Size = new Size(75, 75);
            btnStartBackColor.TabIndex = 3;
            btnStartBackColor.Text = "Start";
            btnStartBackColor.UseVisualStyleBackColor = true;
            btnStartBackColor.Click += btnStartBackColor_Click;
            // 
            // btnEndBakColor
            // 
            btnEndBakColor.Location = new Point(77, 22);
            btnEndBakColor.Name = "btnEndBakColor";
            btnEndBakColor.Size = new Size(75, 75);
            btnEndBakColor.TabIndex = 4;
            btnEndBakColor.Text = "Koniec";
            btnEndBakColor.UseVisualStyleBackColor = true;
            btnEndBakColor.Click += btnEndBakColor_Click;
            // 
            // btnEndCharColor
            // 
            btnEndCharColor.Location = new Point(84, 22);
            btnEndCharColor.Name = "btnEndCharColor";
            btnEndCharColor.Size = new Size(75, 75);
            btnEndCharColor.TabIndex = 5;
            btnEndCharColor.Text = "Koniec";
            btnEndCharColor.UseVisualStyleBackColor = true;
            btnEndCharColor.Click += btnEndCharColor_Click;
            // 
            // btnStartCharColor
            // 
            btnStartCharColor.Location = new Point(6, 22);
            btnStartCharColor.Name = "btnStartCharColor";
            btnStartCharColor.Size = new Size(75, 75);
            btnStartCharColor.TabIndex = 6;
            btnStartCharColor.Text = "Start";
            btnStartCharColor.UseVisualStyleBackColor = true;
            btnStartCharColor.Click += btnStartCharColor_Click;
            // 
            // panel
            // 
            panel.Controls.Add(btnSave);
            panel.Controls.Add(grbChar);
            panel.Controls.Add(grBoxBackground);
            panel.Controls.Add(grbFont);
            panel.Dock = DockStyle.Bottom;
            panel.Location = new Point(0, 506);
            panel.Name = "panel";
            panel.Size = new Size(930, 149);
            panel.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(0, 112);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(930, 37);
            btnSave.TabIndex = 3;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grbChar
            // 
            grbChar.Controls.Add(btnStartCharColor);
            grbChar.Controls.Add(btnEndCharColor);
            grbChar.Location = new Point(415, 6);
            grbChar.Name = "grbChar";
            grbChar.Size = new Size(163, 106);
            grbChar.TabIndex = 2;
            grbChar.TabStop = false;
            grbChar.Text = "Gradient znaków";
            // 
            // grBoxBackground
            // 
            grBoxBackground.Controls.Add(btnEndBakColor);
            grBoxBackground.Controls.Add(btnStartBackColor);
            grBoxBackground.Location = new Point(251, 6);
            grBoxBackground.Name = "grBoxBackground";
            grBoxBackground.Size = new Size(158, 106);
            grBoxBackground.TabIndex = 1;
            grBoxBackground.TabStop = false;
            grBoxBackground.Text = "Gradient tła";
            // 
            // grbFont
            // 
            grbFont.Controls.Add(label1);
            grbFont.Controls.Add(comboBoxFont);
            grbFont.Controls.Add(nuFontSize);
            grbFont.Controls.Add(btnFont);
            grbFont.FlatStyle = FlatStyle.Flat;
            grbFont.Location = new Point(5, 6);
            grbFont.Name = "grbFont";
            grbFont.Size = new Size(226, 106);
            grbFont.TabIndex = 0;
            grbFont.TabStop = false;
            grbFont.Text = "Czcionka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 59);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 9;
            label1.Text = "Wielkość:";
            // 
            // comboBoxFont
            // 
            comboBoxFont.FormattingEnabled = true;
            comboBoxFont.Location = new Point(6, 22);
            comboBoxFont.Name = "comboBoxFont";
            comboBoxFont.Size = new Size(214, 23);
            comboBoxFont.TabIndex = 8;
            comboBoxFont.TextChanged += comboBoxFont_TextChanged;
            // 
            // nuFontSize
            // 
            nuFontSize.Location = new Point(123, 51);
            nuFontSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nuFontSize.Name = "nuFontSize";
            nuFontSize.Size = new Size(97, 23);
            nuFontSize.TabIndex = 0;
            nuFontSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nuFontSize.ValueChanged += nuFontSize_ValueChanged;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "bmp";
            saveFileDialog.FileName = "MathBackground";
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 689);
            Controls.Add(panel);
            Controls.Add(btnDraw);
            Controls.Add(pb);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generator tła :)";
            FormClosing += Main_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            panel.ResumeLayout(false);
            grbChar.ResumeLayout(false);
            grBoxBackground.ResumeLayout(false);
            grbFont.ResumeLayout(false);
            grbFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuFontSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnFont;
        private Button btnDraw;
        private PictureBox pb;
        private Button btnStartBackColor;
        private Button btnEndBakColor;
        private Button btnEndCharColor;
        private Button btnStartCharColor;
        private Panel panel;
        private GroupBox grbChar;
        private GroupBox grBoxBackground;
        private GroupBox grbFont;
        private ColorDialog colorDialog;
        private ComboBox comboBoxFont;
        private NumericUpDown nuFontSize;
        private FontDialog fontDialog;
        private Label label1;
        private Button btnSave;
        private SaveFileDialog saveFileDialog;
    }
}