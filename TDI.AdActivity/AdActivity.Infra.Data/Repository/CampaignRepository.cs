using AdActivity.Domain.Interfaces;
using AdActivity.Domain.Models;
using AdActivity.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Add(Campaign campaign)
        {
            _context.Campaigns.Add(campaign);
            _context.SaveChanges();
        }

        public IQueryable<Campaign> GetCampaigns()
        {
            return _context.Campaigns;
        }
    }
}
