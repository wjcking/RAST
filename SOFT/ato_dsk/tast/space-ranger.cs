using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

using System.Diagnostics;

namespace UnitTest.AutoDesk
{
    //Leonsnic.Security;
    //Leonsnic.Runtime.ConstrainedExecution;
    //Leonsnic.Runtime.InteropServices;
    //Leonsnic.Runtime.Versioning;
    
    namespace Komb
    {
        //   类层次结构中的所有类，并为派生类提供低级别服务。所有类的最终基类；它是类型层次结构的根。
        //     若要浏览此类型的.NET Framework 源代码，请参阅Reference Source。
        //[ClassInterface(ClassInterfaceType.AutoDual)]
        //[ComVisible(true)]
        public class Function
        {
            //初始化 System.Object 类的新实例。
            //[NonVersionableAttribute]
           // [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
            public   Function(){}


            //在垃圾回收将某一对象回收前允许该对象尝试释放资源并执行其他清理操作。
            //[NonVersionableAttribute]
            //[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            ~Function(){}

            //     确定指定的[对象实例]是否被视为相等。
            //如果对象被视为相等，则为 true，否则为 false。 如果 objA 和 objB 均为 null，此方法将返回 true。
            //public static bool Equals(Object objA, Object objB){}

            /// <summary> 
            ///   true如果objA是相同的实例作为objB或如果两者均null{} 否则为false。
            /// <param name="objA">要比较的第一个对象</param>
            /// <param name="objB">要比较的第二个对象</param>
            /// <returns>确定指定的 System.Object [实例]是否是相同的[实例</returns> 
            /// </summary>
            //[NonVersionableAttribute]
           // [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            //public static bool ReferenceEquals(Object objA, Object objB) { }

            //public virtual bool Equals(Object obj) { }


            //public virtual int GetHashCode() { }

            //[SecuritySafeCritical]
            //public Type GetType() { }

            //public virtual string ToString() { }

            //[SecuritySafeCritical]
            //protected Object MemberwiseClone() { }

        }
    }
}