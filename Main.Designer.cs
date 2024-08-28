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
            chbDrawSings = new CheckBox();
            label1 = new Label();
            comboBoxFont = new ComboBox();
            nuFontSize = new NumericUpDown();
            colorDialog = new ColorDialog();
            fontDialog = new FontDialog();
            saveFileDialog = new SaveFileDialog();
            tabControlMain = new TabControl();
            tabPageBackground = new TabPage();
            tabPageGradientBmp = new TabPage();
            pbGradientOutput = new PictureBox();
            pbInputGradientBitmap = new PictureBox();
            panelGradietnMenu = new Panel();
            btnRotate = new Button();
            numHeightSize = new NumericUpDown();
            numWhidtSize = new NumericUpDown();
            btnMinusSize = new Button();
            btnPlusSize = new Button();
            btnAddGradient = new Button();
            btnLoadGradientBitmap = new Button();
            numDegreeRotate = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            panel.SuspendLayout();
            grbChar.SuspendLayout();
            grBoxBackground.SuspendLayout();
            grbFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuFontSize).BeginInit();
            tabControlMain.SuspendLayout();
            tabPageBackground.SuspendLayout();
            tabPageGradientBmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGradientOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInputGradientBitmap).BeginInit();
            panelGradietnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHeightSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWhidtSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDegreeRotate).BeginInit();
            SuspendLayout();
            // 
            // pb
            // 
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Dock = DockStyle.Fill;
            pb.Location = new Point(3, 3);
            pb.Name = "pb";
            pb.Size = new Size(1262, 550);
            pb.TabIndex = 0;
            pb.TabStop = false;
            // 
            // btnDraw
            // 
            btnDraw.Dock = DockStyle.Bottom;
            btnDraw.Location = new Point(0, 173);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(1262, 34);
            btnDraw.TabIndex = 1;
            btnDraw.Text = "Rysuj";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(6, 98);
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
            panel.Controls.Add(btnDraw);
            panel.Controls.Add(grbChar);
            panel.Controls.Add(grBoxBackground);
            panel.Controls.Add(grbFont);
            panel.Dock = DockStyle.Bottom;
            panel.Location = new Point(3, 553);
            panel.Name = "panel";
            panel.Size = new Size(1262, 207);
            panel.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(0, 142);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(1262, 31);
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
            grbFont.Controls.Add(chbDrawSings);
            grbFont.Controls.Add(label1);
            grbFont.Controls.Add(comboBoxFont);
            grbFont.Controls.Add(nuFontSize);
            grbFont.Controls.Add(btnFont);
            grbFont.FlatStyle = FlatStyle.Flat;
            grbFont.Location = new Point(5, 6);
            grbFont.Name = "grbFont";
            grbFont.Size = new Size(226, 130);
            grbFont.TabIndex = 0;
            grbFont.TabStop = false;
            grbFont.Text = "Czcionka";
            // 
            // chbDrawSings
            // 
            chbDrawSings.AutoSize = true;
            chbDrawSings.Checked = true;
            chbDrawSings.CheckState = CheckState.Checked;
            chbDrawSings.Location = new Point(6, 18);
            chbDrawSings.Name = "chbDrawSings";
            chbDrawSings.Size = new Size(84, 19);
            chbDrawSings.TabIndex = 4;
            chbDrawSings.Text = "Rysuj znaki";
            chbDrawSings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 80);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 9;
            label1.Text = "Wielkość:";
            // 
            // comboBoxFont
            // 
            comboBoxFont.FormattingEnabled = true;
            comboBoxFont.Location = new Point(6, 43);
            comboBoxFont.Name = "comboBoxFont";
            comboBoxFont.Size = new Size(214, 23);
            comboBoxFont.TabIndex = 8;
            comboBoxFont.TextChanged += comboBoxFont_TextChanged;
            // 
            // nuFontSize
            // 
            nuFontSize.Location = new Point(123, 72);
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
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageBackground);
            tabControlMain.Controls.Add(tabPageGradientBmp);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1276, 791);
            tabControlMain.TabIndex = 8;
            // 
            // tabPageBackground
            // 
            tabPageBackground.Controls.Add(pb);
            tabPageBackground.Controls.Add(panel);
            tabPageBackground.Location = new Point(4, 24);
            tabPageBackground.Name = "tabPageBackground";
            tabPageBackground.Padding = new Padding(3);
            tabPageBackground.Size = new Size(1268, 763);
            tabPageBackground.TabIndex = 0;
            tabPageBackground.Text = "Generowanie tła";
            tabPageBackground.UseVisualStyleBackColor = true;
            // 
            // tabPageGradientBmp
            // 
            tabPageGradientBmp.Controls.Add(pbGradientOutput);
            tabPageGradientBmp.Controls.Add(pbInputGradientBitmap);
            tabPageGradientBmp.Controls.Add(panelGradietnMenu);
            tabPageGradientBmp.Location = new Point(4, 24);
            tabPageGradientBmp.Name = "tabPageGradientBmp";
            tabPageGradientBmp.Padding = new Padding(3);
            tabPageGradientBmp.Size = new Size(1268, 763);
            tabPageGradientBmp.TabIndex = 1;
            tabPageGradientBmp.Text = "Dodaj gradient";
            tabPageGradientBmp.UseVisualStyleBackColor = true;
            // 
            // pbGradientOutput
            // 
            pbGradientOutput.BorderStyle = BorderStyle.FixedSingle;
            pbGradientOutput.Location = new Point(552, 15);
            pbGradientOutput.Name = "pbGradientOutput";
            pbGradientOutput.Size = new Size(675, 466);
            pbGradientOutput.SizeMode = PictureBoxSizeMode.CenterImage;
            pbGradientOutput.TabIndex = 2;
            pbGradientOutput.TabStop = false;
            // 
            // pbInputGradientBitmap
            // 
            pbInputGradientBitmap.BorderStyle = BorderStyle.FixedSingle;
            pbInputGradientBitmap.Location = new Point(21, 29);
            pbInputGradientBitmap.Name = "pbInputGradientBitmap";
            pbInputGradientBitmap.Size = new Size(412, 264);
            pbInputGradientBitmap.SizeMode = PictureBoxSizeMode.AutoSize;
            pbInputGradientBitmap.TabIndex = 1;
            pbInputGradientBitmap.TabStop = false;
            // 
            // panelGradietnMenu
            // 
            panelGradietnMenu.BorderStyle = BorderStyle.FixedSingle;
            panelGradietnMenu.Controls.Add(numDegreeRotate);
            panelGradietnMenu.Controls.Add(btnRotate);
            panelGradietnMenu.Controls.Add(numHeightSize);
            panelGradietnMenu.Controls.Add(numWhidtSize);
            panelGradietnMenu.Controls.Add(btnMinusSize);
            panelGradietnMenu.Controls.Add(btnPlusSize);
            panelGradietnMenu.Controls.Add(btnAddGradient);
            panelGradietnMenu.Controls.Add(btnLoadGradientBitmap);
            panelGradietnMenu.Location = new Point(21, 510);
            panelGradietnMenu.Name = "panelGradietnMenu";
            panelGradietnMenu.Size = new Size(792, 136);
            panelGradietnMenu.TabIndex = 0;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(407, 18);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(75, 23);
            btnRotate.TabIndex = 6;
            btnRotate.Text = "+";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // numHeightSize
            // 
            numHeightSize.Location = new Point(302, 59);
            numHeightSize.Name = "numHeightSize";
            numHeightSize.Size = new Size(41, 23);
            numHeightSize.TabIndex = 5;
            numHeightSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numWhidtSize
            // 
            numWhidtSize.Location = new Point(302, 18);
            numWhidtSize.Name = "numWhidtSize";
            numWhidtSize.Size = new Size(41, 23);
            numWhidtSize.TabIndex = 4;
            numWhidtSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnMinusSize
            // 
            btnMinusSize.Location = new Point(221, 59);
            btnMinusSize.Name = "btnMinusSize";
            btnMinusSize.Size = new Size(75, 23);
            btnMinusSize.TabIndex = 3;
            btnMinusSize.Text = "-";
            btnMinusSize.UseVisualStyleBackColor = true;
            btnMinusSize.Click += btnMinusSize_Click;
            // 
            // btnPlusSize
            // 
            btnPlusSize.Location = new Point(221, 18);
            btnPlusSize.Name = "btnPlusSize";
            btnPlusSize.Size = new Size(75, 23);
            btnPlusSize.TabIndex = 2;
            btnPlusSize.Text = "+";
            btnPlusSize.UseVisualStyleBackColor = true;
            btnPlusSize.Click += btnPlusSize_Click;
            // 
            // btnAddGradient
            // 
            btnAddGradient.Location = new Point(18, 89);
            btnAddGradient.Name = "btnAddGradient";
            btnAddGradient.Size = new Size(113, 58);
            btnAddGradient.TabIndex = 1;
            btnAddGradient.Text = "Dodaj gradient";
            btnAddGradient.UseVisualStyleBackColor = true;
            btnAddGradient.Click += btnAddGradient_Click;
            // 
            // btnLoadGradientBitmap
            // 
            btnLoadGradientBitmap.Location = new Point(18, 18);
            btnLoadGradientBitmap.Name = "btnLoadGradientBitmap";
            btnLoadGradientBitmap.Size = new Size(113, 52);
            btnLoadGradientBitmap.TabIndex = 0;
            btnLoadGradientBitmap.Text = "Otwórz obraz";
            btnLoadGradientBitmap.UseVisualStyleBackColor = true;
            btnLoadGradientBitmap.Click += btnLoadGradientBitmap_Click;
            // 
            // numDegreeRotate
            // 
            numDegreeRotate.Location = new Point(488, 20);
            numDegreeRotate.Name = "numDegreeRotate";
            numDegreeRotate.Size = new Size(41, 23);
            numDegreeRotate.TabIndex = 7;
            numDegreeRotate.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 791);
            Controls.Add(tabControlMain);
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
            tabControlMain.ResumeLayout(false);
            tabPageBackground.ResumeLayout(false);
            tabPageGradientBmp.ResumeLayout(false);
            tabPageGradientBmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGradientOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInputGradientBitmap).EndInit();
            panelGradietnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numHeightSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWhidtSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDegreeRotate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbInputGradientBitmap;
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
        private TabControl tabControlMain;
        private TabPage tabPageBackground;
        private TabPage tabPageGradientBmp;
        private CheckBox chbDrawSings;
        private Panel panelGradietnMenu;
        private Button btnAddGradient;
        private Button btnLoadGradientBitmap;
        private PictureBox pbGradientOutput;
        private Button btnMinusSize;
        private Button btnPlusSize;
        private NumericUpDown numHeightSize;
        private NumericUpDown numWhidtSize;
        private Button btnRotate;
        private NumericUpDown numDegreeRotate;
    }
}