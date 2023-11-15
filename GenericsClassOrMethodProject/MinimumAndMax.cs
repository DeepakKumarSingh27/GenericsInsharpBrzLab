using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassOrMethodProject
{
    public class MinimumAndMax
    {
        public void findMax(int a, int b, int c)
        {
            int min = (a <= b) ? ((a <= c) ? a : b) :((b <= c) ? b : c);
            Console.WriteLine(min);
        }
        public void findMax(float a, float b, float c)
        {
            float min = (a <= b) ? ((a <= c) ? a : b) : ((b <= c) ? b : c);
            Console.WriteLine(min);
        }
        public void findMax(string x, string y, string z)
        {
            int a = int.Parse(x);
            int b = int.Parse(y);   
            int c = int.Parse(z);
            int min = (a <= b) ? ((a <= c) ? a : b) : ((b <= c) ? b : c);
            Console.WriteLine(min);
        }
    }
}
