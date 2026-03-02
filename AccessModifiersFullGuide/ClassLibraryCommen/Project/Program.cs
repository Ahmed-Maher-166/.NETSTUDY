using ClassLibraryCommen;
using CommenProject;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
// https://chatgpt.com/share/69a4d4ca-95a8-8006-9135-48feac3a709c
            ///Use Class Library
            //Products p = new Products()
            //{
            //    Id = 1,
            //    Name = "Iphone",
            //    Description = "V Good",
            //    Price = 50000,
            //    Count=10
            //};


            #region USe Access Modifier [Private - internal - public]
           TypeA t1=new TypeA();
            t1.z = 1;/// Public acess modifier
            //can't access private or internal 
            #endregion

        }
    }
}
