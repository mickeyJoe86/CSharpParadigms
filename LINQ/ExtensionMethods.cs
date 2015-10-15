using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace CSharpParadigms.LINQ
{
    public class ExtensionMethods
    {
        IEnumerable<string> cities = new[] { "Louisville", "Helena", "Los Angeles", "Madison", "Austin" };


        public void QueryCities()
        {
            IEnumerable<string> query = cities.StringsThatStartWith("L");
            
            foreach(string city in query)
            {
                Console.WriteLine(city);
            }
        }        
    }
}


namespace Utils
{
    public static class FilterExtensions
    {
        //NOTE: the 'this' keyword in the passed as a parameter.  Allows an easier syntax an looks like there is
        //a method called StringsThatStartWith on IEnumerable<string>
        //How LINQ operators are defined
        public static IEnumerable<string> StringsThatStartWith(this IEnumerable<string> input, string startLetter)
        {
            foreach (var s in input)
            {
                if(s.StartsWith(startLetter))
                {
                    yield return s;
                }
            }
        }
    }
}
