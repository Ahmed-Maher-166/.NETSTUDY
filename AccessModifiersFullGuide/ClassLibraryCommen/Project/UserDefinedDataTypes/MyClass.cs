using System;
using System.Collections.Generic;
using System.Text;

namespace Project.UserDefinedDataTypes
{
    ///what we can write inside Namespace
    ///1. Class
    ///2. Struct
    ///3. Interface
    ///4. Enum
    

    ///Access Modifiers ===> Protection Level allowed inside NameSpace
    ///1. Internal (Default)
    ///2. Public

    public class MyClass
    {
        ///what we can write inside Class
        ///1. Attibutes Variables
        int myAttribute = 4;
        ///2. Functions (Contructor ,Getter setters ,Method 
       internal void MyFunction()
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
        ///

        ///Allowed Access Modifier inside Class
        ///Private
        ///Private Protected
        ///Protected
        ///internal
        ///internal Protected
        ///public
    }
}
