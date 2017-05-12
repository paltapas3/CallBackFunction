using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackFunction
{
    public class CallBackTest
    {
        public void Test()
        {
            TaskCompletedCallBack callback = TestCallBack;
            CallBackFunction testCallBack = new CallBackFunction();
            testCallBack.StartNewTask(callback);
        }
        public void TestCallBack(string result)
        {
            Console.WriteLine(result);
        }
    }
}
