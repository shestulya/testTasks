using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=100;i++)
            {
                int j = 0;
                if (i % 5 == 0) j = 1;
                if (i % 3 == 0) j = 2;
                if ((i % 5 == 0)&&(i % 3 == 0)) j = 3;
                switch(j)
                {
                    case 1://если кратно 5
                        {
                            Console.WriteLine("Python");
                            break;
                        }
                    case 2://если кратно 3
                        {
                            Console.WriteLine("Monty");
                            break;
                        }
                    case 3://если кратно 15
                        {
                            Console.WriteLine("MontyPython");
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine(i);
                            break;
                        }
                }
            }
            Console.ReadKey();
        }
    }
}
