using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, rem, temp = 0;
            Console.WriteLine("Enter the number to be checked:");
            num=Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                rem = num % 10;
                num = num / 10;
                sum = sum * 10 + rem;
            }
            if(temp == sum)
            {
                Console.WriteLine("The given number is palindrome");
            }
            else
            {
                Console.WriteLine("The given number is not a palindrome");
            }
            Console.WriteLine();
        }
    }
}
