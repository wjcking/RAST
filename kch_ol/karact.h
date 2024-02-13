 #include <tchar.h>
const char
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
 const char 
    //转义序列
    eslt = '\n',  //换行(LF) ，010 
    esnt = '\r',  //回车(CR) ，将当前位置移到本行开头 013
    estb = '\t',       //水平制表(HT)  009
    esds = '\\',  //代表一个反斜线字符''\'   092
    essq = '\'',  //代表一个单引号（撇号）字符 039
    esqo = '\"',  //代表一个双引号字符 034 
    esno = '\0'; //空字符(NUL) 000