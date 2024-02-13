using System;

namespace Asnic.ICommand
{
    
    /// <summary>
    ///命令抽象类 
    /// </summary>
    public abstract class Command
    {
        // 命令应该知道接收者是谁，所以有Receiver这个成员变量
        //protected Receiver receiver;

        //public Command(Receiver receiver)
        //{
        //    this.receiver = receiver;
        //}
        public Command()
        {

        }
        // 命令执行方法
        public abstract void Action();
    }
    ////命令发起者，负责调用命令对象执行请求
    //public class Invoke
    //{
    //    public Command command;

    //    public Invoke(Command command)
    //    {
    //        this.command = command;
    //    }

    //    public void ExecuteCommand()
    //    {
    //        command.Action();
    //    }
    //}

    ////命令接收者
    //public class Receiver
    //{
    //    public void Action()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
  
}
