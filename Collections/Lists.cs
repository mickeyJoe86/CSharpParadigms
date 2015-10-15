using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms
{
    class Lists
    {
        List<int> myList = new List<int>();
        
        public void AddNumber(int num)
        {
            myList.Add(num);
                       
        }

        public void PrintList()
        {
            foreach(var num in myList)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
