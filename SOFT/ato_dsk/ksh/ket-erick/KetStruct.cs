using System;
using System.Collections.Generic;
 

namespace Asnic
{
    ///<summary>
    ///top main bottom
    //At the end of organised the ket array, it will add top and bottom
    //Further discusstion:handle faimly kid metric
    /// </summary>
    public class KetStruct
    {
        //private static IDictionary<string, ushort> Indexes;
        private KetLine[] Ketlines = null;
        public KetStruct(int length)
        {
           Ketlines = new KetLine[length];
        }
        //  public RectCorner Corner { get; set; }
        /// <summary>
        /// Lines length for html text
        /// "5" the maximum volume Chinese Ascii 5 byte
        /// organize the format of pad or html table
        /// </summary>
        public int Length { get; set; }
        //main
        //int Index { get; set; } = 1;
        // int Lines { get; set; }
        int Columns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IList<KetLine> Function { get; set; }
    }
}