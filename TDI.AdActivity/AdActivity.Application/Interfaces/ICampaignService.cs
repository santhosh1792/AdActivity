using AdActivity.Application.ViewModels;
using AdActivity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Application.Interfaces
{
    public interface ICampaignService
    {
        IEnumerable<CampaignViewModel> GetCampaigns();
    }
}
