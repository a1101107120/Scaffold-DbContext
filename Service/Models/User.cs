using System;
using System.Collections.Generic;

namespace Service.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public int UserInfoId { get; set; }

        public UserInfo UserInfo { get; set; }
    }
}
