using AdActivity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Application.ViewModels
{
    public class CampaignViewModel
    {
        public IEnumerable<Campaign> Campaigns { get; set; }
    }
}
