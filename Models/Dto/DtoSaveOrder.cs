using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto
{
    public class DtoSaveOrder
    {
        public int orderid { get; set; }
        public int custid { get; set; }
        public int empid { get; set; }
        public int shipperid { get; set; }
        public string shipname { get; set; }
        public string shipaddress { get; set; }
        public string shipcity { get; set; }
        public DateTime orderdate { get; set; }
        public DateTime requireddate { get; set; }
        public DateTime shippeddate { get; set; }
        public decimal freight { get; set; }
        public string shipcountry { get; set; }
        public int productid { get; set; }
        public decimal unitprice { get; set; }
        public int qty { get; set; }
        public decimal discount { get; set; }
    }
}
