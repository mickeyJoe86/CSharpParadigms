using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms.Delegates
{
    class Document
    {
        public string Message { get; set; }

        public delegate int SendDoc();

        public void SendingResults(SendDoc sendReport)
        {
            if(sendReport() == 1)
            {
                Console.WriteLine("Sending Report");
            }
            else
            {
                Console.WriteLine("Sending Failed");
            }
        }
    }
}
