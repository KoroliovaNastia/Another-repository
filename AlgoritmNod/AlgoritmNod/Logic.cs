using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlgoritmNod
{
    public static class Logic
    {
        public static int NodE(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }
        public static int NodE(int a, int b, out long time)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            a = Logic.NodE(a,b);
            time = sWatch.ElapsedTicks;
            return a;
        }
        public static int NodE(int a, int b, int c)
        {
            while (b != 0)
                b = a % (a = b);
            while (c != 0)
                c = a % (a = c);
            return a;
        }
        public static int NodE(int a, int b, int c, out long time)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            a = Logic.NodE(a, b, c);
            time = sWatch.ElapsedTicks;
            return a;
        }
        public static int NodE(params int[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                while (list[i] != 0)
                    list[i] = list[0] % (list[0] = list[i]);
            }
            return list[0];
        }
        public static int NodE(out long time, params int[] list)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            list[0] = Logic.NodE(list);
            time = sWatch.ElapsedTicks;
            return list[0];
        }
        public static int NodS(int a, int b)
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
            //Console.WriteLine(sWatch.ElapsedMilliseconds.ToString());
            return NodS(b, Math.Abs(a - b));
            
        }
        public static int NodS(params int[] list)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            for (int i = 1; i < list.Length; i++)
            {
                list[0] = NodS(list[0], list[i]);
            }
            sWatch.Stop();
            //Console.WriteLine(sWatch.ElapsedMilliseconds.ToString());
            return list[0];
        }
    }
}
