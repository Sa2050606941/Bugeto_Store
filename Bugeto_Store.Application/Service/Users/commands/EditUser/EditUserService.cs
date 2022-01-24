using Bugeto_Store.Application.Interfaces.Contexts;
using Bugeto_Store.Common;

namespace Bugeto_Store.Application.Service.Users.commands.EditUser
{
    public class EditUserService : IEditUserService
    {
        private readonly IDataBaseContext _context;

        public EditUserService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestEdituserDto request)
        {
            var user = _context.Users.Find(request.UserId);
            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کاربر یافت نشد"
                };
            }

            user.FullName = request.Fullname;
            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "ویرایش کاربر انجام شد"
            };
        }
    }


    public class RequestEdituserDto
    {
        public long UserId { get; set; }
        public string Fullname { get; set; }
    }
}
