using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms.Dynamic
{
    class Expando
    {
        dynamic expando = new ExpandoObject();

        public void SetAndSpeakExpando()
        {
            expando.Name = "Scott";
            expando.Speak = new Action(() => Console.WriteLine(expando.Name));

            foreach(var member in expando)
            {
                Console.WriteLine("Key: " + member.Key);
            }

            expando.Speak();
        }

    }
}
