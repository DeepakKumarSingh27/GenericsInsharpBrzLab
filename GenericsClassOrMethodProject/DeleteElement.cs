using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassOrMethodProject
{
    public class DeleteElement
    {
       

        public int[] deleteElement(int[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("index not in range");
                return arr;
            }
            int[] brr = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i < index)
                    brr[i] = arr[i];
                else
                    brr[i] = arr[i + 1];
            }
            return brr;
        }
        public double[] deleteElement(double[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("index not in range");
                return arr;
            }
            double[] brr = new double[arr.Length - 1];
            for (int i = 0; i < brr.Length - 1; i++)
            {
                if (i < index)
                    brr[i] = arr[i];
                else
                    brr[i] = arr[i + 1];
            }
            return brr;
        }
        public char[] deleteElement(char[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("index not in range");
                return arr;
            }
            char[] brr = new char[arr.Length - 1];
            for (int i = 0; i < brr.Length - 1; i++)
            {
                if (i < index)
                    brr[i] = arr[i];
                else
                    brr[i] = arr[i + 1];
            }
            return brr;
        }
    }
}
