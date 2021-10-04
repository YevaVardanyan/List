using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            _List firstList = new _List();
            firstList.Add(12);
            firstList.Add(15);
            firstList.Add(16);
            firstList.Add(147);
            firstList.Add(100);
            foreach (int item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }
    }
}
