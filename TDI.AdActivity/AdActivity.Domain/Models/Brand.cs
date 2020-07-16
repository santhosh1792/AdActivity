using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Domain.Models
{
    public class Brand
    {
        public int BRNId { get; set; }
        public string BRNType { get; set; }
        public DateTime BRNEffectDate { get; set; }
        public DateTime BRNEndDate { get; set; }
    }
}
