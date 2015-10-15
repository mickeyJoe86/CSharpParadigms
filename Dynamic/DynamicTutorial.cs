using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms.Dynamic
{
    public static class DynamicTutorial
    {
        public static void WriteDynamic()
        {
            Setter.SetSpeaker();
        }

        public static void CallExpando()
        {
            Expando expando = new Expando();
            expando.SetAndSpeakExpando();
        }

        public static void ParseXML()
        {
            ParseXMLWithExpando.ParseEmployees();
        }
    }
}
