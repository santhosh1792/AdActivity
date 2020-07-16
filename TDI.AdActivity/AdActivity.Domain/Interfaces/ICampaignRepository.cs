using AdActivity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Domain.Interfaces
{
    public interface ICampaignRepository
    {
        IEnumerable<Campaign> GetCampaigns();
    }
}
