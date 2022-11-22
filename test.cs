using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /*  
          *  program--1
          *  Console.WriteLine("Enter you String please");
             //int number  = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your name is : "+number);
            string str=Console.ReadLine();
            Console.WriteLine("Your string is "+ str);

            /*int rev = 0,rem;
            if(str.Length%2!=0)
            {
                while(number!=0)
                {
                    rem = number % 10;
                    rev = rev*10 +rem;
                    number = number / 10;

                }
                Console.WriteLine("reverse is " + rev);
            }
            else
            {
                for(int i=str.Length/2-1;i>=0;i--)
                {
                    Console.Write(str[i]);
                }
                for(int i =str.Length/2;i<str.Length;i++)
                {
                    Console.Write(str[i]);
                }
            }
            //else*/

            //program--2
            /*for(int i = 0; i < str.Length; i++)
            {
                int n = (int)str[i];
                // int n = Math.Abs((int)str[i]%97);
                //int rem =  26/n;
               // Console.WriteLine(n);
                int rem = (26 - (str[i] - 97));
                //Console.WriteLine(rem);
                int m = rem % 26;
                //Console.WriteLine(m);
                Console.Write(Convert.ToChar((97+m+3)));

                

            }
            */
            

        }
    }
}
