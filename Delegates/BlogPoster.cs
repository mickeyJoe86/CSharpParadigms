using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms.Delegates
{
    class BlogPoster
    {
        public int SendResults { get; set; }

        public int PostBlog()
        {
            Console.WriteLine("Posting Blog");
            SendResults = 1;
            return SendResults;
        }

    }
}
