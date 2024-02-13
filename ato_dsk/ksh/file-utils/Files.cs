
using System;
using Asnic;
using Asnic.FileCommand;
using Asnic.ICommand;

namespace Asnic
{
    public class Files
    {
        /// <summary>
        /// 项目文件夹Rastea、以后用户可自定义
        /// </summary>
        public static string StartPath
        {
            get
            {
                var pos = Environment.CurrentDirectory.IndexOf('\\');
                var disk = Environment.CurrentDirectory.Substring(0, pos);
                var startPath = disk + "\\VSProjects\\AngelWolf\\Rastera\\";
                return startPath + "filtered\\";
            }
        }

        /// <summary>
        /// 增删改 
        /// list 
        /// 查
        /// Asnical.Symbol.RemoveFirst
        /// </summary>
        /// <param name="commandLine"></param>
        public static void Execute(string commandLine)
        {
            bool isVerified = false;
            //如果没有空格泽不执行命令
            isVerified = !string.IsNullOrEmpty(commandLine) && commandLine.IndexOf(Constant.Space) > -1;

            if (!isVerified)
                throw new Exception("No file command,should be: New Delete Move ListFiles ");
            var result = Get(commandLine);
            result.Action();

            //html or other like:jpg mp4 
            var dashed = commandLine.LastIndexOf(Constant.Dashed) > -1;

            var splited = commandLine.Split(Constant.Space);
            var cmd = splited[0];
            var dotted = commandLine.Split(Constant.Dot);
        }

        //public static string[] GetBrackets(this string value)
        //{
            
        //}

        private static Command Get(string name)
        {
            Command[] list = new Command[5]
               {
                   new New(),
                       new Delete(),
                       new Move(),
                       new Rename(),
                       new ListFiles()
               };
            var className = string.Empty;
            name = name.ToUpper();
            foreach (var c in list)
            {
                className = c.GetType().Name.ToUpper();
                if (className == name || className[0] == name[0])
                    return c;
            }
            return new Unknown();
        }
    }
}
