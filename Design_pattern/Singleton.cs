﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Design_pattern
{
     //* Sealed ensures the class being inherited and
     //* object instantiation is restricted in the derived class
     //*/
    public  class Singleton
    {
        private static int counter = 0;
        private static readonly object obj = new object();

        /*
         * Private property initilized with null
         * ensures that only one instance of the object is created
         * based on the null condition
         */
        private static Singleton instance = null;

        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    //How to implement a Thread Safe singleton class : Locks are the 
                    //best way to control thread race condition and they help us to overcome the present situation
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;

            }
        }
        /*
         * Private constructor ensures that object is not
         * instantiated other than with in the class itself
         * And it wont allow us to inherit the class          
         */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Object created " + counter.ToString()+" Time");
        }
        /*
         * Public method which can be invoked through the singleton instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        public class DerivedSingleton : Singleton
        {

        }



    }
}
