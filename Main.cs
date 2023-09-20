using System.Drawing.Drawing2D;
using System.Drawing;

namespace GeneratorGrafiki
{
    public partial class Main : Form
    {
        Color startBackColor;
        Color endBackColor;
        Color startCharColor;
        Color endCharColor;
        Font font;
        Image image;


        public Main()
        {
            InitializeComponent();

            FontFamily[] fontFamilies = FontFamily.Families;

            foreach (FontFamily fontFamily in fontFamilies)
            {
                comboBoxFont.Items.Add(fontFamily.Name);
            }

            startBackColor = Properties.Settings.Default.StartBackColor;
            endBackColor = Properties.Settings.Default.EndBackColor;
            startCharColor = Properties.Settings.Default.StartCharColor;
            endCharColor = Properties.Settings.Default.EndBackColor;
            endCharColor = Properties.Settings.Default.EndBackColor;
            font = Properties.Settings.Default.Font;

            if (font == null) { font = new Font("Arial", 15); }

            comboBoxFont.Text = font.Name;
            nuFontSize.Value = (int)font.Size;
            btnStartBackColor.BackColor = startBackColor;
            btnEndBakColor.BackColor = endBackColor;
            btnStartCharColor.BackColor = startCharColor;
            btnEndCharColor.BackColor = endCharColor;

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {

            image = new Bitmap(pb.Width, pb.Height);

            using (Graphics graphics = Graphics.FromImage(image))
            {

                // Rysowanie gradientu t³a
                Rectangle rectBack = new Rectangle(0, 0, pb.Width, pb.Height);
                LinearGradientBrush brushBack = new LinearGradientBrush(rectBack,
                                                                        startBackColor,
                                                                        endBackColor,
                                                                        LinearGradientMode.Vertical);
                graphics.FillRectangle(brushBack, rectBack);
                Random random = new Random();

                // Wyœwietlanie znaków
                List<string> chars = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\u03C0",
                                                       "x", ",", "y,", "z,", "e",  "\u0394,", "\u221A" };

                int charSize = (int)font.Size;
                for (int x = 0; x < pb.Width; x = x + charSize)
                {
                    int diff = random.Next(charSize, 2 * charSize);
                    for (int y = 0 - diff; y < pb.Height; y = y + charSize)
                    {
                        int d = random.Next(0, chars.Count);
                        Rectangle rect = new Rectangle(x, y, 3 * charSize, 3 * charSize);
                        LinearGradientBrush brush = new LinearGradientBrush(rect,
                                                                            startCharColor,
                                                                            endCharColor,
                                                                            LinearGradientMode.Horizontal);

                        graphics.DrawString(chars[d], font, brush, rect);
                    }
                }
            }

            pb.Image = image;
            pb.Invalidate();
        }

        private void btnStartBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                startBackColor = colorDialog.Color;
                btnStartBackColor.BackColor = startBackColor;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog.Font = font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog.Font;
                comboBoxFont.Text = font.Name;
                nuFontSize.Value = (decimal)font.Size;
            }
        }

        private void btnEndBakColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = endBackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                endBackColor = colorDialog.Color;
                btnEndBakColor.BackColor = endBackColor;
            }
        }

        private void btnStartCharColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                startCharColor = colorDialog.Color;
                btnStartCharColor.BackColor = startCharColor;
            }
        }

        private void btnEndCharColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                endCharColor = colorDialog.Color;
                btnEndCharColor.BackColor = endCharColor;
            }
        }

        private void nuFontSize_ValueChanged(object sender, EventArgs e)
        {
            font = new Font(font.Name, (int)nuFontSize.Value);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.StartBackColor = startBackColor;
            Properties.Settings.Default.EndBackColor = endBackColor;
            Properties.Settings.Default.StartCharColor = startCharColor;
            Properties.Settings.Default.EndBackColor = endCharColor;
            Properties.Settings.Default.Font = font;

            Properties.Settings.Default.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(image is null) && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(image);
                bmp.Save(saveFileDialog.FileName);
            }
        }

        private void comboBoxFont_TextChanged(object sender, EventArgs e)
        {
            font = new Font(comboBoxFont.Text, font.Size);
        }
    }
}