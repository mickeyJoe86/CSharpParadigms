using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms
{
    class Stacks
    {
        Stack<int> myStack = new Stack<int>();

        public void AddtoStack()
        {
            for (int i = 0; i < 50; i++)
            {
                myStack.Push(i);
            }
        }

        public void PrintStack()
        {
            foreach(int item in myStack)
            {
                Console.WriteLine("{0}", item);
            }
            var whichItem = myStack.Pop();
            Console.WriteLine("Item popped: {0}", whichItem);
            var whichItem2 = myStack.Pop();
            Console.WriteLine("Item popped: {0}", whichItem2);
        }
    }
}
