using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace CSharpParadigms.LINQ
{
    class LambdaFilter
    {
        IEnumerable<string> cities = new[] { "Louisville", "Helena", "Los Angeles", "Madison", "Austin" };


        public void QueryCities()
        {
            //IEnumerable<string> query = 
            //    cities.Filter(delegate (string item)
            //        {
            //            return item.StartsWith("L");
            //        });

            //Lambda Expression is a shorthand for providing the same anonymous delegate, like above
            IEnumerable<string> query =
                cities.Filter((item) => item.StartsWith("L"));


            foreach (string city in query)
            {
                Console.WriteLine(city);
            }
        }

        //See above, the anonymous delegate accomplished this
        //static bool StringsThatStartWithL(string s)
        //{
        //    return s.StartsWith("L");
        //}
    }
}

namespace Utils
{
    public static class FilterByInputExtensions
    {

        public static IEnumerable<T> Filter<T> (this IEnumerable<T> input,
            FilterDelegate<T> predicate)
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

    public delegate bool FilterDelegate<T>(T item);

}
