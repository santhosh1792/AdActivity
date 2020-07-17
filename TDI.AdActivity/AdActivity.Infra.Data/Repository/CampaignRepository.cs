using AdActivity.Domain.Interfaces;
using AdActivity.Domain.Models;
using AdActivity.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Infra.Data.Repository
{
    public class CampaignRepository : ICampaignRepository
    {
        private AdActivityDBContext _context;

        public CampaignRepository(AdActivityDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Campaign> GetCampaigns()
        {
            return _context.Campaigns.Include(a => a.Brand).Include(a => a.FundingType);
        }
    }
}
