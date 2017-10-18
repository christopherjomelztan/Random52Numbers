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
            ListOperation listOperation = new ListOperation();
            listOperation.PopulateList(1,200);
            List<int> myList = listOperation.myList;
            foreach (int x in myList)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
