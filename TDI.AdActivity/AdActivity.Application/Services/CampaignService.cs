using AdActivity.Application.Interfaces;
using AdActivity.Application.ViewModels;
using AdActivity.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Application.Services
{
    public class CampaignService : ICampaignService
    {
        private ICampaignRepository _campaignRepository;

        public CampaignService(ICampaignRepository campaignRepository)
        {
            _campaignRepository = campaignRepository;
        }
        public CampaignViewModel GetCampaigns()
        {
            return new CampaignViewModel()
            {
                Campaigns = _campaignRepository.GetCampaigns()
            };
        }
    }
}
