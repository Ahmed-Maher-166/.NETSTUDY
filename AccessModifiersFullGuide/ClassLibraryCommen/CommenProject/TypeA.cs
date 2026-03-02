using System;
using System.Collections.Generic;
using System.Text;

namespace CommenProject
{
    public class TypeA
    {
       private int x;
        internal int y;
        public int z;


        //1) Access within same Class
        public TypeA()
        {
            x = 1; //private : [Accessible within same Class]
            y = 2; //internal : [Accessible within same Class]
            z = 3; //public : [Accessible within same Class]
        }
    }
}
