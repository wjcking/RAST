using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

[TestClass]
public class files
{
    /*
     * 下标从1开始
     */
    public static string[] read_files(string path, Encoding encode)
    {
        //const string
        //    enbreak_retend = "\r\n",
        //    dashed_indent = "\t";
        //enbreak_returned = "\r", 
        //enbreak_entered = "\n"; 
        //Open the stream and read it back.
        //using (FileStream fs = File.OpenRead(path))
        //{
        //    byte[] b = new byte[1024];
        //    UTF8Encoding temp = new UTF8Encoding(true);
        //    while (fs.Read(b, 0, b.Length) > 0)
        //    {
        //        Console.WriteLine(temp.GetString(b));
        //    }
        //}

        // var text1 = File.ReadAllText(path, encode);


        //补0,下标从1开始,
        //string[] results = text1.Split(enbreak_retend.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        return null;
    }
    [TestMethod]
    public void read()
    {
        var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\NunitTest\\TextFile1.txt";

        //Create the file.
        //using (FileStream fs = File.Create(path))
        using (FileStream fs = File.OpenWrite(path))
        {
            byte[] info = new UTF8Encoding(true).GetBytes("\r\n\r\nThe following is a subset of characters:\r\n");
            fs.Write(info, 0, info.Length);
            fs.Close();

            //(fs, Convert.ToChar(i).ToString());
        }
    }
}
