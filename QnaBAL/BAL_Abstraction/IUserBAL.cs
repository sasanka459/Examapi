using QnaBAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnaBAL.BAL_Abstraction
{
    public interface IUserBAL
    {
        public IEnumerable<UserModel> GetUser();
    }
}
