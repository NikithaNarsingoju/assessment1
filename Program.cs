using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SwapTwoNos();
            multiply();
            Console.ReadLine();


        }
        private static void SwapTwoNos()
        {
            Console.WriteLine("input the first number:");
            int Firstno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the second number:");
            int Secondno = Convert.ToInt32(Console.ReadLine());
            int temp = Firstno;
            Firstno = Secondno;
            Secondno = temp;
            Console.WriteLine("After Swapping");
            Console.WriteLine($"First number : {Firstno}");
            Console.WriteLine($"Secong number : {Secondno}");
        }
        private static void multiply()
        {
            int Firstno;
            int Secondno;
            int Thirdno;
            Console.WriteLine("input the first number to multiply:");
            Firstno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the second number to multiply:");
            Secondno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the third number to multiply:");
            Thirdno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Firstno}*{Secondno}*{Thirdno}={Firstno * Secondno * Thirdno}");
        }
    }
   
}

