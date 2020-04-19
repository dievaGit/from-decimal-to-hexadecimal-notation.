using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int n = 0, newNum = 0, rest = 0;
            Stack hexa = new Stack();
            char character = ' ';
            char[] hexaDecimal = new char[100];


            //Requesting the decimal from the user
            Console.Write(" Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            newNum = n;

            //Converting from decimal to hexadecimal
            do
            {
                rest = newNum % 16;
                newNum /= 16;
                switch (rest)
                {
                    case 10:
                        hexa.Push("A");
                        break;
                    case 11:
                        hexa.Push("B");
                        break;
                    case 12:
                        hexa.Push("C");
                        break;
                    case 13:
                        hexa.Push("D");
                        break;
                    case 14:
                        hexa.Push("E");
                        break;
                    case 15:
                        hexa.Push("F");
                        break;
                    default:
                        hexa.Push(rest);
                        break;
                }
            }
            while (newNum > 0);

            //Showing the number
            Console.Write("The number converted to hexadecimal");
            for(int i = 0; i < hexa.Count; i++)
            {
                character = Convert.ToChar(hexa.Pop());
                Console.Write(" {0}",character);
            }

            Console.ReadKey();
        }
    }
}
