using System.Collections.Generic;
using System.Drawing;

namespace DATATYPES
{

    class Car
    {
        public string? Model;
        public int Year;
    }
    struct Person
    {
        public string Name;
        public int Age;
    }

    interface IAnimal
    {
        void Speak();//Contract 
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("wwwwoof");
        }
    }

    internal class Program
    {
        [assembly: CLSCompliant(true)]
        public static uint GetNumber()
        {
            return 10;
        }
        static void Main(string[] args)
        {
            #region  Data types
            #region Bulit in Data type 
            Console.WriteLine("Data types Section");
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types?utm_source=chatgpt.com
            Console.WriteLine($"bool        : false → true | size = {sizeof(bool)} byte");

            Console.WriteLine($"byte        : {byte.MinValue} → {byte.MaxValue} | size = {sizeof(byte)} byte");
            Console.WriteLine($"sbyte       : {sbyte.MinValue} → {sbyte.MaxValue} | size = {sizeof(sbyte)} byte");

            Console.WriteLine($"short       : {short.MinValue} → {short.MaxValue} | size = {sizeof(short)} bytes");
            Console.WriteLine($"ushort      : {ushort.MinValue} → {ushort.MaxValue} | size = {sizeof(ushort)} bytes");

            Console.WriteLine($"int         : {int.MinValue} → {int.MaxValue} | size = {sizeof(int)} bytes");
            Console.WriteLine($"uint        : {uint.MinValue} → {uint.MaxValue} | size = {sizeof(uint)} bytes");

            Console.WriteLine($"long        : {long.MinValue} → {long.MaxValue} | size = {sizeof(long)} bytes");
            Console.WriteLine($"ulong       : {ulong.MinValue} → {ulong.MaxValue} | size = {sizeof(ulong)} bytes");

            Console.WriteLine($"nint        : {nint.MinValue} → {nint.MaxValue} | size = {IntPtr.Size} bytes");
            Console.WriteLine($"nuint       : {nuint.MinValue} → {nuint.MaxValue} | size = {UIntPtr.Size} bytes");

            Console.WriteLine($"float       : {float.MinValue} → {float.MaxValue} | size = {sizeof(float)} bytes");
            Console.WriteLine($"double      : {double.MinValue} → {double.MaxValue} | size = {sizeof(double)} bytes");
            Console.WriteLine($"decimal     : {decimal.MinValue} → {decimal.MaxValue} | size = {sizeof(decimal)} bytes");

            Console.WriteLine($"char        : {(int)char.MinValue} → {(int)char.MaxValue} | size = {sizeof(char)} bytes");
            string str = "Hello";
            Console.WriteLine($"string      : \"{str}\" | Reference Type | size = dynamic");
            //DateTime now = DateTime.Now;
            //Console.WriteLine($"DateTime    : {now} | size = {sizeof(long)} bytes (ticks based)");
            #endregion
            #region var vs dynamic comparison

            Console.WriteLine("=== var vs dynamic comparison ===\n");

            Console.WriteLine("VAR SECTION");

            var  VarType= 10;
            Console.WriteLine($"Value = {VarType}, Type = {VarType.GetType().Name}");

            Console.WriteLine("var is checked at COMPILE TIME\n");

            // -------- dynamic --------
            Console.WriteLine("dynamicType SECTION");

            dynamic dynamicType = 10;
            Console.WriteLine($"Value = {dynamicType}, Type = {dynamicType.GetType().Name}");

            dynamicType = "text";
            Console.WriteLine($"Value = {dynamicType}, Type = {dynamicType.GetType().Name}");

            Console.WriteLine("Trying to access Length on dynamic...");

            try
            {
                Console.WriteLine(dynamicType.Length);
                dynamicType = 5;
                Console.WriteLine(dynamicType.Length); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Runtime Error: {ex.GetType().Name}");
            }

            #endregion


            #endregion
            #region Value and Reference Type
            Console.WriteLine("------------------------");
            Console.WriteLine("ValueType And RefType Section");
            int firstNumber, copiedNumber;
            firstNumber = 5;
            copiedNumber = 20;
            firstNumber = copiedNumber;
            Console.WriteLine("Before Increment:");
            Console.WriteLine($"firstNumber  = {firstNumber}");   // 20
            Console.WriteLine($"copiedNumber = {copiedNumber}");  // 20
            Console.WriteLine("------------------------");
            firstNumber++;
            Console.WriteLine("After Increment:");
            Console.WriteLine($"firstNumber  = {firstNumber}");   // 21
            Console.WriteLine($"copiedNumber = {copiedNumber}");  // 20
            string firstString = "hello";
            string copiedString = "h";
            Console.WriteLine($"copiedString = {copiedString}");
            Console.WriteLine("After Concat:");

            copiedString += "ello";
            Console.WriteLine($"firstString  = {firstString}");
            Console.WriteLine($"copiedString = {copiedString}");
            Console.WriteLine($"firstString == copiedString : {firstString == copiedString}");
            Console.WriteLine($"object.ReferenceEquals(firstString, copiedString) : {object.ReferenceEquals(firstString, copiedString)}");
            Point originalPoint;
            Point copiedPoint = new Point { x = 10, y = 20 };
            Console.WriteLine("Initial values:");
            Console.WriteLine($"copiedPoint.x = {copiedPoint.x}"); // 10
            Console.WriteLine($"copiedPoint.y = {copiedPoint.y}"); // 20
            Console.WriteLine("------------------------");
            originalPoint = copiedPoint;
            originalPoint.x = 888;
            Console.WriteLine("After modifying originalPoint:");
            Console.WriteLine($"originalPoint.x = {originalPoint.x}"); // 888
            Console.WriteLine($"originalPoint.y = {originalPoint.y}"); // 20
            Console.WriteLine($"copiedPoint.x = {copiedPoint.x}"); // 888
            Console.WriteLine($"copiedPoint.y = {copiedPoint.y}"); // 20
            #region Reference Type Demo (Class)

            Console.WriteLine("----- CLASS (Reference Type) DEMO -----");

            // Person
            Person person1;
            person1.Name = "Ali";
            person1.Age = 30;

            Console.WriteLine($"Person1 -> Name: {person1.Name}, Age: {person1.Age}");
            Console.WriteLine("--------------------------------------");

            // Car
            Car car1 = new Car();
            car1.Model = "BMW";
            car1.Year = 2025;

            Car car2 = car1;      // نفس الـ reference
            car2.Model = "Audi"; // تعديل من car2

            Console.WriteLine("After modifying Car2:");
            Console.WriteLine($"Car1 Model: {car1.Model}");
            Console.WriteLine($"Car2 Model: {car2.Model}");

            #endregion


            #endregion
            #region Boxing vs Unboxing

            Console.WriteLine("=== BOXING vs UNBOXING ===");

            // Value type
            int number = 10;

            // BOXING: value type -> object
            object boxed = number;

            Console.WriteLine("After Boxing:");
            Console.WriteLine($"number = {number}");
            Console.WriteLine($"boxed  = {boxed}");
            Console.WriteLine($"boxed type = {boxed.GetType().Name}");
            Console.WriteLine("--------------------------");

            // Change original value
            number = 20;

            Console.WriteLine("After changing original value:");
            Console.WriteLine($"number = {number}");
            Console.WriteLine($"boxed  = {boxed}"); // still 10
            Console.WriteLine("--------------------------");

            // UNBOXING: object -> value type (explicit cast)
            int unboxed = (int)boxed;

            Console.WriteLine("After Unboxing:");
            Console.WriteLine($"unboxed = {unboxed}");

            #endregion 
            #region Input and Output and Parser
            #region READ (ONE CHARACTER)

            Console.WriteLine("=== READ (ONE CHARACTER) ===");
            Console.Write("Enter any word and press Enter: ");

            int firstChar = Console.Read();    
            Console.WriteLine();
            Console.WriteLine($"Char code : {firstChar}");
            Console.WriteLine($"Character : {(char)firstChar}");
            Console.WriteLine();

            #endregion
            #region READ + READLINE TOGETHER

            Console.WriteLine("=== READ + READLINE ===");
            Console.Write("Enter a word: ");

            int ch = Console.Read();             // First character
            string? restOfLine = Console.ReadLine(); // Remaining text

            Console.WriteLine($"First char code : {ch}");
            Console.WriteLine($"First char      : {(char)ch}");
            Console.WriteLine($"Rest of line    : {restOfLine}");
            Console.WriteLine();

            #endregion
            #region TRYPARSE - INT

            Console.WriteLine("=== TRYPARSE (INT) ===");
            Console.Write("Enter your age: ");

            bool intOk = int.TryParse(Console.ReadLine(), out int age);

            if (intOk)
                Console.WriteLine($"Age: {age}");
            else
                Console.WriteLine("Invalid integer input");
            Console.WriteLine();

            #endregion
            //Console.WriteLine("=== SUMMARY ===");
            //Console.WriteLine("Console.Read()     -> reads ONE character and returns int");
            //Console.WriteLine("Console.ReadLine() -> reads a FULL line and returns string");
            //Console.WriteLine("TryParse           -> safe conversion without runtime errors");
            #region Read more line 
            string? line;

            while (true)
            {
                Console.WriteLine("Enter New Line to Exit Enter Empty Line");
                line = Console.ReadLine();

                if (string.IsNullOrEmpty(line))
                    break;

                Console.WriteLine(line);
            }
            #endregion
            #endregion
            #region Logical Operators (&&, &, ||, |)

            #region LOGICAL AND (&&) - Short Circuit

            Console.WriteLine("=== LOGICAL AND (&&) ===");

            bool a = false;
            bool b = true;

            if (a && b)
            {
                Console.WriteLine("Result: TRUE");
            }
            else
            {
                Console.WriteLine("Result: FALSE");
            }

            Console.WriteLine("Note: Second condition NOT executed if first is false");
            Console.WriteLine();

            #endregion

            #region LOGICAL AND (&) - No Short Circuit

            Console.WriteLine("=== LOGICAL AND (&) ===");

            if (a & b)
            {
                Console.WriteLine("Result: TRUE");
            }
            else
            {
                Console.WriteLine("Result: FALSE");
            }

            Console.WriteLine("Note: BOTH conditions are always executed");
            Console.WriteLine();

            #endregion

            #region LOGICAL OR (||) - Short Circuit

            Console.WriteLine("=== LOGICAL OR (||) ===");

            bool isAdmin = false;
            bool isOwner = true;

            if (isAdmin || isOwner)
            {
                Console.WriteLine("ACCESS GRANTED");
            }
            else
            {
                Console.WriteLine("ACCESS DENIED");
            }

            Console.WriteLine("Note: Second condition NOT executed if first is true");
            Console.WriteLine();

            #endregion

            #region LOGICAL OR (|) - No Short Circuit

            Console.WriteLine("=== LOGICAL OR (|) ===");

            if (isAdmin | isOwner)
            {
                Console.WriteLine("ACCESS GRANTED");
            }
            else
            {
                Console.WriteLine("ACCESS DENIED");
            }

            Console.WriteLine("Note: BOTH conditions are always executed");
            Console.WriteLine();

            #endregion

            #region SHORT CIRCUIT DANGER EXAMPLE

            Console.WriteLine("=== SHORT CIRCUIT DANGER EXAMPLE ===");

            string? name = null;

            // SAFE
            if (name != null && name.Length > 0)
            {
                Console.WriteLine("Name is valid");
            }
            else
            {
                Console.WriteLine("SAFE: No crash with &&");
            }

            // UNSAFE (comment to avoid crash)
            // if (name != null & name.Length > 0)
            // {
            //     Console.WriteLine("This line may crash");
            // }

            Console.WriteLine("Using & here causes NullReferenceException");
            Console.WriteLine();

            #endregion

            #endregion


        }



    }

    }
      

