using System;
using System.Collections.Generic;

using System.Text;

using System.IO;
namespace AngelLayout
{
    /*
    Shape//Matrix:AntiBeauty on earth FusionUgly out space 
    Rotate square
    Rect Circle,Trangle, 
    Arc 
    Side //	side; section; edge; margin;
    Angle
     * ket.a ket.b
     * ket.[ ket.]
     * ket.$ ket:出
     */
    public class Kesai
    {
        public char[] kets;
    }
    public class Symbol
    {
        //character letter type(cannot be tolled apart on operation system)
        //kesai is a new definiation for classifying
        public int Kesai;
        public string Text;
        public string[] Line;
        public string[] Pine;
        //public string[] Columns;
        public string Name { get; set; } 
    }
    public class SymbolResult
    {
        public int Type;
        public StringBuilder Scalars { get; set; } 
    }
    public static class SolidUntil
    {
        //private string symbols = string.Empty;
       
        public static SymbolResult GetSymbols(Symbol symbol)
        {
            var result = new SymbolResult();
            //<text>
            //<tspan x = "0" y = "45" > 字 </ tspan >
            //<tspan x = "15" y = "45" > 这 </ tspan >
            //<tspan x = "30" y = "45" > 个 </ tspan >
            //<tspan x = "45" y = "45" > 字 </ tspan >
            //<tspan x = "60" y = "45" > 这 </ tspan >
            //<tspan x = "75" y = "45" > 个 </ tspan >
            //</ text >
            int x = 0;
            int y = 45;
                result.Scalars.AppendLine("<text>");
            foreach (var c in symbol.Name.ToCharArray())
            {
                result.Scalars.AppendFormat("<tspan x=\"{0}\" y=\"{1}\">{2}</tspan>",x+=15,y,c);
             
            }   result.Scalars.AppendLine("</text>");
          //  result.Values = symbol.Value.Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            return result;
        }
    }
}
