
namespace EnumS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your gender:");
            string? input = Console.ReadLine();
            Enum.TryParse<Gender>(input,true ,out Gender Gender);
            Console.WriteLine(Gender);
            Console.WriteLine("============");
            Console.WriteLine("Enter your PermissionCode:");
            input = Console.ReadLine();
            Enum.TryParse<PermissionCode>(input, true, out PermissionCode PermissionCode);
            Console.WriteLine(PermissionCode);
        }
    }
}
