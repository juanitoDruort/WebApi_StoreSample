using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto
{
    public class DtoSalesDatePrediction
    {
        public int custid { get; set; }
        public string customername { get; set; }
        public DateTime lastorderdate { get; set; }
        public DateTime nextpredictedorder { get; set; }
    }
}
