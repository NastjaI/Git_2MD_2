using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Git_Console_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, counter = 0;

            for (int i = 0; i == counter; i++)
            {
                try
                {
                    Console.Write("\n Enter please first number:  ");
                    x = Int32.Parse(Console.ReadLine());

                    Console.Write(" Enter please second number: ");
                    y = Int32.Parse(Console.ReadLine());

                    z = x * y;

                    Console.WriteLine("\n x * y = " + z);

                    if (z <= 0) Console.WriteLine(" No stars!");
                    else
                    {
                        for (int star = 1; star <= z; star++)
                        {
                            Console.WriteLine(" " + star + ". *");
                        }
                    }

                }
                catch (Exception error)
                {
                    Console.WriteLine("\n " + error.Message);
                    counter++;
                }
            }

            Console.ReadKey();
        }
    }
}
