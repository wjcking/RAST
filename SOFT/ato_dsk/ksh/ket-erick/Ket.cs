using System;

namespace Asnic
{
    /// <summary>
    /// 当前人类认知键盘书写 语言 文字 看作是符号 Char
    /// 对于地球上的人来说是实体圆
    /// </summary>
    public class Ket 
    {
        //唯一index
        public int Number { get; set; }
        public char Value { get; set; }
        public string Desc { get; set; }
        //宽度 length
        public int Ascii { get { return (int)Value; } }
        public byte Byte { get { return (byte)Value; } }
        public string Hex { get { return ((byte)Ascii).ToString("x"); } }
        public string Binary { get { return Convert.ToString(((byte)Ascii), 2); } }
        /// <summary>
        /// 5 = the max of chinese byte
        /// </summary>
        public int VolumnLeft { get { return 5 - Ascii.ToString().Length; } }
        public Ket this[int index]
        {
            get { return this.Number == index ? this : new Ket() { Number = -1 }; }
        }
    }
}
