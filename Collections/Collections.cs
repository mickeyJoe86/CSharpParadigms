using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms
{
    public static class Collections
    {
        public static void PrintStateCapital()
        {
            var theStates = State.GetStates();
            string capitalOfAlaska = theStates["Alaska"].Capital;
            Console.WriteLine("The capital of Alaska is: {0}", capitalOfAlaska);
        }

        public static void ExecuteDictionaries()
        {
            Dictionaries myDictionary = new Dictionaries();
            myDictionary.AddCapitals();
            myDictionary.PrintSingleCapital("Montana");
            myDictionary.PrintAllCapitals();
        }

        public static void ExecuteStack()
        {
            Stacks myStack = new Stacks();
            myStack.AddtoStack();
            myStack.PrintStack();
        }

        public static void ExecuteQueue()
        {
            Queues myQueue = new Queues();
            myQueue.AddtoQueue();
            myQueue.ReturnCustomers();
        }

        public static void ExecuteArrays()
        {
            Arrays myArray = new Arrays();
            myArray.PrintArray();
        }

        public static void ExecuteLists()
        {
            Lists newList = new Lists();
            newList.AddNumber(1);
            newList.AddNumber(2);
            newList.AddNumber(3);
            newList.AddNumber(4);
            newList.PrintList();
        }
    }
}
