using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Domain.Commands
{
    public class CreateCampaignCommand:CampaignCommand
    {
        public CreateCampaignCommand(string name, string description, int brnId,int fundingTypeId, string status, string isPlaceHolder, DateTime addDate)
        {
            CAMName = name;
            CAMDesc = description;
            BRNId = brnId;
            FundingTypeId = fundingTypeId;
            ActiveStatus = status;
            IsPlaceholder = isPlaceHolder;
            AddDate = addDate;
        }
    }
}
