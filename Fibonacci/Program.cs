using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
             // setup
            Console.Write("Input number of terms for the Fibonacci series : ");
            string Inp = Console.ReadLine();
            int input = Int32.Parse(Inp);

            // calling recursive methods
            Console.Write("The Fibonacci series of " + input + "  terms calculated recursively is :");

            foreach(int n in Fobbonocci(input))
            {
                Console.Write(" " + n);
            }
            Console.WriteLine();



            // calculating iteratively
            Console.Write("The Fibonacci series of " + input + "  terms calculated iteratively is :");
            List<int> fobbonoc = new List<int> {};

            for (int i = 1; i <= input; i++)
            {
                if (i == 1)
                    fobbonoc.Add(0);
                else if (i == 2)
                    fobbonoc.Add(1);
                else
                {
                    fobbonoc.Add(fobbonoc[i - 3] + fobbonoc[i-2]);
                }
            }
            foreach (int n in fobbonoc)
            {
                Console.Write(" " + n);
            }

            Console.ReadLine();
            


               // recursive method
            List<int> Fobbonocci(int n)
            {

                if (n == 1)
                {
                    return new List<int> { 0 };
                }
                else if (n == 2)
                {
                    return new List<int> { 0, 1 };
                }
                else
                {
                    List<int> fob = Fobbonocci(n - 1);
                    fob.Add(fob[fob.Count - 2] + fob[fob.Count - 1]);
                    return fob;
                }

            }



        }
    }

    


}
