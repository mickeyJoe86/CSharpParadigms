using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParadigms.Delegates
{
    class DelegateRepo
    {
        public static void SendMailAlert()
        {
            var doc = new Document();
            
            var emailSender = new EmailSender();
            var blogDelegate = new Document.SendDoc(emailSender.SendMail);
            doc.SendingResults(blogDelegate);

            var blogPoster = new BlogPoster();
            var blogPostDelegate = new Document.SendDoc(blogPoster.PostBlog);
            doc.SendingResults(blogPostDelegate);
        }

    }
}
