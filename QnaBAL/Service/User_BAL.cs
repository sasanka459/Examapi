using QnaBAL.BAL_Abstraction;
using QnaBAL.Models;
using QnaDAL.DAL_Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnaBAL.Service
{
    public class User_BAL: IUserBAL
    {
        private readonly IuserDAL _userDAL;
        public User_BAL(IuserDAL iuserDAL)
        {
            _userDAL = iuserDAL;
        }

        public IEnumerable<UserModel> GetUser()
        {
            var users = _userDAL.GetUser();
            return users.Select(x => new UserModel
            {
                UserId = x.UserId,
                Username = x.Username,
                PasswordHash = x.PasswordHash,
                MobileNo = x.MobileNo,
                CreatedAt = x.CreatedAt,
                Email = x.Email
            });

        }
    }
}
