﻿using Bugeto_Store.Application.Interfaces.Contexts;
using Bugeto_Store.Common;

namespace Bugeto_Store.Application.Service.Users.commands.UserSatusChange
{
    public class UserSatusChangeService : IUserSatusChangeService
    {
        private readonly IDataBaseContext _context;


        public UserSatusChangeService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long UserId)
        {
            var user = _context.Users.Find(UserId);
            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کاربر یافت نشد"
                };
            }

            user.IsActive = !user.IsActive;
            _context.SaveChanges();
            string userstate = user.IsActive == true ? "فعال" : "غیر فعال";
            return new ResultDto()
            {
                IsSuccess = true,
                Message = $"کاربر با موفقیت {userstate} شد!",
            };

        }
    }
}
