using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpParadigms.Dynamic
{
    public static class ParseXMLWithExpando
    {
        public static void ParseEmployees()
        {
            var doc = XDocument.Load("Employees.xml");
            foreach(var element in doc.Element("Employees").Elements("Employee"))
            {
                Console.WriteLine(element.Element("FirstName").Value);
            }

            //If you write extension method 
            //Can turn data into an object at runtime
            //var doc2 = XDocument.Load("Employees.xml").AsExpando();
            //foreach(var employee in doc2.Employees)
            //{
            //    Console.WriteLine(employee.FirstName);
            //}
        }
    }
}
