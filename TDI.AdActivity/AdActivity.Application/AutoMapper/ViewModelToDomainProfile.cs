using AdActivity.Application.ViewModels;
using AdActivity.Domain.Commands;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CampaignViewModel, CreateCampaignCommand>()
                .ConstructUsing(c => new CreateCampaignCommand(c.CAMName, c.CAMDesc, c.BRNId, c.FundingTypeId, c.ActiveStatus, c.IsPlaceholder, c.AddDate));
        }
    }
}
