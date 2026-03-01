namespace Conditional
{
    enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered
    }
    class Person
    {
        public int Age { get; set; }
    }
    enum PaymentStatus
    {
        Pending,
        Paid,
        Failed
    }
    class User
    {
        public bool IsActive { get; set; }
    }

    class Person3
    {
        public string? Name { get; set; }
    }
    internal class Person1
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region C# Switch Evolution — All Versions Cheat Sheet

            // =====================================================
            // 🟢 C# 1.0 — Classic switch (2002)
            // =====================================================
            int day = 2;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;

                case 2:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Unknown");
                    break;
            }


            // =====================================================
            // 🟢 C# 1.0 — Multiple cases same result
            // =====================================================
            int day2 = 6;

            switch (day2)
            {
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;

                default:
                    Console.WriteLine("Weekday");
                    break;
            }


            // =====================================================
            // 🟢 C# 1.0 — switch with enum (best practice)
            // =====================================================


            OrderStatus status = OrderStatus.Shipped;

            switch (status)
            {
                case OrderStatus.Pending:
                    Console.WriteLine("Waiting");
                    break;

                case OrderStatus.Shipped:
                    Console.WriteLine("On the way");
                    break;

                case OrderStatus.Delivered:
                    Console.WriteLine("Done");
                    break;
            }


            // =====================================================
            // 🟡 C# 7.0 — Type Pattern (Pattern Matching begins)
            // =====================================================
            object obj = "Hello";

            switch (obj)
            {
                case string s:
                    Console.WriteLine($"String length: {s.Length}");
                    break;

                case int n:
                    Console.WriteLine($"Number: {n}");
                    break;
            }


            // =====================================================
            // 🟡 C# 7.0 — switch with when (Guard)
            // =====================================================
            int score = 85;

            switch (score)
            {
                case int s when s >= 90:
                    Console.WriteLine("Excellent");
                    break;

                case int s when s >= 75:
                    Console.WriteLine("Very Good");
                    break;

                default:
                    Console.WriteLine("Fail");
                    break;
            }


            // =====================================================
            // 🔵 C# 8.0 — Switch Expression (VERY IMPORTANT)
            // =====================================================
            int day3 = 3;

            string name = day3 switch
            {
                1 => "Saturday",
                2 => "Sunday",
                3 => "Monday",
                _ => "Unknown"
            };

            Console.WriteLine(name);


            // =====================================================
            // 🔵 C# 8.0 — Property Pattern
            // =====================================================

            Person p = new Person { Age = 22 };

            string category1 = p switch
            {
                { Age: >= 18 } => "Adult",
                _ => "Minor"
            };


            // =====================================================
            // 🟣 C# 9.0 — Relational + Logical Patterns
            // =====================================================
            int age = 25;

            string category2 = age switch
            {
                < 13 => "Child",
                >= 13 and < 20 => "Teen",
                >= 20 and < 60 => "Adult",
                _ => "Senior"
            };


            // =====================================================
            // 🟣 C# 9.0 — Logical patterns (and/or/not)
            // =====================================================

            int age3 = 15;

            string resultLogical = age3 switch
            {
                not >= 18 => "Minor",          // age < 18
                >= 18 and < 60 => "Adult",
                _ => "Senior"
            };

            Console.WriteLine(resultLogical);


            // =====================================================
            // 🟣 C# 9.0 — Tuple Pattern (Advanced)
            // =====================================================
            (int x, int y) point = (0, 5);

            string location = point switch
            {
                (0, 0) => "Origin",
                (0, _) => "Y axis",
                (_, 0) => "X axis",
                _ => "Somewhere"
            };


            // =====================================================
            // ⚫ C# 11 — List Pattern
            // =====================================================
            int[] numbers = { 1, 2, 3 };

            string listResult = numbers switch
            {
                [1, 2, 3] => "Match",
                _ => "No match"
            };


            // =====================================================
            // ⚫ Modern — switch expression with when
            // =====================================================
            object obj2 = 10;

            string finalResult = obj2 switch
            {
                int n when n > 0 => "Positive",
                int n when n < 0 => "Negative",
                int => "Zero",
                _ => "Unknown"
            };

            #endregion
            #region 🔥 Advanced Switch — Professional Examples

            // =====================================================
            // ⭐ Example 1 — Constant pattern with string
            // =====================================================
            string command = "start";

            string action = command switch
            {
                "start" => "Starting system",
                "stop" => "Stopping system",
                "pause" => "Pausing system",
                _ => "Unknown command"
            };

            Console.WriteLine(action);


            // =====================================================
            // ⭐ Example 2 — Var pattern (Interview favorite)
            // =====================================================
            int number1 = 7;

            string parity = number1 switch
            {
                var n when n % 2 == 0 => "Even",
                var n => $"Odd: {n}"
            };

            Console.WriteLine(parity);


            // =====================================================
            // ⭐ Example 3 — Nullable safe switch
            // =====================================================
            int? number2 = null;

            string resultNullable = number2 switch
            {
                null => "Value is null",
                < 0 => "Negative",
                >= 0 and <= 10 => "Between 0 and 10",
                _ => "Greater than 10"
            };

            Console.WriteLine(resultNullable);


