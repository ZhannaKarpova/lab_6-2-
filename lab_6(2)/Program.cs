using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string str = Console.ReadLine();
            char[] newstr = str.ToCharArray();

            Array.Reverse(newstr);

            string str2 = new string(newstr);

            if (str.Equals(str2))
                Console.WriteLine("yes");
            else Console.WriteLine("no");

            Console.ReadLine();
        }
    }
}
