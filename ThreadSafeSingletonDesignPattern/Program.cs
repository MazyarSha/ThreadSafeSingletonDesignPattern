// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using ThreadSafeSingletonDesignPattern;


Teacher teacher = new Teacher();
Student student = new Student();




//non singleton
Thread teacherThread = new Thread(teacher.PrintTeacherFromDetails);
Thread studentThread = new Thread(student.PrintStudentFromDetails);

teacherThread.Start();
studentThread.Start();



//singleton
Thread teacherSingletonThread = new Thread(teacher.PrintTeacherFromDetailsSingleton);
Thread studentSingletonThread = new Thread(student.PrintStudentFromDetailsSingleton);
Thread teacherSingletonThread1 = new Thread(teacher.PrintTeacherFromDetailsSingleton);
Thread studentSingletonThread1 = new Thread(student.PrintStudentFromDetailsSingleton);

teacherSingletonThread.Start();
studentSingletonThread.Start();
teacherSingletonThread1.Start();
studentSingletonThread1.Start();

//ThreadSafesingleton
Thread teacherThreadSafesingletonThread = new Thread(teacher.PrintTeacherFromDetailsThreadSafesingleton);
Thread studentThreadSafesingletonThread = new Thread(student.PrintStudentFromDetailsThreadSafesingleton);
Thread teacherThreadSafesingletonThread1 = new Thread(teacher.PrintTeacherFromDetailsThreadSafesingleton);
Thread studentThreadSafesingletonThread1 = new Thread(student.PrintStudentFromDetailsThreadSafesingleton);

teacherThreadSafesingletonThread.Start();
studentThreadSafesingletonThread.Start();
teacherThreadSafesingletonThread1.Start();
studentThreadSafesingletonThread1.Start();

