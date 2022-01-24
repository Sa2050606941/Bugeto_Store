using Bugeto_Store.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugeto_Store.Application.Service.Users.commands.UserSatusChange
{
   public interface IUserSatusChangeService
    {
        ResultDto Execute(long UserId);
    }
}
