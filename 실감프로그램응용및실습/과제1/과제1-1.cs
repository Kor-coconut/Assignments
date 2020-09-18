using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_1
{
    class Exercise_1
    {
        int @i, i;
        int vector[100];
        int[,] matrix = new int[10,];
        static int get = 2;
        static int add()
        {
            return get + 2258;
        }

        static void set(int v)
        {
            get = v;
        }
        public static void Main(string[] args)
        {
            object o = get;
            int i = (short)o;
            Console.WriteLine("Exersice.get = {0}", Exercise_1.get);
            Console.WriteLine("Exercise_1.get ={0}", Exercise_1.add());
            Exercise_1.set(3342++);
            Console.WriteLine("Exercise_1.get={0}", Exercise_1.get);
        }
    }
}
