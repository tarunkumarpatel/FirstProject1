using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton Emp = Singleton.GetInstance;
            Emp.Print("hii All Employyee");
            Emp.Print("how r u all ?");

            Singleton std = Singleton.GetInstance;
            std.Print("hii All Student");
            std.Print("how r u all ?");
            try
            {
                string value = null;
                if (value.Length == 0) // <-- Causes exception
                {
                    Console.WriteLine(value); // <-- Never reached
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
