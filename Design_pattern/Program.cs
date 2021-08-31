using System;
using System.Threading.Tasks;

namespace Design_pattern
{
//    We have changed the class to restrict external instantiation by changing the public constructor to private and then we provided a public property to access this class
//We have proved that adding Private constructor will prevent us instantiating a new class
//We have further sealed down this class to avoid any inheritance

//You might be wondering why we need to seal the class when a private constructor is present.

//Let’s first remove the sealed keyword and check that.Let’s create another class called DerivedSingleton and Inherit the singleton class. Let's compile the code and look at that it has thrown an error saying Singleton is inaccessible due to its protection level. This error is because of private constructor.
 
//Now you might be thinking that when a private constructor is restricting the inheritance then why we need to apply sealed keyword to the class. 
//SO LOOKS LIKE SEALEAD KEYWORD AND PRIVATE CONS. DOING SAME JOB
 
//Let’s just move this new class inside the Singleton class. By moving this class inside the Singleton class it has now become nested or child class of the main singleton class

    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
           () => Employee(),
            () => Student()
            //() => Derived()
            );

            Console.ReadLine();


        }

        private static void Derived()
        {
            Singleton.DerivedSingleton derivedObj = new Singleton.DerivedSingleton();
            derivedObj.PrintDetails("From Derived");
        }

        private static void Student()
        {
            /*
             * Assuming Singleton is created from student class
             * we refer to the GetInstance property from the Singleton class
             */
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }

        private static void Employee()
        {
            /*
             * Assuming Singleton is created from employee class
            * we refer to the GetInstance property from the Singleton class
            */
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }
    }
}
