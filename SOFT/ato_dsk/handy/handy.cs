using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;
using System.Net;
using System.IO;

[ComVisible(true)]
public partial class handy : Form
{
    private WebBrowser webBrowser1;

    public handy()
    {
        browse_register.set_features(6000);
        InitializeComponent();
        DoubleBuffered = true;
        //using JoyKeys.Voluntary;
        //JoystickAPI.JOYINFOEX infoEx = new JoystickAPI.JOYINFOEX();
        //infoEx.dwSize = Marshal.SizeOf(typeof(JoystickAPI.JOYINFOEX));
        //infoEx.dwFlags = (int)JoystickAPI.JOY_RETURNBUTTONS;
        //int result = JoystickAPI.joyGetPosEx(JoystickAPI.JOYSTICKID1, ref infoEx);

        webBrowser1 = new System.Windows.Forms.WebBrowser();
        webBrowser1.Name = "webBrowser1";
        //   webBrowser1.ObjectForScripting = this;
        webBrowser1.ScriptErrorsSuppressed = true;
        webBrowser1.Navigated += new WebBrowserNavigatedEventHandler(webBrowser1_Navigated);
        webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);

        //short s1 = 23;
        //short s2 = 42;

        //short s = s1 + s2;
    }

    void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
          textBox1.Text = webBrowser1.DocumentText;
    }

    void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
    {
      
    }
    #region 无边框拖动效果
    [DllImport("user32.dll")]//拖动无窗体的控件
    public static extern bool ReleaseCapture();
    [DllImport("user32.dll")]
    public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
    public const int WM_SYSCOMMAND = 0x0112;
    public const int SC_MOVE = 0xF010;
    public const int HTCAPTION = 0x0002;

    private void Start_MouseDown(object sender, MouseEventArgs e)
    {
        //拖动窗体
        ReleaseCapture();
        SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
    }
    #endregion
    private void textBox1_MouseMove(object sender, MouseEventArgs e)
    {
        //label1.ForeColor = Pixels.GetColor(e.X, e.Y, this);
        //label1.Text = Pixels.GetColor(e.X, e.Y, this).ToString();
    }
    private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
    {
        //if (e.KeyCode == Keys.Enter)
        //    textBox1.Text = Komad.Batch("file-search.bat", this.toolStripTextBox1.Text);
    }



    private void toolStripLabel1_Click(object sender, EventArgs e)
    {
        //  textBox1.Text = Komad.Batch(toolStripTextBox1.Text);

    }

    private void toolGrid_Click(object sender, EventArgs e)
    {
      
    }

    private void Levis_Click(object sender, EventArgs e)
    {
        //new Levis().Show();
    }

    private void Rect_Click(object sender, EventArgs e)
    {

        //new Rect().Show();
    }

    private void Midow_Load(object sender, EventArgs e)
    {

        //instant itt = new instant();
        //itt.eydix = 0;
        //itt.issaic.record();
        //textBox1.Text = itt.issaic.isakes.ToString();
    }

    private void Rabber_Click(object sender, EventArgs e)
    {
        new carowlet().Show();
    }

    private void Karet_Click(object sender, EventArgs e)
    {
        //new Karet().Show();
    }

    private void Curl_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text = console.batch("curl.exe", "curl " + textBox.Text);
    }

    private void ShapeF_Click(object sender, EventArgs e)
    {
        // new FormShape().Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        cybert cyb = new cybert();
        cyb.orginal = textBox1.Text;

        textBox2.Text = cyb.each_ranket();
        textBox3.Text = cyb.each_eidix();
        textBox4.Text = cyb.each_hexet();

        button2.Text = "Cybert Length:" + textBox1.Text.Length.ToString();
    }

    private void button3_Click(object sender, EventArgs e)
    {
       webBrowser1.Navigate(textBox.Text);
        //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(textBox.Text);    //创建一个请求示例
        //HttpWebResponse response = (HttpWebResponse)request.GetResponse();　　//获取响应，即发送请求
        //Stream responseStream = response.GetResponseStream();
        //StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
        //string html = streamReader.ReadToEnd();
        //textBox1.Text = html;
    }

    private void csc_make_Click(object sender, EventArgs e)
    {
        var result = ccskie.make();
        textBox1.Text = result;
        System.Diagnostics.Process.Start("main.exe");
    }

    private void Grid_Click(object sender, EventArgs e)
    {
        new ayrickes().Show();
     }

    private void toolStripLabel1_Click_1(object sender, EventArgs e)
    {
        new entrike().Show();
    }

    private void Midow_Shown(object sender, EventArgs e)
    {
        //   
    }


}
