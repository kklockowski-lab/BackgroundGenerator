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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pb = new PictureBox();
            btnDraw = new Button();
            btnFont = new Button();
            btnStartBackColor = new Button();
            btnEndBakColor = new Button();
            btnEndCharColor = new Button();
            btnStartCharColor = new Button();
            panel = new Panel();
            btnCopyBackground = new Button();
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
            splitContainerGradientMain = new SplitContainer();
            listViewExpressions = new ListView();
            splitContainerBitmaps = new SplitContainer();
            pbInputGradientBitmap = new PictureBox();
            pbGradientOutput = new PictureBox();
            panelGradietnMenu = new Panel();
            groupBox1 = new GroupBox();
            btnGradientEndForBitmap = new Button();
            btnGradientStartForBitmap = new Button();
            chbRotateDirection = new CheckBox();
            btnCopy = new Button();
            btnPaste = new Button();
            numDegreeRotate = new NumericUpDown();
            btnRotate = new Button();
            numHeightSize = new NumericUpDown();
            numWhidtSize = new NumericUpDown();
            btnMinusSize = new Button();
            btnPlusSize = new Button();
            btnAddGradient = new Button();
            btnLoadGradientBitmap = new Button();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            panel.SuspendLayout();
            grbChar.SuspendLayout();
            grBoxBackground.SuspendLayout();
            grbFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuFontSize).BeginInit();
            tabControlMain.SuspendLayout();
            tabPageBackground.SuspendLayout();
            tabPageGradientBmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerGradientMain).BeginInit();
            splitContainerGradientMain.Panel1.SuspendLayout();
            splitContainerGradientMain.Panel2.SuspendLayout();
            splitContainerGradientMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerBitmaps).BeginInit();
            splitContainerBitmaps.Panel1.SuspendLayout();
            splitContainerBitmaps.Panel2.SuspendLayout();
            splitContainerBitmaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbInputGradientBitmap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGradientOutput).BeginInit();
            panelGradietnMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDegreeRotate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeightSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWhidtSize).BeginInit();
            SuspendLayout();
            // 
            // pb
            // 
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Dock = DockStyle.Fill;
            pb.Location = new Point(3, 3);
            pb.Name = "pb";
            pb.Size = new Size(1262, 519);
            pb.TabIndex = 0;
            pb.TabStop = false;
            // 
            // btnDraw
            // 
            btnDraw.Dock = DockStyle.Bottom;
            btnDraw.Location = new Point(0, 204);
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
            panel.Controls.Add(btnCopyBackground);
            panel.Controls.Add(btnSave);
            panel.Controls.Add(btnDraw);
            panel.Controls.Add(grbChar);
            panel.Controls.Add(grBoxBackground);
            panel.Controls.Add(grbFont);
            panel.Dock = DockStyle.Bottom;
            panel.Location = new Point(3, 522);
            panel.Name = "panel";
            panel.Size = new Size(1262, 238);
            panel.TabIndex = 7;
            // 
            // btnCopyBackground
            // 
            btnCopyBackground.Dock = DockStyle.Bottom;
            btnCopyBackground.Location = new Point(0, 140);
            btnCopyBackground.Name = "btnCopyBackground";
            btnCopyBackground.Size = new Size(1262, 33);
            btnCopyBackground.TabIndex = 10;
            btnCopyBackground.Text = "Kopiuj";
            btnCopyBackground.UseVisualStyleBackColor = true;
            btnCopyBackground.Click += btnCopyBackground_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(0, 173);
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
            tabPageGradientBmp.Controls.Add(splitContainerGradientMain);
            tabPageGradientBmp.Controls.Add(panelGradietnMenu);
            tabPageGradientBmp.Location = new Point(4, 24);
            tabPageGradientBmp.Name = "tabPageGradientBmp";
            tabPageGradientBmp.Padding = new Padding(3);
            tabPageGradientBmp.Size = new Size(1268, 763);
            tabPageGradientBmp.TabIndex = 1;
            tabPageGradientBmp.Text = "Dodaj gradient";
            tabPageGradientBmp.UseVisualStyleBackColor = true;
            // 
            // splitContainerGradientMain
            // 
            splitContainerGradientMain.Dock = DockStyle.Fill;
            splitContainerGradientMain.Location = new Point(3, 3);
            splitContainerGradientMain.Name = "splitContainerGradientMain";
            // 
            // splitContainerGradientMain.Panel1
            // 
            splitContainerGradientMain.Panel1.Controls.Add(listViewExpressions);
            // 
            // splitContainerGradientMain.Panel2
            // 
            splitContainerGradientMain.Panel2.Controls.Add(splitContainerBitmaps);
            splitContainerGradientMain.Size = new Size(1262, 529);
            splitContainerGradientMain.SplitterDistance = 173;
            splitContainerGradientMain.TabIndex = 4;
            // 
            // listViewExpressions
            // 
            listViewExpressions.Dock = DockStyle.Fill;
            listViewExpressions.Location = new Point(0, 0);
            listViewExpressions.Name = "listViewExpressions";
            listViewExpressions.Size = new Size(173, 529);
            listViewExpressions.TabIndex = 0;
            listViewExpressions.UseCompatibleStateImageBehavior = false;
            listViewExpressions.SelectedIndexChanged += listViewExpressions_SelectedIndexChanged;
            // 
            // splitContainerBitmaps
            // 
            splitContainerBitmaps.Dock = DockStyle.Fill;
            splitContainerBitmaps.Location = new Point(0, 0);
            splitContainerBitmaps.Name = "splitContainerBitmaps";
            // 
            // splitContainerBitmaps.Panel1
            // 
            splitContainerBitmaps.Panel1.Controls.Add(pbInputGradientBitmap);
            // 
            // splitContainerBitmaps.Panel2
            // 
            splitContainerBitmaps.Panel2.Controls.Add(pbGradientOutput);
            splitContainerBitmaps.Size = new Size(1085, 529);
            splitContainerBitmaps.SplitterDistance = 453;
            splitContainerBitmaps.TabIndex = 3;
            // 
            // pbInputGradientBitmap
            // 
            pbInputGradientBitmap.BorderStyle = BorderStyle.FixedSingle;
            pbInputGradientBitmap.Dock = DockStyle.Fill;
            pbInputGradientBitmap.Location = new Point(0, 0);
            pbInputGradientBitmap.Name = "pbInputGradientBitmap";
            pbInputGradientBitmap.Size = new Size(453, 529);
            pbInputGradientBitmap.SizeMode = PictureBoxSizeMode.AutoSize;
            pbInputGradientBitmap.TabIndex = 1;
            pbInputGradientBitmap.TabStop = false;
            // 
            // pbGradientOutput
            // 
            pbGradientOutput.BorderStyle = BorderStyle.FixedSingle;
            pbGradientOutput.Dock = DockStyle.Fill;
            pbGradientOutput.Location = new Point(0, 0);
            pbGradientOutput.Name = "pbGradientOutput";
            pbGradientOutput.Size = new Size(628, 529);
            pbGradientOutput.SizeMode = PictureBoxSizeMode.CenterImage;
            pbGradientOutput.TabIndex = 2;
            pbGradientOutput.TabStop = false;
            // 
            // panelGradietnMenu
            // 
            panelGradietnMenu.BorderStyle = BorderStyle.FixedSingle;
            panelGradietnMenu.Controls.Add(groupBox1);
            panelGradietnMenu.Controls.Add(chbRotateDirection);
            panelGradietnMenu.Controls.Add(btnCopy);
            panelGradietnMenu.Controls.Add(btnPaste);
            panelGradietnMenu.Controls.Add(numDegreeRotate);
            panelGradietnMenu.Controls.Add(btnRotate);
            panelGradietnMenu.Controls.Add(numHeightSize);
            panelGradietnMenu.Controls.Add(numWhidtSize);
            panelGradietnMenu.Controls.Add(btnMinusSize);
            panelGradietnMenu.Controls.Add(btnPlusSize);
            panelGradietnMenu.Controls.Add(btnAddGradient);
            panelGradietnMenu.Controls.Add(btnLoadGradientBitmap);
            panelGradietnMenu.Dock = DockStyle.Bottom;
            panelGradietnMenu.Location = new Point(3, 532);
            panelGradietnMenu.Name = "panelGradietnMenu";
            panelGradietnMenu.Size = new Size(1262, 228);
            panelGradietnMenu.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGradientEndForBitmap);
            groupBox1.Controls.Add(btnGradientStartForBitmap);
            groupBox1.Location = new Point(176, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(158, 106);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gradient tła";
            // 
            // btnGradientEndForBitmap
            // 
            btnGradientEndForBitmap.Location = new Point(77, 22);
            btnGradientEndForBitmap.Name = "btnGradientEndForBitmap";
            btnGradientEndForBitmap.Size = new Size(75, 75);
            btnGradientEndForBitmap.TabIndex = 4;
            btnGradientEndForBitmap.Text = "Koniec";
            btnGradientEndForBitmap.UseVisualStyleBackColor = true;
            btnGradientEndForBitmap.Click += btnGradientEndForBitmap_Click;
            // 
            // btnGradientStartForBitmap
            // 
            btnGradientStartForBitmap.Location = new Point(2, 22);
            btnGradientStartForBitmap.Name = "btnGradientStartForBitmap";
            btnGradientStartForBitmap.Size = new Size(75, 75);
            btnGradientStartForBitmap.TabIndex = 3;
            btnGradientStartForBitmap.Text = "Start";
            btnGradientStartForBitmap.UseVisualStyleBackColor = true;
            btnGradientStartForBitmap.Click += btnGradientStartForBitmap_Click;
            // 
            // chbRotateDirection
            // 
            chbRotateDirection.AutoSize = true;
            chbRotateDirection.Location = new Point(684, 39);
            chbRotateDirection.Name = "chbRotateDirection";
            chbRotateDirection.Size = new Size(107, 19);
            chbRotateDirection.TabIndex = 10;
            chbRotateDirection.Text = "Obróć w prawo";
            chbRotateDirection.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(16, 75);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(99, 58);
            btnCopy.TabIndex = 9;
            btnCopy.Text = "Kopiuj";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnPaste
            // 
            btnPaste.Location = new Point(16, 5);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(99, 55);
            btnPaste.TabIndex = 8;
            btnPaste.Text = "Wklej";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // numDegreeRotate
            // 
            numDegreeRotate.Location = new Point(631, 37);
            numDegreeRotate.Name = "numDegreeRotate";
            numDegreeRotate.Size = new Size(41, 23);
            numDegreeRotate.TabIndex = 7;
            numDegreeRotate.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(550, 35);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(75, 23);
            btnRotate.TabIndex = 6;
            btnRotate.Text = "+";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // numHeightSize
            // 
            numHeightSize.Location = new Point(456, 78);
            numHeightSize.Name = "numHeightSize";
            numHeightSize.Size = new Size(41, 23);
            numHeightSize.TabIndex = 5;
            numHeightSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numWhidtSize
            // 
            numWhidtSize.Location = new Point(456, 37);
            numWhidtSize.Name = "numWhidtSize";
            numWhidtSize.Size = new Size(41, 23);
            numWhidtSize.TabIndex = 4;
            numWhidtSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnMinusSize
            // 
            btnMinusSize.Location = new Point(375, 78);
            btnMinusSize.Name = "btnMinusSize";
            btnMinusSize.Size = new Size(75, 23);
            btnMinusSize.TabIndex = 3;
            btnMinusSize.Text = "-";
            btnMinusSize.UseVisualStyleBackColor = true;
            btnMinusSize.Click += btnMinusSize_Click;
            // 
            // btnPlusSize
            // 
            btnPlusSize.Location = new Point(375, 37);
            btnPlusSize.Name = "btnPlusSize";
            btnPlusSize.Size = new Size(75, 23);
            btnPlusSize.TabIndex = 2;
            btnPlusSize.Text = "+";
            btnPlusSize.UseVisualStyleBackColor = true;
            btnPlusSize.Click += btnPlusSize_Click;
            // 
            // btnAddGradient
            // 
            btnAddGradient.Location = new Point(178, 132);
            btnAddGradient.Name = "btnAddGradient";
            btnAddGradient.Size = new Size(156, 58);
            btnAddGradient.TabIndex = 1;
            btnAddGradient.Text = "Dodaj gradient";
            btnAddGradient.UseVisualStyleBackColor = true;
            btnAddGradient.Click += btnAddGradient_Click;
            // 
            // btnLoadGradientBitmap
            // 
            btnLoadGradientBitmap.Location = new Point(16, 145);
            btnLoadGradientBitmap.Name = "btnLoadGradientBitmap";
            btnLoadGradientBitmap.Size = new Size(99, 52);
            btnLoadGradientBitmap.TabIndex = 0;
            btnLoadGradientBitmap.Text = "Otwórz obraz";
            btnLoadGradientBitmap.UseVisualStyleBackColor = true;
            btnLoadGradientBitmap.Click += btnLoadGradientBitmap_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 791);
            Controls.Add(tabControlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            splitContainerGradientMain.Panel1.ResumeLayout(false);
            splitContainerGradientMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerGradientMain).EndInit();
            splitContainerGradientMain.ResumeLayout(false);
            splitContainerBitmaps.Panel1.ResumeLayout(false);
            splitContainerBitmaps.Panel1.PerformLayout();
            splitContainerBitmaps.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerBitmaps).EndInit();
            splitContainerBitmaps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbInputGradientBitmap).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGradientOutput).EndInit();
            panelGradietnMenu.ResumeLayout(false);
            panelGradietnMenu.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numDegreeRotate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeightSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWhidtSize).EndInit();
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
        private Button btnPaste;
        private Button btnCopy;
        private CheckBox chbRotateDirection;
        private GroupBox groupBox1;
        private Button btnGradientEndForBitmap;
        private Button btnGradientStartForBitmap;
        private SplitContainer splitContainerBitmaps;
        private OpenFileDialog openFileDialog;
        private Button btnCopyBackground;
        private SplitContainer splitContainerGradientMain;
        private ListView listViewExpressions;
    }
}