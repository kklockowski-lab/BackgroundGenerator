using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Resources;
using System.Reflection;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BackgroundGenerator
{
    public partial class Main : Form
    {
        Color startBackColor;
        Color endBackColor;
        Color startCharColor;
        Color endCharColor;
        Font font;
        Image image;


        //Tab 2 - zmiana gradientu dla wczytywanych obrazków:
        Image inputImage = null;
        Bitmap outputBitmap = null;
        Color startGriadentColorForChangeBitmap = Color.Red;
        Color endGriadentColorForChangeBitmap = Color.Blue;


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

            startGriadentColorForChangeBitmap = Properties.Settings.Default.StartGradientColor;
            endGriadentColorForChangeBitmap = Properties.Settings.Default.EndGradientColor;

            if (font == null) { font = new Font("Arial", 15); }

            comboBoxFont.Text = font.Name;
            nuFontSize.Value = (int)font.Size;
            btnStartBackColor.BackColor = startBackColor;
            btnEndBakColor.BackColor = endBackColor;
            btnStartCharColor.BackColor = startCharColor;
            btnEndCharColor.BackColor = endCharColor;

            btnGradientStartForBitmap.BackColor = startGriadentColorForChangeBitmap;
            btnGradientEndForBitmap.BackColor = endGriadentColorForChangeBitmap;

            chbDrawSings.Checked = Properties.Settings.Default.DrawChar;

            btnDraw_Click(this, null);

            LoadImagesIntoListView();
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

                if (chbDrawSings.Checked)
                {
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

            Properties.Settings.Default.StartGradientColor = startGriadentColorForChangeBitmap;
            Properties.Settings.Default.EndGradientColor = endGriadentColorForChangeBitmap;

            Properties.Settings.Default.DrawChar = chbDrawSings.Checked;

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


        private void btnLoadGradientBitmap_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var image = Bitmap.FromFile(openFileDialog.FileName);
                pbInputGradientBitmap.Image = image;
                outputBitmap = (Bitmap)image;
                pbGradientOutput.Image = image;
            }
        }

        private void btnAddGradient_Click(object sender, EventArgs e)
        {
            if (outputBitmap is null) return;
            Bitmap bmp = new Bitmap(outputBitmap);

            Color gradientStart = startGriadentColorForChangeBitmap;
            Color gradientEnd = endGriadentColorForChangeBitmap;

            // Przejœcie przez piksele obrazu
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);

                    // Sprawdzenie czy piksel jest czarny
                    if (pixelColor.R < 200 && pixelColor.G < 200 && pixelColor.B < 200)
                    {
                        // Obliczenie proporcji dla gradientu
                        float ratio = (float)y / bmp.Height;

                        // Mieszanie kolorów gradientu
                        int r = (int)(gradientStart.R * (1 - ratio) + gradientEnd.R * ratio);
                        int g = (int)(gradientStart.G * (1 - ratio) + gradientEnd.G * ratio);
                        int b = (int)(gradientStart.B * (1 - ratio) + gradientEnd.B * ratio);

                        Color newColor = Color.FromArgb(r, g, b);

                        //Color newColor = Color.Red;

                        // Ustawienie nowego koloru dla pikseli
                        bmp.SetPixel(x, y, newColor);
                    }
                }
            }

            pbGradientOutput.Image = bmp;
            outputBitmap = bmp;

        }

        private void btnPlusSize_Click(object sender, EventArgs e)
        {
            if (outputBitmap is null) return;

            int newWidth = outputBitmap.Width + (int)numWhidtSize.Value; // Nowa szerokoœæ
            int newHeight = outputBitmap.Height + (int)numHeightSize.Value; // Nowa wysokoœæ

            Bitmap resizedBmp = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(resizedBmp))
            {
                g.Clear(Color.White);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(outputBitmap, 0, 0, newWidth, newHeight);
            }

            // Wyœwietlenie zmniejszonego obrazu w PictureBox
            pbGradientOutput.Image = resizedBmp;
            outputBitmap = resizedBmp;
        }

        private void btnMinusSize_Click(object sender, EventArgs e)
        {
            if (outputBitmap is null) return;

            int newWidth = outputBitmap.Width - (int)numWhidtSize.Value; // Nowa szerokoœæ
            int newHeight = outputBitmap.Height - (int)numHeightSize.Value; // Nowa wysokoœæ

            Bitmap resizedBmp = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(resizedBmp))
            {
                g.Clear(Color.White);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(outputBitmap, 0, 0, newWidth, newHeight);
            }

            // Wyœwietlenie zmniejszonego obrazu w PictureBox
            pbGradientOutput.Image = resizedBmp;
            outputBitmap = resizedBmp;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (outputBitmap is null) return;
            int direction = chbRotateDirection.Checked ? 1 : -1;
            float angle = direction * (float)numDegreeRotate.Value; // K¹t obrotu w stopniach

            Size newSize = GetRotatedSize(outputBitmap.Size, angle);
            Bitmap rotatedBmp = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                g.Clear(Color.White);
                // Ustawienie punktu, wokó³ którego ma byæ obracany obraz
                g.TranslateTransform(newSize.Width / 2, newSize.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-outputBitmap.Width / 2, -outputBitmap.Height / 2);

                // Rysowanie obrazu na nowym bitmapie
                g.DrawImage(outputBitmap, new Point(0, 0));
            }


            pbGradientOutput.Image = rotatedBmp;
            outputBitmap = rotatedBmp;

        }

        private Size GetRotatedSize(Size originalSize, float angle)
        {
            double radians = angle * Math.PI / 180.0;
            double cosTheta = Math.Cos(radians);
            double sinTheta = Math.Sin(radians);

            int width = originalSize.Width;
            int height = originalSize.Height;

            int newWidth = (int)Math.Round(Math.Abs(width * cosTheta) + Math.Abs(height * sinTheta));
            int newHeight = (int)Math.Round(Math.Abs(width * sinTheta) + Math.Abs(height * cosTheta));

            return new Size(newWidth, newHeight);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                // Pobranie obrazu z schowka
                Image image = Clipboard.GetImage();
                if (image != null)
                {
                    // Przypisanie obrazu do PictureBox
                    pbInputGradientBitmap.Image = image;
                    outputBitmap = (Bitmap)image;
                    pbGradientOutput.Image = image;
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (pbGradientOutput.Image != null)
            {
                // Tworzenie bitmapy z obrazu PictureBox
                Bitmap bmp = new Bitmap(pbGradientOutput.Image);

                // Kopiowanie obrazu do schowka
                Clipboard.SetImage(bmp);
            }
        }

        private void btnGradientStartForBitmap_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                startGriadentColorForChangeBitmap = colorDialog.Color;
                btnGradientStartForBitmap.BackColor = startGriadentColorForChangeBitmap;
            }
        }

        private void btnGradientEndForBitmap_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                endGriadentColorForChangeBitmap = colorDialog.Color;
                btnGradientEndForBitmap.BackColor = endGriadentColorForChangeBitmap;
            }

        }

        private void btnCopyBackground_Click(object sender, EventArgs e)
        {
            if (pb.Image != null)
            {
                // Tworzenie bitmapy z obrazu PictureBox
                Bitmap bmp = new Bitmap(pb.Image);

                // Kopiowanie obrazu do schowka
                Clipboard.SetImage(bmp);
            }
        }

        private void LoadImagesIntoListView()
        {
            // Tworzenie ImageList
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(120, 64); // Rozmiar ikon
            var bitmapList = GetAllBitmaps();


            foreach (var bitRes in bitmapList)
            {
                imageList.Images.Add((Image)bitRes.Bitmap);
                ListViewItem item = new ListViewItem();
                item.ImageIndex = bitRes.Id;
                listViewExpressions.Items.Add(item);

            }
            listViewExpressions.LargeImageList = imageList;
            listViewExpressions.View = View.LargeIcon;

        }

        private static List<BitmapResource> bitmaps = null;
        public static List<BitmapResource> GetAllBitmaps()
        {
         bitmaps = new List<BitmapResource>();

            // Pobierz typ klasy Expression
            Type expressionType = typeof(Expression);

            // Przeszukaj wszystkie w³aœciwoœci w klasie Expression
            PropertyInfo[] properties = expressionType.GetProperties(BindingFlags.NonPublic | BindingFlags.Static);


            int index = 0;
            foreach (var property in properties)
            {
                // SprawdŸ, czy w³aœciwoœæ zwraca Bitmap
                if (property.PropertyType == typeof(Bitmap))
                {
                    // Pobierz wartoœæ w³aœciwoœci
                    Bitmap bitmap = property.GetValue(null) as Bitmap;
                    if (bitmap != null)
                    {
                        bitmaps.Add(new BitmapResource { Bitmap = bitmap, Id = index++ });
                    }
                }
            }

            return bitmaps;
        }

        private void listViewExpressions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewExpressions.SelectedItems.Count > 0)
            {
                pbInputGradientBitmap.Image = bitmaps.Where(b => b.Id == listViewExpressions.SelectedIndices[0]).FirstOrDefault().Bitmap;
                pbGradientOutput.Image = pbInputGradientBitmap.Image;
                outputBitmap = (Bitmap)pbGradientOutput.Image;
            }
        }
    }
}