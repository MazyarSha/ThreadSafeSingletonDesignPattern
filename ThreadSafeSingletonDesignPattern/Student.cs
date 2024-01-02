using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingletonDesignPattern
{
    public class Student
    {
        public void PrintStudentFromDetails()
        {
            NonSingletonClass fromStudent = new NonSingletonClass();
            fromStudent.PrintDetail("student");
        }

        public void PrintStudentFromDetailsSingleton()
        {
            Singleton fromStudent = Singleton.GetInstance();
            fromStudent.PrintDetails("Singleton student");
        }
        public void PrintStudentFromDetailsThreadSafesingleton()
        {
            ThreadSafeSingleton fromStudent = ThreadSafeSingleton.GetInstance();
            fromStudent.PrintDetails("ThreadSafeSingleton student");
        }
    }
}
