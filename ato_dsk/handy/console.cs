using System;
using System.Collections.Generic;
using System.Diagnostics;

using System.Text;
using System.Threading;


public class console
{
    public static readonly string WorkFolder = string.Empty;
    static console()
    {
        WorkFolder = string.IsNullOrEmpty(WorkFolder) ? Environment.CurrentDirectory : WorkFolder;
    }
    public static string Run(string input, string args)
    {

        Process process = new Process();
        process.StartInfo.FileName = "cmd.exe";  //设置要启动的应用程序
        process.StartInfo.Arguments = args;
        process.StartInfo.UseShellExecute = false;  //是否使用操作系统shell启动
        process.StartInfo.RedirectStandardInput = true;  // 接受来自调用程序的输入信息
        process.StartInfo.RedirectStandardOutput = true;  //输出信息
        process.StartInfo.RedirectStandardError = true;  // 输出错误
        process.StartInfo.CreateNoWindow = true;  //不显示程序窗口
        process.Start();  //启动程序

        process.StandardInput.WriteLine(input + "&exit");  //向cmd窗口发送输入信息，如果批处理，需要这里做循环输入
        process.StandardInput.AutoFlush = true;

        string output = process.StandardOutput.ReadToEnd();  //获取输出信息
        //     p.WaitForExit(60 * 1000);  //等待程序执行完退出进程，cmd.exe超时时间
        process.Close();

        return output;
    }

    //Snatches FileWatcher
    public static string batch(string fileName, string args)
    {
        var process = new Process();
        process.StartInfo.WorkingDirectory = WorkFolder;
        process.StartInfo.FileName = WorkFolder + "\\" + fileName;
        process.StartInfo.Arguments = args;// string.Format("10");//this is argument
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.RedirectStandardInput = true;  // 接受来自调用程序的输入信息
        process.StartInfo.RedirectStandardOutput = true;  //输出信息
        process.StartInfo.RedirectStandardError = true;  // 输出错误
        process.StartInfo.UseShellExecute = false;       //是否使用操作系统shell启动                 

        //      process.StandardInput.WriteLine(args + "&exit");  //向cmd窗口发送输入信息，如果批处理，需要这里做循环输入
        //       process.StandardInput.AutoFlush = true;
        //System.Threading.ThreadPool.i
        //  var thread = new System.Threading.Thread( new System.Threading.ThreadStart(process.Start)); 
        process.Start();
        //process.WaitForExit();
        //ThreadPool.QueueUserWorkItem(new WaitCallback(t =>
        //{

        //}));


        string output = String.Empty;
        try
        {
            output = process.StandardOutput.ReadToEnd();  //获取输出信息
        }
        catch
        {
            process.ErrorDataReceived += delegate(object sender, DataReceivedEventArgs e)
            {
                output = e.Data;
            };
        }
        finally
        {

            process.WaitForExit();
        }

        return output;
    }
}