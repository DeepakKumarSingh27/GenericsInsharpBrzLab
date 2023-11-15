using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassOrMethodProject
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose the option ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    DeleteElement ps = new DeleteElement();
                    Console.WriteLine("Integer Type Array");
                    int[] x = ps.deleteElement(new int[] { 1, 2, 3, 4, 5 }, 2);
                    for (int i = 0; i < x.Length; i++)
                    {
                        Console.Write(x[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Double Type Array");
                    double[] y = ps.deleteElement(new double[] { 1.1, 2.2, 3.2, 4.2, 5.2 }, 2);
                    for (int i = 0; i < y.Length; i++)
                    {
                        Console.Write(y[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Char Type Array");
                    char[] z = ps.deleteElement(new char[] { 'A', 'B', 'C', 'D', 'E' }, 2);
                    for (int i = 0; i < z.Length; i++)
                    {
                        Console.Write(z[i] + " ");
                    }
                    break;
                    case 2:
                     deleteElementGenrice gs = new deleteElementGenrice();
                    gs.delete(new int[] { 1, 2, 3, 4, 5, 6 }, 2);
                    Console.WriteLine();
                    gs.delete(new double[] { 1.1, 2.2, 3.2, 4.2, 5.2, 6.2 }, 2);
                    Console.WriteLine();
                    gs.delete(new char[] { 'A', 'B', 'C', 'D', 'E' }, 2);
                    break;
                    case 3:
                    GenericClassDeleteEle<double> ds = new GenericClassDeleteEle<double>();
                    ds.delete(new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 },1);
                    ds.delete(new char[] { 'A', 'B', 'C', 'D', 'E' }, 2);
                    break;
                    case 4:
                    MinimumAndMax ms = new MinimumAndMax();
                    ms.findMax(1, 2, 3);
                    ms.findMax(1.1f, 2.2f, 3.3f);
                    ms.findMax("1", "2", "3");
                    break;
                    case 5:
                    GenMaxAndMin<int> xs = new GenMaxAndMin<int>(1,2,3);
                    Console.WriteLine(xs.maxMethod());
                    break;
                    default: Console.WriteLine("Number don't match");
                    break;
            }
            Console.ReadLine();

        }
    }
}
