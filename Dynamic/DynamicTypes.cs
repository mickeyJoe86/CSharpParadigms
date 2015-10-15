using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms.Dynamic
{
    class DynamicTypes
    {
        public string FirstName { get; set; }

        public void Speak()
        {
            Console.WriteLine("Hi, my name is {0}", FirstName);
        }

    }

    class Setter
    {
        public static void SetSpeaker()
        {
            //dynamic type turns off all type checking
            //missing members, etc will compile, but will throw runtime error
            dynamic o = GetASpeaker();
            o.Speak();
        }

        private static object GetASpeaker()
        {
            return new DynamicTypes { FirstName = "Mike" };
        }
    }

}
