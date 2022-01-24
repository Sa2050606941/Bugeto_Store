using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bugeto_Store.Application.Services.Common.Queries.GetHomePageImages;
using Bugeto_Store.Application.Services.HomePages.AddHomePageImages;
using Bugeto_Store.Domain.Entities.HomePages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomePageImagesController : Controller
    {
        private readonly IAddHomePageImagesService _addHomePageImagesService;
        private readonly IGetHomePageImagesService _getHomePageImagesService;
        public HomePageImagesController(IAddHomePageImagesService addHomePageImagesService
            , IGetHomePageImagesService getHomePageImagesService)
        {
            _addHomePageImagesService = addHomePageImagesService;
            _getHomePageImagesService = getHomePageImagesService;

        }
        public IActionResult Index()
        {
            return View(_getHomePageImagesService.Execute().Data);
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(IFormFile file, string link , ImageLocation imageLocation)
        {
            _addHomePageImagesService.Execute(new requestAddHomePageImagesDto
            {
                file = file,
                ImageLocation = imageLocation,
                Link = link,
            });
            return View();
        }

    }
}
