using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /// <summary>
    /// Сортировка одномерный массива по возрастанию и по убыванию.
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
            Array.Sort(people);
            foreach(var element in people)
            {
                Console.WriteLine(element);
            }
            Array.Reverse(people);
            foreach(var element in people)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

        }
    }
}
