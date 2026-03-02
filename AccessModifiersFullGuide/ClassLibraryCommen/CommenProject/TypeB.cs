using System;
using System.Collections.Generic;
using System.Text;

namespace CommenProject
{
    internal class TypeB
    {
        public TypeB()
        {
            TypeA typeA = new TypeA();
            //typeA.x = 1;//invali can't access private
            typeA.y = 1;  //y is Internal
            typeA.z = 4;  //z is public
        }
    }
}
