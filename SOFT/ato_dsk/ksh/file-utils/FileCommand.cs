using Asnic.ICommand;
using System;
using System.IO;

/// <summary>
///Directory.CreateDirectory
///Directory.Move
///Directory.Delete
///Directory.GetFiles 
//
///File.Exists
///File.Move
///File.Create
///File.Delete
/// </summary>
namespace Asnic.FileCommand
{
    /// <summary>
    /// 未知命令
    /// </summary>
    public class Unknown : Command
    {
        public override void Action()
        {
            Console.WriteLine("未知命令");
        }
    }
    /// <summary>
    /// 文件夹还有文件是否存在
    /// </summary>
    public class Exists : Command
    {
        //private Func<string, bool> isDirectoryExsits = Directory.Exists;
        //private Func<string, bool> isFileExsits = File.Exists;
        public override void Action()
        {
            Console.WriteLine("文件夹还有文件是否存在");
        }
    }

    /// <summary>
    /// 新建html文件
    /// </summary>
    public class New : Command
    {
        public override void Action()
        {
            Console.WriteLine("新建文件");
        }
    }

    /// <summary>
    /// 文件夹还有文件是否存在
    /// </summary>
    public class Delete : Command
    {
        public override void Action()
        {
            Console.WriteLine("删除文件");
        }
    }
    /// <summary>
    /// 文件夹还有文件是否存在
    /// </summary>
    public class Move : Command
    {
        public override void Action()
        {
            Console.WriteLine("移动文件");
        }
    }
    /// <summary>
    /// 重命名文件
    /// </summary>
    public class Rename : Command
    {
        public override void Action()
        {
            Console.WriteLine("重命名文件");
        }
    }
    /// <summary>
    /// 根据搜索内容或其他搜索 html content ?
    /// </summary>
    public class ListFiles : Command
    {
        public override void Action()
        {
            //Directory.GetFiles()
            //FileInfo fileInfo = new FileInfo("D:\\code\\test1.txt");
            Console.WriteLine("根据搜索内容或其他搜索");
        }
    }

}
