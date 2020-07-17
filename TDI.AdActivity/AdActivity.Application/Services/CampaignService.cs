using AdActivity.Application.Interfaces;
using AdActivity.Application.ViewModels;
using AdActivity.Domain.Commands;
using AdActivity.Domain.Core.Bus;
using AdActivity.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Application.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly ICampaignRepository _campaignRepository;
        private readonly IMediatorHandler _bus; 

        public CampaignService(ICampaignRepository campaignRepository, IMediatorHandler bus)
        {
            _campaignRepository = campaignRepository;
            _bus = bus;
        }

        public void Create(CampaignViewModel campaignViewModel)
        {
            var createCampaignCommand = new CreateCampaignCommand(
                campaignViewModel.CAMName, 
                campaignViewModel.CAMDesc,
                campaignViewModel.BRNId,
                campaignViewModel.FundingTypeId,
                campaignViewModel.ActiveStatus,
                campaignViewModel.IsPlaceholder,
                campaignViewModel.AddDate
                );
            _bus.SendCommand(createCampaignCommand);
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
