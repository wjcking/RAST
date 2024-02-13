using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public partial class entrike : Form
{

    [DllImport("Gdi32.dll ")]
    public static extern int SetPixel(IntPtr hDC, int x, int y, int color);

    //     Bitmap bitmap = new Bitmap(1555, 1555,System.Drawing.Imaging.PixelFormat.Format64bppArgb);
    Bitmap[] bitmaps;
    public entrike()
    {
        InitializeComponent();
        bitmaps = new Bitmap[200];
        for (int i = 0; i < 200; i++)
        {
            bitmaps[i] = new Bitmap(200, 200);
        }
        //     picture.Image = bitmap;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        //  base.OnPaint(e);
    }
    private void Elyick_Paint(object sender, PaintEventArgs e)
    {
    }
    void smit(int width, int height, PictureBox picture)
    {
        var w = 0; var h = 0;
        for (int i = 0; i < 25; i++)
        {
            for (w = 0; w < width; w++)
            {
                for (h = 0; h < height; h++)
                {
                    Random rd = new Random();
                    int r = rd.Next(123, 255);
                    rd = new Random();
                    int g = rd.Next(0, 255);
                    rd = new Random();
                    int b = rd.Next(21, 255);
                    
                    bitmaps[i].SetPixel(0, 0, Color.FromArgb(r, g, b));
                    //bitmaps[i].SetPixel(w, h, Color.FromArgb(r, g, b));
                }

            }


            //w++;
            //h++;
            //width++;
            //height++;
            picture.Image = bitmaps[i];
        }
    }
    private void timer_Tick(object sender, EventArgs e)
    {

        // smit(1,1,picture);
        // smit(2,2,pictureBox1);
        // smit(3,3,pictureBox2);
        smit(1, 1, pictureBox3);
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
}
