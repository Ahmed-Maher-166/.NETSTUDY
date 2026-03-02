using System;
using System.Collections.Generic;
using System.Text;

namespace Project.UserDefinedDataTypes
{
    internal interface IMyInterface
    {

        //Simula
        //Smalltalk
        //C# java Python

        ///what we can write inside Interface
        ///Signature
        public int MyProperty {  get; set; }

        ///2. Signature function
        internal void Myfunction();

        private void Myfunction2()
        {
            Console.WriteLine(MyProperty);
        }
    }


  
}
