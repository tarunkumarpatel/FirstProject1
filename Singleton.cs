using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public sealed class Singleton
    {
        private static int _counter = 0;
        private static Singleton _instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance=new Singleton();
                return _instance;
                
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Singleton"/> class.
        /// </summary>
        private Singleton()
        {
            _counter++;
            Console.WriteLine("counter:- {0}",_counter);
        }



        /// <summary>
        /// Prints the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
