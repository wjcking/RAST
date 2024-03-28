<%@ WebHandler Language="C#" Class="Set" %>

using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Beautiful;
using PoweredSource;
using Business;
using System.Text;
public class Set : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        //var json = Contexts.Contexts.GetJson(context);

        //var result = Handlers.Set(json);
        //context.Response.Write(result);

    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}