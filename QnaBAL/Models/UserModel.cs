﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnaBAL.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        public string Username { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string MobileNo { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }
    }
}
