using System;
using System.Collections.Generic;
using System.Text;

struct rotate
{
   
    //static rotate()
    //{
    
    //}
    static int counter = 0;
    public Int16 rec(object i )
    {
        Console.Write(counter.ToString());
        System.Threading.Thread.Sleep(Convert.ToInt32(i));
       // counter++;
        return rec(i);
    }

    public void rew()
    {
        while (true)
        {
        Console.WriteLine(counter.ToString());
        System.Threading.Thread.Sleep(1);
            counter++;
          //  rew();
        }
    }
    public void wile(func<bool> kondet, action<string, string, int> kondetBody)
   {  

       while(kondet())
       {
           System.Threading.Thread.Sleep(110);
          kondetBody("s1","s2",13443);
       }
   }

   
}
struct loop
{
    public int length  ;//{ get; set; }
    public int counter;//{get;set  ;  }
    //public loop()
    //{             
    //    length = 10;

    //    counter = 0;
    //}

    public void four(action<string> kondet)
    {
        for (int i = counter; i < length; i++)
        {
            System.Threading.Thread.Sleep(10);
            kondet(i.ToString());

        }
    }
}