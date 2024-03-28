using System;
using System.Collections.Generic;

using System.Text;
[ Flags ]  
enum  Styles {  
ShowBorder = 1,         //是否显示边框 
ShowCaption = 2,        //是否显示标题 
ShowToolbox = 4         //是否显示工具箱 
} 

//阿拉伯 刻画数字
namespace kit
{
    public enum En { Zr, On, To, Sr, Fo, Fv, Sx, Sv, Et, Ni, Tn }
    public enum Chs { Lin, Yi, Er, San, Si, Wu, Liu, Qi, Ba, Jiu }
    // public readonly static char Z = 'Z';
    //public   En { Zr, On, To, Sr, Fo, Fv,Sx, Sv, Et, Ni, Tn }
    //public   Chs {Lin, Yi,Er,San,Si,Wu,Liu,Qi,Ba,Jiu }

    //public enum  { }
}

//已经使用命名；并且人类戒指 Forbiden
namespace Ait
{
    //mouth month
    public enum Mos
    {
        Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
    }
    //week
    public enum Vac
    {
        Sun, Mon, Tue, Wed, Szd, Fri, Sat
    }
}
namespace AutoDesk
{
    using kit;

    /* not classified by human using numbers */
    namespace Day
    {

    }
    namespace Mid
    {

    }
    //second
    namespace Sec
    {

    }

}
