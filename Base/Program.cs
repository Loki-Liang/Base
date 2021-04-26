using System;
using System.Collections;
using System.Dynamic;
using System.Threading;


namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string i = null;
            DoSomthing(out i);
            Console.WriteLine(i);
        }
        #region out 参数
        static void DoSomthing(out string parm)
        {
            parm="已修改";
        }
         

        #endregion
    }
}
