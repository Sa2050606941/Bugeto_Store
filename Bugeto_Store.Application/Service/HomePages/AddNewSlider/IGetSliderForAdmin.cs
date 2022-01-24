using Bugeto_Store.Application.Interfaces.Contexts;
using Bugeto_Store.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugeto_Store.Application.Service.HomePages.AddNewSlider
{
   public interface IGetSliderForAdmin
    {
        ResultDto<List<GetImageIdDto>> Execute();
    }

    public class GetSliderForAdminServices : IGetSliderForAdmin
    {
        private readonly IDataBaseContext _context;
        public GetSliderForAdminServices(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultDto<List<GetImageIdDto>> Execute()
        {
            var imagesId = _context.Sliders
                .Include(p => p.Id)
                .Where(p => p.Id != null)
                .ToList()
                .Select(p => new GetImageIdDto
                {
                    Id = p.Id,
                }).ToList();

            return new ResultDto<List<GetImageIdDto>>()
            {
                Data = imagesId,
                IsSuccess = true,
            };

                
               
        }
    }

    public class GetImageIdDto
    {
        public long Id { get; set; }
    }
}