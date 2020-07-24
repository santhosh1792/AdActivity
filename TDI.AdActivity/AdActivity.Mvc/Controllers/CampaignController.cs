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
            return View(_campaignService.GetCampaigns());
        }

        [HttpGet]
        public IActionResult CreateCampaign()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCampaign(CampaignViewModel campaignViewModel)
        {
            _campaignService.Create(campaignViewModel);
            return RedirectToAction("Index");
        }

        public PartialViewResult AdminPrivilages()
        {
            return PartialView("_adminPrivilege");
        }
    }
}
