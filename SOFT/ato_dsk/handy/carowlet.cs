using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;


public partial class carowlet : Form
{

    //发送消息
    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
    //获取滚动条位置
    [DllImport("user32")]
    public static extern int GetScrollPos(IntPtr hwnd, int nBar);
    //设置滚动条位置
    [DllImport("user32.dll")]
    public static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);
    public const int EM_LINESCROLL = 0xb6;

    public carowlet()
    {
        InitializeComponent();
        textBox1.MouseWheel += new MouseEventHandler(textBox1_MouseWheel);
        textBox1.drag_event();
        textBox2.SelectionStart = 0;
    }
    /// <summary>
    /// 滚动条位置
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    void textBox1_MouseWheel(object sender, MouseEventArgs e)
    {
        Text = textBox1.CaretLine.ToString() + "  " + textBox1.CaretColumn.ToString();
        ////textBox2.MoveCaret(textBox1.CaretLine, textBox2.CaretColumn);
        ////int i = GetScrollPos(this.textBox1.Handle, 1);
        //int t1 = GetScrollPos(this.textBox1.Handle, 1);
        //Text = e.Delta.ToString() + " " + t1.ToString();
        ////最后一个参数
        ////1 垂直滚动条向下滚动
        ////-1 向上
        ////SetScrollPos(this.textBox2.Handle,   1,t1,true);
        ////SendMessage(this.textBox2.Handle, EM_LINESCROLL, 0, 0);
        //if (e.Delta == -120)
        //{
        //    //    SendMessage(this.textBox1.Handle, EM_LINESCROLL, 0, 3);
        //    SendMessage(this.textBox2.Handle, EM_LINESCROLL, 0, 3);
        //}

        //else if (e.Delta == 120)
        //{
        //    //    SendMessage(this.textBox1.Handle, EM_LINESCROLL, 0, 3);
        //    SendMessage(this.textBox2.Handle, EM_LINESCROLL, 0, -3);
        //}
        ////textBox1.pos
    }

    private void Komet_Load(object sender, EventArgs e)
    {

    }

    private void ketub1_TextChanged(object sender, EventArgs e)
    {

    }

    //private void listBox3_DrawItem(object sender, DrawItemEventArgs e)
    //{
    //    e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
    //    if (e.Index >= 0)
    //    {
    //        StringFormat sStringFormat = new StringFormat();
    //        sStringFormat.LineAlignment = StringAlignment.Center;
    //        e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
    //    }
    //    e.DrawFocusRectangle();
    //}

    //private void listBox3_MeasureItem(object sender, MeasureItemEventArgs e)
    //{
    //  e.ItemHeight = e.ItemHeight ;
    //}

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
    int lineNumber = 1;
    private void button1_Click(object sender, EventArgs e)
    {
        //  textBox1.
        //textBox1.Lines.SetValue(Convert.ToString(lineNumber++), 3);
        //textBox1.Refresh();
        //var path = Environment.CurrentDirectory.Replace("\\bin\\Debug", "\\handy\\");
        //var text1 = File.ReadAllText(path + "paragraph.txt", Encoding.Default);
        //var text2 = File.ReadAllText(path + "tablet.txt", Encoding.Default);
        //var text3 = File.ReadAllText(path + "single-line.txt", Encoding.Default);
        var lines = textBox1.Lines;

        var s1 = textBox1.Text.Split("\r".ToCharArray());
        var s2 = textBox1.Text.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        var s3 = textBox1.Text.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 行号处理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {
        //textBox2.Clear();
        //var lines = textBox1.Lines;
        //int n = 0;
        //foreach (var ln in lines)
        //{
        //    n++;
        //    textBox2.AppendText(n.ToString());
        //    textBox2.AppendText(Environment.NewLine);
        //}
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        var a = textBox1.SelectedText;
        var s = textBox1.SelectionStart;
        var l = textBox1.SelectionLength;

    }

    //private void textBox1_DragEnter(object sender, DragEventArgs e)
    //{
    //    e.Effect = DragDropEffects.Copy;
    //}

    //private void textBox1_DragDrop(object sender, DragEventArgs e)
    //{
    //    textBox1.Text = (e.Data.GetData(DataFormats.UnicodeText)).ToString();
    //}
}

