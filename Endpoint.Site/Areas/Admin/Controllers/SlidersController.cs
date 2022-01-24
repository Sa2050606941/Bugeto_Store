using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bugeto_Store.Application.Service.HomePages.AddNewSlider;
using Bugeto_Store.Application.Services.HomePages.AddNewSlider;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.Admin.Controllers
{
   [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly IAddNewSliderService _addNewSliderService;
        private readonly IGetSliderForAdmin _getSliderForAdmin;

        public SlidersController(IAddNewSliderService addNewSliderService
            , IGetSliderForAdmin getSliderForAdmin)
        {
            _addNewSliderService = addNewSliderService;
            _getSliderForAdmin = getSliderForAdmin;
        }
        public IActionResult Index()
        {
            return View(_getSliderForAdmin.Execute().Data);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(IFormFile file , string link)
        {
            _addNewSliderService.Execute(file, link);
            return View();
        }
    }
}
