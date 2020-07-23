using AdActivity.Domain.Commands;
using AdActivity.Domain.Interfaces;
using AdActivity.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdActivity.Domain.CommandHandlers
{
    public class CampaignCommandHandler : IRequestHandler<CreateCampaignCommand, bool>
    {
        private readonly ICampaignRepository _campaignRepository;

        public CampaignCommandHandler(ICampaignRepository campaignRepository)
        {
            _campaignRepository = campaignRepository;
        }
        public Task<bool> Handle(CreateCampaignCommand request, CancellationToken cancellationToken)
        {
            var campaign = new Campaign()
            {
                CAMName = request.CAMName,
                CAMDesc = request.CAMDesc,
                BRNId = request.BRNId,
                FundingTypeId = request.FundingTypeId,
                ActiveStatus = request.ActiveStatus,
                IsPlaceholder = request.IsPlaceholder,
                AddDate = DateTime.Now
            };

            //Business Logic
            _campaignRepository.Add(campaign);

            return Task.FromResult(true);
        }
    }
}
