using System.IO;
using System;
using System.Threading;

using System.ComponentModel;
using System.Windows.Forms;


class Inn
{ 
    public static int main_link = 1;
    //重载签名错误
    [STAThread]
    public static int Main(string[] lins)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new handy());
        //try
        //{        }
        //catch (Exception e)
        //{
        //    MessageBox.Show(e.Message);
        //}
        main_link = 12;
        return 12;
    }
    public static bool lins()
    {
        return 1 > 0;
    }
    public static void condit(string s, string s2, int i)
    {
        Console.WriteLine(s);
        Console.WriteLine(s2);
        Console.WriteLine(i);
    }

}