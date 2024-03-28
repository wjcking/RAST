using System.Collections.Generic;
 

namespace Asnic
{
    /// <summary>
    /// 混编基础
    /// </summary>
    public class Hex
    {
        public static IDictionary<ushort, Symbol> GetSymbols()
        {
            //40(左括号（left Parenthesis）	left parenthesis
            //41)   右括号（right Parenthesis）	right parenthesis
            //91[左方括号（left SquareBracket）	left square bracket

            //93]   右方括号（right SquareBracket）	right square bracket

            IDictionary<ushort, Symbol> dict = new Dictionary<ushort, Symbol>();

            //dict.Add(1, new Symbol(Constant.BracketLeft, SymbolType.Bracket,0));
            //dict.Add(2, new Symbol(Constant.BracketRight, SymbolType.Bracket, 0));
            //dict.Add(3, new Symbol(Constant.ParentLeft, SymbolType.Bracket,0));
            //dict.Add(4, new Symbol(Constant.ParentRight, SymbolType.Bracket, 0));

            return dict;

        }
        public static string Act(string text)
        {
            //Heller.Age:老人 常用 筛选 到 规矩
            //习惯
            //自定义分隔符优先 链接符 括号
            var symbols = Hex.GetSymbols();

            //k(end.On Saturda(y mor[ni(ng, I) played the pian]o and learned English.Saturday after
            var clone = text.Clone().ToString();

            int start = 0;
            int end = 0;

            //start = clone.IndexOf(symbols[3].Value) + 1;
            //clone = clone.Substring(start);
            //end = clone.LastIndexOf(symbols[4].Value);
            //clone = clone.Substring(0, end);

            return clone;
        }

    }
}
