namespace Inhertaince
{
    class TypeA
    {
        public virtual void MyFun02()
        {
            Console.WriteLine("TypeA");
        }
    }

    class TypeB : TypeA
    {
        public override void MyFun02()
        {
            Console.WriteLine("TypeB");
        }
    }

    class TypeC : TypeB
    {
        public override void MyFun02()
        {
            Console.WriteLine("TypeC");
        }
    }

    class TypeD : TypeC
    {
        // ❗ كسر السلسلة القديمة
        public new virtual void MyFun02()
        {
            Console.WriteLine("TypeD (new virtual)");
        }
    }
    class TypeE : TypeD
    {
        // override على السلسلة الجديدة
        public override void MyFun02()
        {
            Console.WriteLine("TypeE (override new chain)");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- CASE 1 ----");
            TypeA a = new TypeE();
            a.MyFun02();
            // 👉 TypeC (آخر override في السلسلة القديمة)

            Console.WriteLine("---- CASE 2 ----");
            TypeB b = new TypeE();
            b.MyFun02();
            // 👉 TypeC

            Console.WriteLine("---- CASE 3 ----");
            TypeC c = new TypeE();
            c.MyFun02();
            // 👉 TypeC

            Console.WriteLine("---- CASE 4 ----");
            TypeD d = new TypeE();
            d.MyFun02();
            // 👉 TypeE (السلسلة الجديدة)

            Console.WriteLine("---- CASE 5 ----");
            TypeE e = new TypeE();
            e.MyFun02();
            // 👉 TypeE

            Console.WriteLine("---- CASE 6 ----");
            TypeD d2 = new TypeD();
            d2.MyFun02();
            // 👉 TypeD

            Console.WriteLine("---- CASE 7 ----");
            TypeC c2 = new TypeD();
            c2.MyFun02();
            // 👉 TypeC (لأن new فصل السلسلة)

            Console.WriteLine("---- CASE 8 ----");
            TypeA a2 = new TypeD();
            a2.MyFun02();
        }
    }
}
