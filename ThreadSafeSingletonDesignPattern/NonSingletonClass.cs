using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingletonDesignPattern
{
    public class NonSingletonClass
    {
        private static int Counter = 0;

        public NonSingletonClass()
        {
            //Counter++;
            Console.WriteLine("NonSingletonClass Counter:" + Counter++ + " " + GetHashCode());
        }
        public void PrintDetail(string message)
        {
            Console.WriteLine(message + (++Counter).ToString() + " hashCode :" + GetHashCode());
        }
    }
}
