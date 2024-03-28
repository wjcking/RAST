using System;
using System.Collections.Generic;


using System.Text;


namespace Asnic
{
    /// <summary>
    /// 认知的：键盘 三大语系
    /// Principe
    ///     文字和宗教符号 
    ///     文字和党派
    ///     文字直接叫混合
    ///Symbol可以看作是ket的一个虚圆囊括
    /// </summary>
    public class Symbol
    {
        public Ket Ket;
        public Axis Axis;
        public Metric Metric;
        public SymbolMetric SymbolMetric;
        public SideKorner SideKorner;
        public EarthMatical EarthMatical;

        //   public bool IsMatched = false;
        //    public int Number = 0;
        /// <summary>
        ///         
        /// Direct  top 
        ///    v t: rlrlrllrlrlrl
        ///    h b: lrlrrrllrlrlr 
        ///         bottom
        /// bracket ( ) []
        /// </summary>
        public int Piroity;
        //public Symbol(char value, SymbolType type, int piroity)
        //{
        //    Value = value;
        //    SymbolType = type;
        //    Piroity = piroity;
        //}
    }

}
