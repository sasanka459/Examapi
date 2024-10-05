using QnaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnaDAL.DAL_Abstraction
{
    public interface IuserDAL
    {
         public IEnumerable<User> GetUser();
    }
}
