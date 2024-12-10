using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// подсчитать количество числа со значением 5 в одномерном массиве.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 1, 3, 5, 7, 5, 2, 3, 4, 5, 6 };
            //int count = 0;
            //foreach(var element in omas)
            //{
            //    if(element==5)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            int count = omas.Count(x => x == 5);
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
