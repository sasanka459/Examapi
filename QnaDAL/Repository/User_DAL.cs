using QnaDAL.DAL_Abstraction;
using QnaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnaDAL.Repository
{
    public class User_DAL:IuserDAL
    {
        private readonly QnaContext _context;
        public User_DAL(QnaContext qnaContext)
        {
            _context = qnaContext;
        }
        public IEnumerable<User> GetUser()
        {
            return _context.Users.ToList();
        }
    }
}
