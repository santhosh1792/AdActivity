using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Domain.Models
{
    public class Campaign
    {
        public int CAMId { get; set; }
        public string CAMName { get; set; }
        public string CAMDesc { get; set; }
        public int BRNId { get; set; }
        public int FundingTypeId { get; set; }
        public string ActiveStatus { get; set; }
        public string IsPlaceholder { get; set; }
        public DateTime AddDate { get; set; }
    }
}
