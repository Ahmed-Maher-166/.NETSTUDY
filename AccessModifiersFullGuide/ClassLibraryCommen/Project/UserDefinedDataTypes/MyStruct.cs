using System;
using System.Collections.Generic;
using System.Text;

namespace Project.UserDefinedDataTypes
{
    internal struct MyStruct
    {
        public MyStruct()
        {
            
        }
        ///what we can write inside Class
        ///1. Attibutes Variables
        int myAttribute = 4;
        ///2. Functions (Contructor ,Getter setters ,Method 
         void MyFunction()
        {
            Console.WriteLine(myAttribute);
        }
        ///3. Properties[Full Property , Automatic Prperty ,Indexer]
        public int property
        {
            get { return myAttribute; }
            set { myAttribute = 33; }
        }
        ///4. Events
        ///Access Mdifier Allowed inside Struct
        ///Private
        ///Public
        ///Internal
    }
}

