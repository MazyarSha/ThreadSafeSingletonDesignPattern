using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingletonDesignPattern
{
    public  sealed class Singleton
    {
        private static int Counter = 0;
        private static Singleton instance = null;

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        private Singleton()
        {
            //Counter++;
            Console.WriteLine("Singleton Counter: " + (++Counter).ToString() + " hashCode :" + GetHashCode());
        }
        public void PrintDetails(string message) 
        {
            Console.WriteLine(message + Counter.ToString() + " hashCode :" + GetHashCode());

        }
    }
}
