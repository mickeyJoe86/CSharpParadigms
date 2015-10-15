using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms
{
    class Arrays
    {

        string[] Authors = new String[3];

        public void PrintArray ()
        {
            Authors[0] = "Melville";
            Authors[1] = "Donne";
            Authors[2] = "Locke";

            Array.Sort(Authors);

            foreach (string author in Authors)
            {
                Console.WriteLine(author);
            }            
        }
    }
}
