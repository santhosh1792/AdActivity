using AdActivity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdActivity.Domain.Interfaces
{
    public interface ICampaignRepository
    {
        IQueryable<Campaign> GetCampaigns();
        void Add(Campaign campaign);
    }
}
