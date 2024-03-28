using System;
using System.Collections.Generic;

using System.Text;


namespace AngelLayout
{
 public   class MouseKeyboard//,IMessageFilter
    {
        //protected override void WndProc(ref Message m)
        //{
        //    const int WM_SYSCOMMAND = 0x0112;
        //    const int SC_CLOSE = 0xF060;

        //    //if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
        //    //{
        //    //    // 屏蔽传入的消息事件   
        //    //    this.WindowState = FormWindowState.Minimized;
        //    //    return;
        //    //}
        //    base.WndProc(ref m);
        //}
        //protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        //{
        //    int WM_KEYDOWN = 256;
        //    int WM_SYSKEYDOWN = 260;

        //    if (msg.Msg == WM_KEYDOWN | msg.Msg == WM_SYSKEYDOWN)
        //    {
        //        //     textBox1.AppendText( keyData.ToString());
        //        switch (keyData)
        //        {
        //            case Keys.Escape:
        //                this.Close();

        //                break;
        //        }
        //    }
        //    return false;
        //}
        //private const int WM_LBUTTONDOWN = 0x201;
        //public bool PreFilterMessage(ref Message m)
        //{
        //    //
        //    //if (m.Msg == 522)
        //    if (m.Msg == WM_LBUTTONDOWN)
        //    {

        //        // Do stuffs
        //        //m.Result.
        //    }
        //    return false;
        //}

    }
}
