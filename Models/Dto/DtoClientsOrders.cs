using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto
{
    public class DtoClientsOrders
    {
        public int orderid { get; set; }
        public string requireddate { get; set; }
        public string Shippeddate { get; set; }
        public string shipname { get; set; }
        public string shipaddress { get; set; }
        public string Shipcity { get; set; }
    }
}
