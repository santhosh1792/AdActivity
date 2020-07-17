using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdActivity.Application.Interfaces;
using AdActivity.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AdActivity.Mvc.Controllers
{
    public class CampaignController : Controller
    {
        private ICampaignService _campaignService;

        public CampaignController(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public IActionResult Index()
        {
            CampaignViewModel model = _campaignService.GetCampaigns();
            return View(model);
        }
    }
}
