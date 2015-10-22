using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms.Delegates
{
    public class EmailSender
    {
        public int SendResult { get; set; }
        public int SendMail()
        {
            Console.WriteLine("Sending Email");
            SendResult = 1;
            return SendResult;
        }

    }
}
