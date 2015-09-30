using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlgoritmNod
{
    class Logic
    {
        private int NodE(int a, int b)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            while (b != 0)
                b = a % (a = b);
            sWatch.Stop();
            Console.WriteLine(sWatch.ElapsedMilliseconds.ToString());
            return a;
        }
        private int NodE(params int[] list)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            for (int i = 1; i < list.Length; i++)
            {
                while (list[i] != 0)
                    list[i] = list[0] % (list[0] = list[i]);
            }
            sWatch.Stop();
            Console.WriteLine(sWatch.ElapsedMilliseconds.ToString());
            return list[0];
        }
        private int NodS(int a, int b)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            if (a == 0)
              return b; 
            if (b == 0)
             return a; 
            if (a == b)
             return a; 
            if (a == 1 || b == 1)
             return 1; 
            if ((a % 2 == 0) && (b % 2 == 0))
             return 2 * NodS(a / 2, b / 2); 
            if ((a % 2 == 0) && (b % 2 != 0))
             return NodS(a / 2, b); 
            if ((a % 2 != 0) && (b % 2 == 0))
            return NodS(a, b / 2); 
            sWatch.Stop();
            Console.WriteLine(sWatch.ElapsedMilliseconds.ToString());
            return NodS(b, Math.Abs(a - b));
            
        }
         private int NodS(params int[] list)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            for (int i = 1; i < list.Length; i++)
            {
                list[0] = NodS(list[0], list[i]);
            }
            sWatch.Stop();
            Console.WriteLine(sWatch.ElapsedMilliseconds.ToString());
            return list[0];
        }
    }
}
