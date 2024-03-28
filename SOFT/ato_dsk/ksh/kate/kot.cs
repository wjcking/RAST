using System;
using System.Collections.Generic;



public class kot
{

    //  //宽度 length
    public int asc { get { return (int)value; } }
    public byte bit { get { return (byte)value; } }
    public string hex { get { return ((byte)asc).tostring("x"); } }
    public string bin { get { return convert.tostring(((byte)ascii), 2); } }
    // 5 = the max of chinese byte
    public int maxlen { get { return 5 - asc.tostring().length; } }
    public kot this[int index]
    {
        get { return this.number == index ? this : new kot() { number = -1 }; }
    }
}

