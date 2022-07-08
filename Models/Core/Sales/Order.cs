using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Core.Sales
{
    public class Order
    {
        public int orderid { get; set; }
        public string custid { get; set; }
        public string empid { get; set; }
        public string orderdate { get; set; }
        public string requireddate { get; set; }
        public string shippeddate { get; set; }
        public string shipperid { get; set; }
        public string freight { get; set; }
        public string shipname { get; set; }
        public string shipaddress { get; set; }
        public string shipcity { get; set; }
        public string shipregion { get; set; }
        public string shippostalcode { get; set; }
        public string shipcountry { get; set; }
    }
}
