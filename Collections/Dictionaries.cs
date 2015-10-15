using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms
{
    class Dictionaries
    {
        Dictionary<string, string> capitals = new Dictionary<string, string>();

        public void AddCapitals()
        {
            capitals.Add("Alabama", "Montgomery");
            capitals.Add("Alaska", "Juneau");
            capitals.Add("Arizona", "Phoenix");
            capitals.Add("Kentucky", "Frankfort");
            capitals.Add("Montana", "Helena");
        }

        public void PrintSingleCapital(string state)
        {
            Console.WriteLine(capitals[state]);
        }

        public void PrintAllCapitals()
        {
            foreach(KeyValuePair<string,string> entry in capitals )
            {
                Console.WriteLine(entry.Value);
            }
        }
    }
}
