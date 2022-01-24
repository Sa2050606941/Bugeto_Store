using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Bugeto_Store.Application.Service.Users.queries.GetUsers.GetUsersService;

namespace Bugeto_Store.Application.Service.Users.queries.GetUsers
{
    public interface IGetUsersService
    {
        ResultGetUserDto Execute(RequestGetUserDto request);
    }

}
