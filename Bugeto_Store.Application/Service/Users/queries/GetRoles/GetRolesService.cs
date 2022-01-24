using Bugeto_Store.Application.Interfaces.Contexts;
using Bugeto_Store.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bugeto_Store.Application.Service.Users.queries.GetRoles
{
    public class GetRolesService : IGetRolesService
    {
           private readonly IDataBaseContext _context;
        public GetRolesService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<RolesDto>> Execute()
        {
            var roles = _context.Roles.ToList().Select(p => new RolesDto
            {
                Id = p.Id,
                Name = p.Name,

            }).ToList();

            return new ResultDto<List<RolesDto>>()
            {
                Data = roles,
                IsSuccess = true,
                Message = "  "
            };
        }

    }



}

