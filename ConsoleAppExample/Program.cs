using Common;
using MySpecialDomainNamespace;
using System;

namespace ConsoleAppExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new PurchaseOrder
            {
                BillTo = new USAddress
                {
                    country = "NL",
                    name = "test",
                    zip = 55656
                }
            };

            string s = XmlConverter.SerializeObject(p);
            Console.WriteLine(s);

            var p2 = XmlConverter.DeserializeObject<PurchaseOrder>(s);

            string s2 = XmlConverter.SerializeObject(p2);
            Console.WriteLine(s2);
        }
    }
}
