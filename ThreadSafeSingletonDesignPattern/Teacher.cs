using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingletonDesignPattern
{
    public class Teacher
    {
        public void PrintTeacherFromDetails()
        {
            NonSingletonClass fromTeacher = new NonSingletonClass();
            fromTeacher.PrintDetail("teacher");
        }

        public void PrintTeacherFromDetailsSingleton()
        {
            Singleton fromTeacher = Singleton.GetInstance();
            fromTeacher.PrintDetails("Singleton teacher");
        }
        public void PrintTeacherFromDetailsThreadSafesingleton()
        {
            ThreadSafeSingleton fromTeacher = ThreadSafeSingleton.GetInstance();
            fromTeacher.PrintDetails("ThreadSafeSingleton teacher");
        }
    }
}
