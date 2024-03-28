using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

/*
 * 静态 数组结构
 */
[TestClass]
public class erick
{
    private string[] s1, s2, s3, s4;
    private short[,] entrikes = new short[255, 255]; //lineMax,rowMax
    /*
     * ushort:65535,short:有负数
     * parameter as carow
     */
    public int factorial(string array, short size = 0)
    {
        if (size > array.Length - 1 || size > 255)
            return size;

        var c = array[size];
      //  Console.Write(size.ToString() + "-" + c.ToString() + " ");
        Console.Write(c.ToString());
        size += 1;
        return factorial(array, size);
    }

    [TestMethod]
    public void entrike()
    {
       // var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\AutoDesk\\analytical\\";
        var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Analytical\\absock-cybert\\";

        s1 =   File.ReadAllLines(path + "eunix-euclid.html", Encoding.Default);
        int endix = 0;
        //补0,下标从1开始,
       // s1[endix] = s1[endix].Insert(0, String.Empty);
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();

        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();
        factorial(s1[endix++]); Console.WriteLine();

      //  char[] a ="asdf fdasd asdfwew".ToCharArray();
    }

}
