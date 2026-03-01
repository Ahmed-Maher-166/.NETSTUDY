namespace Casting_StringFormatiing_Converting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Floating Point Fractions
            //float myFloat = 9.123454999999984f;
            //Console.WriteLine(myFloat);

            //double myDouble = 10.215487454987;
            //Console.WriteLine(myDouble);

            //decimal myDecimal = 65.48646546548M;
            //Console.WriteLine(myDecimal.ToString($"{myDecimal:c}"));
            //Console.WriteLine(myDecimal);
            //Console.WriteLine($"{myDecimal:C}");
            //Console.WriteLine(myDecimal.ToString("C"));
            //var cultureInfo = new CultureInfo("ar-SA");
            //Console.OutputEncoding = System.Text.Encoding.UTF8;//for arabic Language
            //decimal number = 100000000000M;
            //Console.WriteLine(number.ToString("c", cultureInfo));
            #endregion
            #region Casting (Implicit casrting & Explicit Casting)
            ////Implicit cast
            //int ImplicitCasting = 10000;//4 byte
            //long SafeImplicit = ImplicitCasting;//8 byte 
            //Console.WriteLine(SafeImplicit);


            //long SafeEmplicit = 10000;
            ////int b = a;//invalid implicity 
            //int SafeEXmplicitSmaller = (int)SafeEmplicit;//Explicit Casting
            //Console.WriteLine(SafeEXmplicitSmaller);//10000



            //long UnSavedExplicitCasting = 100000000000000;
            ////int b = a;//invalid implicity 
            //int UnSavedExplicitCastingSmaller = (int)UnSavedExplicitCasting;//Explicit Casting
            //Console.WriteLine(UnSavedExplicitCastingSmaller);// 276447232  due to OverFlow

            ////checked
            ////{
            ////    long aaa = 100000000000000;
            ////    //int bbb = aaa;//invalid implicity 
            ////    int bbb = (int)aaa;//Explicit Casting
            ////    unchecked
            ////    {
            ////        Console.WriteLine(b);//OverflowException
            ////    }
            ////}

            ////Protective Code 
            //long ProtectiveCodeExample = 1286456;
            //if (ProtectiveCodeExample > int.MaxValue || ProtectiveCodeExample < int.MinValue)
            //    Console.WriteLine("Exception OverFlow Will happen");
            //else
            //{
            //    int M = (int)ProtectiveCodeExample;
            //    Console.WriteLine(M);
            //}

            ////?: Protective Code
            //object number = 12646846848348;
            //int val = number.GetType() == typeof(int) ? (int)number : 0;
            //Console.WriteLine(val);


            #endregion
            #region Explicit casting In-Compatible Types
            //object obj = "Hello";

            //try
            //{
            //    int n = (int)obj;       // Runtime InvalidCastException
            //    Console.WriteLine(n);
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine("Runtime error: " + ex.Message);
            //}
            #endregion
            #region Convert() - Parse() - TryParse()
            #region Convert() 
            //Console.WriteLine("Please Enter your Data");
            //Console.Write("Name : ");
            //string? name = Console.ReadLine();
            //Console.Write("Age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Salary : ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("========================");
            //Console.WriteLine("     Employee Data      ");
            //Console.WriteLine("========================");

            //Console.WriteLine($"Name is {name}\nAge is {Age}\nSalary is {salary}");
            #endregion
            #region Parse
            //Console.WriteLine("Please Enter your Data");
            //Console.Write("Name : ");
            //string? name = Console.ReadLine();
            //Console.Write("Age: ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.Write("Salary : ");
            //decimal salary = decimal.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("========================");
            //Console.WriteLine("     Employee Data      ");
            //Console.WriteLine("========================");

            //Console.WriteLine($"Name is {name}\nAge is {Age}\nSalary is {salary}");
            #endregion
            #region TryParse()
            //Console.WriteLine("Please Enter your Data");
            //Console.Write("Name : ");
            //string? name = Console.ReadLine();
            //Console.Write("Age: ");
            //bool IsParsed = int.TryParse(Console.ReadLine(), out int Age);
            //Console.WriteLine(IsParsed);

            //Console.Write("Salary : ");
            //decimal.TryParse(Console.ReadLine(), out decimal salary);


            //Console.Clear();
            //Console.WriteLine("========================");
            //Console.WriteLine("     Employee Data      ");
            //Console.WriteLine("========================");

            //Console.WriteLine($"Name is {name}\nAge is {Age}\nSalary is {salary}");
            #endregion
            #region Comprasion
            //Console.WriteLine("Comparison: Convert vs Parse vs TryParse");
            //Console.WriteLine(new string('-', 70));

            //Console.WriteLine(
            //    "{0,-22}|{1,-9}|{2,-9}|{3,-11}",
            //    "Feature", "Convert", "Parse", "TryParse");

            //Console.WriteLine(new string('-', 70));

            //Console.WriteLine(
            //    "{0,-22}|{1,-9}|{2,-9}|{3,-11}",
            //    "Throws Exception", "Yes", "Yes", "No");

            //Console.WriteLine(
            //    "{0,-22}|{1,-9}|{2,-9}|{3,-11}",
            //    "Handles null", "Yes (0)", "No", "Safe");

            //Console.WriteLine(
            //    "{0,-22}|{1,-9}|{2,-9}|{3,-11}",
            //    "Safe for user input", "No", "No", "Yes");

            //Console.WriteLine(
            //    "{0,-22}|{1,-9}|{2,-9}|{3,-11}",
            //    "Returns bool", "No", "No", "Yes");

            //Console.WriteLine(
            //    "{0,-22}|{1,-9}|{2,-9}|{3,-11}",
            //    "Best in practice", "Sometimes", "Rarely", "Best");
            #endregion
            #endregion
            #region StringFormatting
            //int x = 10, y = 5, result;
            //result = x + y;
            //string message;


            //////1. string Interpolation 
            //message = $"Equation : {x} + {y} = {result}";
            //Console.WriteLine(message);


            //////2.String.Format
            /////
            //message = string.Format("Equation: {0} + {1} = {2}", x, y, result);
            //Console.WriteLine(message);


            //////3. Composit Format
            /////

            //Console.WriteLine();
            //Console.WriteLine("Equation: {0} + {1} = {2}", x, y, result);


            //////4.string Concatination

            //Console.WriteLine("Equation: " + x + " + " + y + " = " + result);

            //string FilePath = @"C:\Users\Eng.Asmaa\Desktop\55\StringFormattingG03";
            //string FilePath2 = "C:\\Users\\Eng.Asmaa\\Desktop\\55\\StringFormattingG03\n\t\a";
            //Console.WriteLine($"{FilePath} {FilePath2}");
            //Console.WriteLine($"{FilePath2}");

            #endregion
        }
    }
    }
