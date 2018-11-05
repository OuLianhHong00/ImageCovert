using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 编写者：欧连红
/// 实现功能：图片的打开、保存、底片、灰度、柔化、锐化、马赛克、雾化以及浮雕
/// </summary>
namespace ImageProcess
{
    //图片特效主界面
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
        }
        Image img;
        //打开图片
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            //选择的文件名称
            string imgFileName = ofd.FileName;
            img = Image.FromFile(imgFileName);
            picOriginal.BackgroundImage = img;

        }
        //底片效果
        private void btnReverse_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(img);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color c = bmp.GetPixel(i, j);
                    Color cAfter = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    bmp.SetPixel(i, j, cAfter);
                }
            }
            picAfter.BackgroundImage = bmp;

        }
        //灰度化
        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(img);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color c = bmp.GetPixel(i, j);
                    int gray = (c.R + c.G + c.B) / 3;
                    // int gray=(int)
                    Color cAfter = Color.FromArgb(gray, gray, gray);
                    bmp.SetPixel(i, j, cAfter);
                }
            }
            picAfter.BackgroundImage = bmp;
        }
        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            picAfter.BackgroundImage.Save(sfd.FileName);
        }
        //浮雕
        private void btnRelief_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(img);
            for (int i = 0; i < bmp.Width - 1; i++)
            {
                for (int j = 0; j < bmp.Height - 1; j++)
                {
                    Color c = bmp.GetPixel(i, j);
                    Color a = bmp.GetPixel(i + 1, j + 1);
                    int r = Math.Abs(c.R - a.R + 128);
                    int g = Math.Abs(c.G - a.G + 128);
                    int b = Math.Abs(c.B - a.B + 128);
                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;
                    if (r < 0) r = 0;
                    if (g < 0) g = 0;
                    if (b < 0) b = 0;
                    Color cAfter = Color.FromArgb(r, g, b);
                    bmp.SetPixel(i, j, cAfter);
                }
            }
            picAfter.BackgroundImage = bmp;
        }
       
        //锐化
        private void btnSharpen_Click(object sender, EventArgs e)
        {
            //拉普拉斯模板
            int[] laplacian = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
            Bitmap bmp = new Bitmap(img);
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    int r = 0, g = 0, b = 0;
                    int index = 0;
                    for (int col = -1; col <= 1; col++)
                    {
                        for (int row = -1; row <= 1; row++)
                        {
                            Color c = bmp.GetPixel(i + row, j + col);
                            r += c.R * laplacian[index];
                            g += c.G * laplacian[index];
                            b += c.B * laplacian[index];
                            index++;
                        }
                    }
                    r = r > 255 ? 255 : r;
                    r = r < 0 ? 0 : r;
                    g = g > 255 ? 255 : g;
                    g = g < 0 ? 0 : g;
                    b = b > 255 ? 255 : b;
                    b = b < 0 ? 0 : b;

                    Color cAfter = Color.FromArgb(r, g, b);
                    bmp.SetPixel(i - 1, j - 1, cAfter);
                }
            }
            picAfter.BackgroundImage = bmp;
        }
        //雾化
        private void btnHorse_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(img);
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    Random myRandom = new Random();
                    int k = myRandom.Next(123456);
                    int dx = i + k % 19;
                    if (dx >= bmp.Width)
                        dx = bmp.Width - 1;
                    int dy = j + k % 19;
                    if (dy >= bmp.Height)
                        dy = bmp.Height - 1;
                    Color c = bmp.GetPixel(dx, dy);
                    Color cAfter = Color.FromArgb(c.R, c.G, c.B);
                    bmp.SetPixel(i, j, cAfter);
                }
            }
            picAfter.BackgroundImage = bmp;
        }
        //马赛克
        private void btnMosaic_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(img);
            Single maWidth = 1f, maHeight = 1f;
            int effectWidth = 20;
            for (int i = 0; i < bmp.Height * maHeight; i += effectWidth)
            {
                for (int j = 0; j < bmp.Width * maWidth; j += effectWidth)
                {
                    int r = 0, g = 0, b = 0;
                    int bluePixelCount = 0;
                    for (int x = j; (x < j + effectWidth && x < bmp.Width); x++)
                    {
                        for (int y = i; (y < i + effectWidth && y < bmp.Height); y++)
                        {
                            Color c = bmp.GetPixel(x, y);
                            r += c.R;
                            g += c.G;
                            b += c.B;
                            bluePixelCount++;
                        }
                    }
                    r = r / bluePixelCount;
                    g = g / bluePixelCount;
                    b = b / bluePixelCount;
                    for (int x = j; (x < j + effectWidth && x < bmp.Width); x++)
                    {
                        for (int y = i; (y < i + effectWidth && y < bmp.Height); y++)
                        {
                            Color cAfter = Color.FromArgb(r, g, b);
                            bmp.SetPixel(x, y, cAfter);
                        }
                    }
                }

            }
            picAfter.BackgroundImage = bmp;
        }
        //柔化
        private void btnDiffusion_Click(object sender, EventArgs e)
        {
            int[] Gauss = { 1, 2, 1, 2, 4, 2, 1, 2, 1 };
            Bitmap bmp = new Bitmap(img);
            for (int i = 1; i < bmp.Width-1; i++) {
                for (int j = 1; j < bmp.Height-1; j++) {
                    int r = 0, g = 0, b = 0;
                    int index = 0;
                    for (int col = -1; col <= 1; col++) {
                        for (int row = -1; row <= 1; row++) {
                            Color c = bmp.GetPixel(i+row,j+col);
                            r += c.R * Gauss[index];
                            g += c.R * Gauss[index];
                            b += c.R + Gauss[index];
                            index++;
                        }
                    }
                    r /= 16;
                    g /=16;
                    b /= 16;
                    r = r > 255 ? 255 : r;
                    r = r < 0 ? 0 : r;
                    g = g > 255 ? 255 : g;
                    g = g < 0 ? 0 : g;
                    b = b > 255 ? 255 : b;
                    b = b < 0 ? 0 : b;
                    Color cAfter = Color.FromArgb(r, g, b);
                    bmp.SetPixel(i-1, j-1, cAfter);
                }
            }
            picAfter.BackgroundImage = bmp;
        }
       
    }
}

