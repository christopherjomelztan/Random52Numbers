using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random52Numbers
{
class Program
    { 
        static void Main(string[] args)
        {
            Executor();
        }

        private static void Executor()
        {
            Console.WriteLine("Please enter low number:");
            int low = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter high number:");
            int high = int.Parse(Console.ReadLine());
            ListOperation listOperation = new ListOperation();
            listOperation.PopulateList(low, high);
            List<int> myList = listOperation.myList;

            Console.WriteLine("--------------OUTPUT-----------------");
            foreach (int x in myList)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Try again?");

            if (Console.ReadLine() == "Y")
                Executor();
        }
    }
}
