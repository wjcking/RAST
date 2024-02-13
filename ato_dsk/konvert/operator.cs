using System;
using System.Collections.Generic;
using System.Text;

/* ?:：条件运算符
 * 寄存器 硬件关联 reglitor
下面是可重载的运算符列表：
    双目算术运算符	+ (加)，-(减)，*(乘)，/(除)，% (取模)
    关系运算符	==(等于)，!= (不等于)，< (小于)，> (大于)，<=(小于等于)，>=(大于等于)
    逻辑运算符	||(逻辑或)，&&(逻辑与)，!(逻辑非)
    单目运算符	+ (正)，-(负)，*(指针)，&(取地址)
    自增自减运算符	++(自增)，--(自减)
    位运算符	| (按位或)，& (按位与)，~(按位取反)，^(按位异或),，<< (左移)，>>(右移)
    赋值运算符	=, +=, -=, *=, /= , % = , &=, |=, ^=, <<=, >>=
    空间申请与释放	new, delete, new[ ] , delete[]
    其他运算符	()(函数调用)，->(成员访问)，,(逗号)，[](下标)
下面是不可重载的运算符列表：
    .：成员访问运算符
    .*, ->*：成员指针访问运算符
    ::：域运算符
    sizeof：长度运算符
   
    #： 预处理符号
*/
public class reglitor
{
    public int numberic { get; set; }
     
    /*
     * operator 用于重载运算符
     */
    // 重载运算符"+"
    public static int operator +(reglitor m1, reglitor m2)
    {
        return m1.numberic + m2.numberic;
    }
 

    /*
     * operator 用于自定义类型转换
     */
    // 定义隐式的从reglitor到int的类型转换
    public static implicit operator int(reglitor m1)
    {
        return m1.numberic;
    }
    // 定义显式的从reglitor到string的类型转换
    //public static explicit operator string(reglitor m1)
    //{
    //    return m1.numberic;
    //}

}