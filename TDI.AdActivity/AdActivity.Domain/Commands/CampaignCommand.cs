using AdActivity.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Domain.Commands
{
    public abstract class CampaignCommand: Command
    {
        public string CAMName { get; protected set; }
        public string CAMDesc { get; protected set; }
        public int BRNId { get; protected set; }
        public int FundingTypeId { get; protected set; }
        public string ActiveStatus { get; protected set; }
        public bool IsPlaceholder { get; protected set; }
        public DateTime AddDate { get; protected set; }
    }
}
