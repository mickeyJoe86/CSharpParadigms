using CSharpParadigms.Dynamic;
using CSharpParadigms.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExecuteCollectionMethods();
            //ExecuteLINQMethods();
            ExecuteDynamicMethods();

            Console.ReadLine();
        }

        private static void ExecuteDynamicMethods()
        {
            //DynamicTutorial.WriteDynamic();
            //DynamicTutorial.CallExpando();
            DynamicTutorial.ParseXML();
        }

        private static void ExecuteLINQMethods()
        {
            LINQTutorial.PrintExtension();
            LINQTutorial.PrintFilter();
            LINQTutorial.PrintFuncFilter();
        }

        private static void ExecuteCollectionMethods()
        {
            Collections.ExecuteArrays();
            Collections.ExecuteLists();
            Collections.ExecuteQueue();
            Collections.ExecuteStack();
            Collections.ExecuteDictionaries();
            Collections.PrintStateCapital();
        }
    }
}
