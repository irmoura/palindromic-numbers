using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromic_numbers
{
    class Program
    {

        static string reverse(string num, int startIndex, int length)
        {
            char[] chars = num.Substring(startIndex, length).ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        static void Main(string[] args)
        {
            int limite = 999999999;
            for (int i = 11; i < limite; i++)
            {
                string num = $"{i}";
                switch (num.Length)
                {
                    case 2:
                        if (num.Substring(0, 1).Equals(num.Substring(1, 1)))
                        {
                            Console.Write($"{i},");
                        }
                        break;
                    case 3:
                        if (num.Substring(0, 1).Equals(num.Substring(2, 1)))
                        {
                            Console.Write($"{i},");
                        }
                        break;
                    case 4:
                        if (num.Substring(0, 2).Equals(reverse(num, 2, 2)))
                        {
                            Console.Write($"{i},");
                        }
                        break;
                    case 5:
                        if (num.Substring(0, 2).Equals(reverse(num, 3, 2)))
                        {
                            Console.Write($"{i},");
                        }
                        break;
                    case 6:
                        if (num.Substring(0, 3).Equals(reverse(num, 3, 3)))
                        {
                            Console.Write($"{i},");
                        }
                        break;
                    case 7:
                        if (num.Substring(0, 3).Equals(reverse(num, 4, 3)))
                        {
                            Console.Write($"{i},");
                        }
                        break;
                    case 8:
                        if (num.Substring(0, 4).Equals(reverse(num, 4, 4)))
                        {
                            Console.Write($"{i},");
                        }
                        break;
                    case 9:
                        if (num.Substring(0, 4).Equals(reverse(num, 5, 4)))
                        {
                            Console.Write($"{i},");
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.Write($"{limite}");
            Console.ReadKey();
        }
    }
}