// =====================================================
// ⭐ Example 4 — Enum switch (Best practice)
// =====================================================


        PaymentStatus payment = PaymentStatus.Paid;

        string paymentMessage = payment switch
        {
            PaymentStatus.Pending => "Waiting for payment",
            PaymentStatus.Paid => "Payment completed",
            PaymentStatus.Failed => "Payment failed",
            _ => throw new ArgumentOutOfRangeException(nameof(payment))
        };

        Console.WriteLine(paymentMessage);


// =====================================================
// ⭐ Example 5 — Property pattern (clean)
// =====================================================
Person1 person1 = new Person1 { Id = 1, Name = "Omar", Age = 35 };

        string personCategory = person1 switch
        {
            { Age: < 18 } => "Minor",
            { Age: >= 18 and < 60 } => "Adult",
            { Age: >= 60 } => "Senior",
            _ => "Unknown"
        };

        Console.WriteLine(personCategory);


// =====================================================
// ⭐ Example 6 — Tuple pattern (very important)
// =====================================================
(int width, int height) size = (1920, 1080);

        string screenType = size switch
        {
            (1920, 1080) => "Full HD",
            (2560, 1440) => "2K",
            (3840, 2160) => "4K",
            (_, _) => "Unknown resolution"
        };

        Console.WriteLine(screenType);


// =====================================================
// ⭐ Example 7 — List pattern (C# 11)
// =====================================================
int[] arr = { 1, 2, 3 };

        string listCheck = arr switch
        {
            [1, 2, 3] => "Exact sequence",
            [1, ..] => "Starts with 1",
            _ => "Different sequence"
        };

        Console.WriteLine(listCheck);


// =====================================================
// ⭐ Example 8 — Type pattern with object
// =====================================================
object input = 10.5;

        string typeResult = input switch
        {
            int n => $"Integer: {n}",
            double d when d > 10 => $"Large double: {d}",
            double d => $"Double: {d}",
            string s => $"String length: {s.Length}",
            null => "Null value",
            _ => "Unknown type"
        };

        Console.WriteLine(typeResult);


// =====================================================
// ⭐ Example 9 — Guard-heavy business rule
// =====================================================
decimal amount = 4200m;

        decimal commission = amount switch
        {
            < 1000 => 0.05m,
            >= 1000 and < 5000 => 0.10m,
            >= 5000 => 0.15m
        };

        Console.WriteLine(commission);


