using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassOrMethodProject
{
    public class deleteElementGenrice
    {
        public void delete<T>(T[] arr,int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("index not in range");
                return;
            }
            T[] brr = new T[arr.Length];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i < index)
                    brr[i] = arr[i];
                else
                    brr[i] = arr[i + 1];
            }
            for (int i = 0; i < brr.Length; i++)
            {
                if (!brr[i].Equals(0))
                Console.Write(brr[i]+" ");

            }
        }
    }
}
