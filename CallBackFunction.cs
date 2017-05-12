using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace CallBackFunction
 {
    public delegate void TaskCompletedCallBack(string taskResult);
    public class CallBackFunction
    {

        public void StartNewTask(TaskCompletedCallBack taskCompletedCallBack)
        {
            Console.WriteLine("I have started new Task.");
            if (taskCompletedCallBack != null)
                taskCompletedCallBack("I have completed Task.");
        }
        static void Main(string[] args)
        {

            CallBackTest callBackTest = new CallBackTest();
            callBackTest.Test();
            Console.ReadLine();
        }
    }
}
