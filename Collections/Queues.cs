using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms
{
    class Queues
    {
        Queue<int> myQueue = new Queue<int>();

        public void AddtoQueue()
        {
            for (int i = 0; i < 50; i++)
            {
                myQueue.Enqueue(i);
            }
            
        }

        public void ReturnCustomers()
        {
            foreach (var item in myQueue)
            {
                Console.WriteLine("{0}", item);

            }
            var whichItem = myQueue.Dequeue();
            Console.WriteLine("Which item is dequeued: {0}", whichItem);
            var whichItem2 = myQueue.Dequeue();
            Console.WriteLine("Which item is dequeued: {0}", whichItem2);
        }
    }
}
