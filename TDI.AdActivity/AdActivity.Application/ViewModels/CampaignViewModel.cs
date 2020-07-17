using AdActivity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Application.ViewModels
{
    public class CampaignViewModel
    {
        public string CAMName { get; set; }
        public string CAMDesc { get; set; }
        public int BRNId { get; set; }
        public int FundingTypeId { get; set; }
        public string ActiveStatus { get; set; }
        public string IsPlaceholder { get; set; }
        public DateTime AddDate { get; set; }
        public IEnumerable<Campaign> Campaigns { get; set; }
    }
}
