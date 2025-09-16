using System.Resources;
using System.Threading.Channels;

namespace homework1;

class Program
{
    static void Main(string[] args)
    {
        // N1 
        
        // Console.Write("Enter number: ");
        // int num = int.Parse(Console.ReadLine());
        // string res = num % 5 == 0 ? "Yes" : "No";
        // Console.WriteLine(res);
        //
        
        //N2

         // Console.Write("Enter first number: ");
         // int firstNumber = int.Parse(Console.ReadLine());
         // Console.Write("enter second number: ");
         // int secondNumber = int.Parse(Console.ReadLine());
         // int sum = firstNumber + secondNumber;
         // int multiply = firstNumber * secondNumber;
         // int difference;
         // int divide = 0;
         // if (firstNumber > secondNumber)
         // {
         //     difference = firstNumber - secondNumber;
         //     if (firstNumber != 0 && secondNumber != 0)
         //     {
         //         divide = firstNumber / secondNumber;
         //     }
         //     
         // }
         // else
         // {
         //     difference = secondNumber - firstNumber;
         //     if (firstNumber != 0 && secondNumber != 0)
         //     {
         //         divide = secondNumber / firstNumber;
         //     }
         // }
         //
         // Console.WriteLine($"Sum : {sum}");
         // Console.WriteLine($"difference : {difference}");
         // Console.WriteLine($"Multiplication : {multiply}");
         // if (firstNumber == 0 || secondNumber == 0)
         // {
         //     Console.WriteLine($"division : Not Allowed to divide by zero");
         // }
         // else
         // {
         //     Console.WriteLine($"division : {divide}");
         // }
         
         //N3

         Console.Write("Enter first number a : ");
         int a = int.Parse(Console.ReadLine());
         Console.Write("Enter second number b : ");
         int b = int.Parse(Console.ReadLine());
         Console.WriteLine($"a : {a} \nb : {b}");

         int c = a;
         a = b;
         b = c;
         Console.WriteLine("after change");
         Console.WriteLine($"a : {a} \nb : {b}");
         







    }
}