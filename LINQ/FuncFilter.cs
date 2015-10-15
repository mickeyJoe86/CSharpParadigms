using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace CSharpParadigms.LINQ
{
    class FuncFilter
    {
        IEnumerable<string> cities = new[] { "Louisville", "Helena", "Los Angeles", "Madison", "Austin" };
        
        public void QueryCities()
        {
            IEnumerable<string> query =
                cities.Filter( city => city.StartsWith("L"))
                      .OrderByDescending(city => city.Length);
            
            foreach (string city in query)
            {
                Console.WriteLine(city);
            }
        }
    }
}

namespace Utils
{
    public static class FilterByFuncExtensions
    {
        //Replaced the delegate with the Func<T> delegate syntax creates anonymous delegate parameter
        public static IEnumerable<T> FilterFunc<T>(this IEnumerable<T> input,
            Func<T, bool> predicate)
        {
            foreach (var item in input)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}


