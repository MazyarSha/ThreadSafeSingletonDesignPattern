using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingletonDesignPattern
{
    public class ThreadSafeSingleton
    {
        private static int Counter = 0;
        private static ThreadSafeSingleton instance = null;
        private static readonly object Instancelock = new object();
        public static ThreadSafeSingleton GetInstance()
        {
            if (instance == null)
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                }
            }
            return instance;
        }
        private ThreadSafeSingleton()
        {
            //Counter++;
            Console.WriteLine("ThreadSafeSingleton Counter: " + (++Counter).ToString() + " hashCode :" + GetHashCode());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message + Counter.ToString() + " hashCode :" + GetHashCode());

        }
    }
}
