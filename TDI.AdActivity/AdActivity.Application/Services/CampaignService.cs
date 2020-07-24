using AdActivity.Application.Interfaces;
using AdActivity.Application.ViewModels;
using AdActivity.Domain.Commands;
using AdActivity.Domain.Core.Bus;
using AdActivity.Domain.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _autoMapper;

        public CampaignService(ICampaignRepository campaignRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _campaignRepository = campaignRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(CampaignViewModel campaignViewModel)
        {
            //var createCampaignCommand = new CreateCampaignCommand(
            //    campaignViewModel.CAMName, 
            //    campaignViewModel.CAMDesc,
            //    campaignViewModel.BRNId,
            //    campaignViewModel.FundingTypeId,
            //    campaignViewModel.ActiveStatus,
            //    campaignViewModel.IsPlaceholder,
            //    campaignViewModel.AddDate
            //    );

            _bus.SendCommand(_autoMapper.Map<CreateCampaignCommand>(campaignViewModel));
        }

        public IEnumerable<CampaignViewModel> GetCampaigns()
        {
            //return new CampaignViewModel()
            //{
            //    Campaigns = _campaignRepository.GetCampaigns()
            //};

            return _campaignRepository.GetCampaigns().ProjectTo<CampaignViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
