using System;
using System.Runtime.InteropServices;
using System.Drawing;

class erick_screen
{
    //win32 api
    [DllImport("user32.dll")]
    static extern IntPtr GetDC(IntPtr ptr);
    [DllImport("gdi32.dll")]
    static extern int GetDeviceCaps(
   IntPtr hdc, // handle to DC
   int nIndex // index of capability
   );
    [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
    static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);

    // devicecaps常量
    const int
        horzres = 8,
        vertres = 10,
        logpixels_x = 88,
        logpixels_y = 90,
        desktop_vertres = 117,
        desktop_horzres = 118;

    public static int bound_height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
    public static int bound_width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
    /// <summary>
    /// 获取屏幕分辨率当前物理大小
    /// </summary>
    public static Size work_area
    {
        get
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            Size size = new Size();
            size.Width = GetDeviceCaps(hdc, horzres);
            size.Height = GetDeviceCaps(hdc, vertres);
            ReleaseDC(IntPtr.Zero, hdc);
            return size;
        }
    }
    /// <summary>
    /// 当前系统DPI_X 大小 一般为96
    /// </summary>
    public static int dpx
    {
        get
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            int DpiX = GetDeviceCaps(hdc, logpixels_x);
            ReleaseDC(IntPtr.Zero, hdc);
            return DpiX;
        }
    }
    /// <summary>
    /// 当前系统DPI_Y 大小 一般为96
    /// </summary>
    public static int dpy
    {
        get
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            int DpiX = GetDeviceCaps(hdc, logpixels_y);
            ReleaseDC(IntPtr.Zero, hdc);
            return DpiX;
        }
    }
    /// <summary>
    /// 获取真实设置的桌面分辨率大小
    /// </summary>
    public static Size desktop
    {
        get
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            Size size = new Size();
            size.Width = GetDeviceCaps(hdc, desktop_horzres);
            size.Height = GetDeviceCaps(hdc, desktop_vertres);
            ReleaseDC(IntPtr.Zero, hdc);
            return size;
        }
    }

    /// <summary>
    /// 获取宽度缩放百分比
    /// </summary>
    public static float scale_x
    {
        get
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            int t = GetDeviceCaps(hdc, desktop_horzres);
            int d = GetDeviceCaps(hdc, horzres);
            float ScaleX = (float)GetDeviceCaps(hdc, desktop_horzres) / (float)GetDeviceCaps(hdc, horzres);
            ReleaseDC(IntPtr.Zero, hdc);
            return ScaleX;
        }
    }
    /// <summary>
    /// 获取高度缩放百分比
    /// </summary>
    public static float scale_y
    {
        get
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            float ScaleY = (float)(float)GetDeviceCaps(hdc, desktop_vertres) / (float)GetDeviceCaps(hdc, vertres);
            ReleaseDC(IntPtr.Zero, hdc);
            return ScaleY;
        }
    }

}