<%@ WebHandler Language="C#" Class="Layout" %>

using System;
using System.Web;
using Beautiful;
using PoweredSource;
    using System.Diagnostics;
    using System.IO;
public class Layout : IHttpHandler {

    public void ProcessRequest (HttpContext context)
    {
         Process p = new Process();
              string path = System.Web.HttpContext.Current.Server.MapPath("../Artlisense.py"); ;
              string sArguments = path;
              p.StartInfo.FileName = @"python.exe"; 
              p.StartInfo.Arguments = sArguments;//python命令的参数
              p.StartInfo.UseShellExecute = false;
              p.StartInfo.RedirectStandardOutput = true;
              p.StartInfo.RedirectStandardInput = true;
              p.StartInfo.RedirectStandardError = true;
              p.StartInfo.CreateNoWindow = true;
              p.Start();
    }

          
    public bool IsReusable {
        get {
            return false;
        }
    }

}