// =====================================================
// ⭐ Example 10 — NOT pattern (correct usage)
// =====================================================
int age4 = 15;

        string ageGroup = age4 switch
        {
            not >= 18 => "Minor",
            >= 18 and < 60 => "Adult",
            _ => "Senior"
        };

        Console.WriteLine(ageGroup);

            #endregion
            #region 🔥 IF / ELSE / ELSE IF / NESTED IF / TERNARY — Full Cheat Sheet

            // =====================================================
            // 🟢 1) Basic if
            // =====================================================
            int age5 = 20;

            if (age5 >= 18)
            {
                Console.WriteLine("Adult");
            }


            // =====================================================
            // 🟢 2) if – else
            // =====================================================
            int age6 = 16;

            if (age6 >= 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }


            // =====================================================
            // 🟢 3) else if ladder (multiple conditions)
            // =====================================================
            int score2 = 85;

            if (score2 >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (score2 >= 75)
            {
                Console.WriteLine("Very Good");
            }
            else if (score2 >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }


            // =====================================================
            // 🟢 4) Nested if
            // =====================================================
            int age7 = 25;
            bool hasID = true;

            if (age7 >= 18)
            {
                if (hasID)
                {
                    Console.WriteLine("Entry allowed");
                }
            }


            // =====================================================
            // 🟢 5) Combined conditions (Best Practice)
            // =====================================================
            int age8 = 25;
            bool hasTicket = true;

            if (age8 >= 18 && hasTicket)
            {
                Console.WriteLine("Allowed with ticket");
            }


            // =====================================================
            // 🟢 6) Logical Operators
            // =====================================================
            bool isStudent = false;
            bool hasCoupon = true;

            if (isStudent || hasCoupon)
            {
                Console.WriteLine("Discount applied");
            }

            if (!hasID)
            {
                Console.WriteLine("ID required");
            }


            // =====================================================
            // 🟡 7) Guard Clause (Professional style)
            // =====================================================
            User user = new User { IsActive = true };

            if (user == null) return;
            if (!user.IsActive) return;

            Console.WriteLine("Processing user");


            // =====================================================
            // 🔵 8) Simple ternary operator
            // =====================================================
            int age9 = 20;

            string result = age9 >= 18 ? "Adult" : "Minor";
            Console.WriteLine(result);


            // =====================================================
            // 🔵 9) Ternary with assignment
            // =====================================================
            int marks = 45;

            string status2 = marks >= 50 ? "Pass" : "Fail";
            Console.WriteLine(status2);


            // =====================================================
            // 🔵 10) Nested ternary (use carefully)
            // =====================================================
            int score3 = 82;

            string grade =
                score3 >= 90 ? "A" :
                score3 >= 75 ? "B" :
                score3 >= 50 ? "C" :
                "F";

            Console.WriteLine(grade);


            // =====================================================
            // 🔵 11) Ternary inside Console.WriteLine
            // =====================================================
            int temperature = 30;

            Console.WriteLine(
                temperature > 25 ? "Hot weather" : "Cold weather"
            );


            // =====================================================
            // 🔵 12) Complex condition in if
            // =====================================================
            int balance = 1500;
            bool isPremium = true;

            if (balance > 1000 && isPremium)
            {
                Console.WriteLine("Premium access granted");
            }


            // =====================================================
            // 🔵 13) Safe null check in if
            // =====================================================
            Person3 person = new Person3 { Name = "Omar" };

            if (person?.Name == "Omar")
            {
                Console.WriteLine("Hello Omar");
            }


            // =====================================================
            // 🔵 14) Multiple statements danger example (for awareness)
            // =====================================================
            int age11 = 19;

            // ⚠️ Be careful — only first line is inside if
            if (age11 >= 18)
                Console.WriteLine("Adult");
            Console.WriteLine("This always runs");

            #endregion
            #region Differeence between IF , SWITCH
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                ⚡ Performance Comparison (Readable)                         ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║ الحالة                │     if        │     switch     │     ternary       ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║ ONLY 2 CONDITION      │  EXCELLENT    │     GOOD       │    EXCELLENT      ║");
            Console.WriteLine("║ 5–10 CONSTANT VALUE   │     GOOD      │   EXCELLENT    │   NOT SUITABLE    ║");
            Console.WriteLine("║ ranges (<, >)         │  EXCELLENT    │     GOOD       │   NOT SUITABLE    ║");
            Console.WriteLine("║ enum                  │     GOOD      │   EXCELLENT    │   NOT SUITABLE    ║");
            Console.WriteLine("║ type patterns         │     GOOD      │   EXCELLENT    │   NOT SUITABLE    ║");
            Console.WriteLine("║ simple assignment     │     GOOD      │     GOOD       │    EXCELLENT      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");

            Console.WriteLine();
            Console.WriteLine("Legend:");
            Console.WriteLine("EXCELLENT = Best choice");
            Console.WriteLine("GOOD      = Acceptable");
            Console.WriteLine("NOT SUITABLE = Avoid in this case");
            #endregion

        }

    }
}