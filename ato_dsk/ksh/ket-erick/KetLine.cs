using System.Collections.Generic;
using System.Text;

namespace Asnic
{
    /// <summary>
    ///now is from the left, mind the reverse from bottom
    /// </summary>
    public class KetLine
    {
        private bool isSpaced = false;
        /// <summary>
        ///一行一个\r就相当于一行空格 美观
        /// </summary>
        // private bool isEmptyLine = false;
        private ushort spaceLength = 0;

        public IList<Ket> KetChars { get; set; }
        public ushort SpaceLength
        {
            get
            {
                return spaceLength;
            }
            set
            {
                if (isSpaced)
                    return;

                else if (value == Constant.AsciiSpace)
                    spaceLength++;
                else
                    isSpaced = true;
            }
        }

        public override string ToString()
        {
            var list = new StringBuilder();
            //     list.Append("L:").Append(Left);
            //  list.Append("E:").Append(End);

            return list.ToString();
        }
    }
}
