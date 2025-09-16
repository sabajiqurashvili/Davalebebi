using System.Resources;
using System.Threading.Channels;

namespace homework1;

class Program
{
    static void Main(string[] args)
    {
        // N1 
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        string res = num % 5 == 0 ? "Yes" : "No";
        Console.WriteLine(res);
        
    }
}