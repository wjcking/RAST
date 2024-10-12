using System;
using System.Text;

struct cybert
{
    public const char
    zeo = '0',
    one = '1', two = '2', thr = '3',
    fou = '4', fiv = '5', six = '6',
    sev = '7', eht = '8', nin = '9',

    csa = 'a', csb = 'b', csc = 'c', csd = 'd',
    cse = 'e', csf = 'f', csg = 'g', csh = 'h',
    csi = 'i', csj = 'j', csk = 'k', csl = 'l',
    csm = 'm', csn = 'n', cso = 'o', csp = 'p',
    csq = 'q', csr = 'r', css = 's', cst = 't',
    csu = 'u', csv = 'v', csw = 'w', csx = 'x',
    csy = 'y', csz = 'z',

    cba = 'A', cbb = 'B', cbc = 'C', cbd = 'D',
    cbe = 'E', cbf = 'F', cbg = 'G', cbh = 'H',
    cbi = 'I', cbj = 'J', cbk = 'K', cbl = 'L',
    cbm = 'M', cbn = 'N', cbo = 'O', cbp = 'P',
    cbq = 'Q', cbr = 'R', cbs = 'S', cbt = 'T',
    cbu = 'U', cbv = 'V', cbw = 'W', cbx = 'X',
    cby = 'Y', cbz = 'Z',
        //Connector cot  separator sot
    cnt = '-',
    cnr = '~',
    ace = ' ', con = ':',
    cma = ',', com = ',',
    duo = '.', dsh = '/',
    spt = '|',

    lsm = '(', lmd = '[', lbr = '{', lkt = '<',
    rsm = ')', rmd = ']', rbr = '}', rkt = '>', qos = '`',
        //计算机运算符号和现实纸张相符的只有+
    cpp = '+',

    alm = '!', per = '%',
    cxp = '#', and = '&',
    dor = '$',

    sdr = '*',
    eqt = '=',
    qst = '?',
    atr = '@',
    dsa = '\\',
    art = '^',
    udr = '_';
    public const char 
    //转义序列
    estab = '\t',
   esent = '\n',  //换行(LF) ，010 
   esrnt = '\r',  //回车(CR) ，将当前位置移到本行开头 013
    esds = '\\',  //代表一个反斜线字符''\'   092
    essq = '\'',  //代表一个单引号（撇号）字符 039
    esqo = '\"',  //代表一个双引号字符 034 
    esno = '\0'; //空字符(NUL) 000

    //public ushort
    //pixel_width = 2880,
    //pixel_height = 1920,
    //font_size = 16;
    //public ushort
    //screen_width = 2880 / 16,
    //screen_height = 1920 / 16;
    public string orginal { get; set; }
    public const ushort   font_size = 26;
    public string each_eidix()
    {

        StringBuilder ranket = new StringBuilder();
        for (int i = 0; i < orginal.Length; i++)
        {

            ranket.Append((i + 1).ToString().PadLeft(5, zeo));
            ranket.Append(cnr);
            switch (orginal[i])
            {
                case esrnt: ranket.Append("\\r"); break;
                case esent: ranket.Append("\\n"); ranket.Append(Environment.NewLine); break;
                default: ranket.Append(orginal[i]); break;
            }

            ranket.Append(ace);
        }
        return ranket.ToString();
    }

    public string each_ranket()
    {
        ushort
            font_size = 26;
        //  ushort
        //screen_width = 2880 /  76 ,
        //screen_height = 1920 / 76 ;
        StringBuilder ranket = new StringBuilder();
        for (int i = 0; i < orginal.Length; i++)
        {
            ranket.Append(orginal[i]);
            ranket.Append(ace);
            string enter = (i + 1) % font_size == 0 ? (esrnt.ToString() + esent.ToString()) : string.Empty;
            ranket.Append(enter);
        }
        return ranket.ToString();
    }
    ////  public int asc { get { return (int)value; } }


    ////   string bin { get { return convert.tostring(((byte)ascii), 2); } }
    //  // 5 = the max of chinese byte
    //  int  maxlen { get { return 5 - asc.ToString().Length; } }

    public string each_hexet()
    {
        //Encoding.Unicode.GetBytes("啊")
        //{byte[2]}
        //    [0]: 74
        //    [1]: 85
        //Encoding.Unicode.GetBytes("د")
        //{byte[2]}
        //    [0]: 47
        //    [1]: 6
        StringBuilder ranket = new StringBuilder();
        for (int i = 0; i < orginal.Length; i++)
        {
            //ranket.AppendFormat("{0:x}", (byte[])orginal[i]);
            ranket.AppendFormat("{0:x}", (byte)orginal[i]);
            ranket.Append(ace);
            string enter = (i + 1) % font_size == 0 ? (esrnt.ToString() + esent.ToString()) : string.Empty;
            ranket.Append(enter);
        }
        return ranket.ToString();
    }
    //0 1010100 yirtgh
    //1 0110101 houeor 
    public string hex_chs(string character)
    {
        string coding = "";

        for (int i = 0; i < character.Length; i++)
        {
            byte[] bytes = System.Text.Encoding.Unicode.GetBytes(character.Substring(i, 1));

            //取出二进制编码内容 
            string lowCode = System.Convert.ToString(bytes[0], 16);

            //取出低字节编码内容（两位16进制） 
            if (lowCode.Length == 1)
            {
                lowCode = "0" + lowCode;
            }

            string hightCode = System.Convert.ToString(bytes[1], 16);

            //取出高字节编码内容（两位16进制） 
            if (hightCode.Length == 1)
            {
                hightCode = "0" + hightCode;
            }

            coding += (hightCode + lowCode);

        }

        return coding;
    }
}
