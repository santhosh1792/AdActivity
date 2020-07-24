using AdActivity.Application.ViewModels;
using AdActivity.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Campaign, CampaignViewModel>();
        }
    }
}
