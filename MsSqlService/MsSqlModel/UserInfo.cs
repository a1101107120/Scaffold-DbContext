using System;
using System.Collections.Generic;

namespace MsSqlService.Model
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public ICollection<User> User { get; set; }
    }
}
