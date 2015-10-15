using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms.LINQ
{
    public static class LINQTutorial
    {
        public static void PrintExtension()
        {
            ExtensionMethods cityExtention = new ExtensionMethods();
            cityExtention.QueryCities();
        }

        public static void PrintFilter()
        {
            LambdaFilter lambdaFilter = new LambdaFilter();
            lambdaFilter.QueryCities();
        }

        public static void PrintFuncFilter()
        {
            FuncFilter funcFilter = new FuncFilter();
            funcFilter.QueryCities();
        }
       
    }
}
