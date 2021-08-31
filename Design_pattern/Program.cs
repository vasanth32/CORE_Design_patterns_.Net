using System;

namespace Design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    * Assuming Singleton is created from employee class
    * we refer to the GetInstance property from the Singleton class
    */
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
            /*
             * Assuming Singleton is created from student class
             * we refer to the GetInstance property from the Singleton class
             */
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");

            Console.ReadLine();

        }
    }
}
