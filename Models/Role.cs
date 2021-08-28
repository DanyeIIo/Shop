using System;
using System.Collections.Generic;

#nullable disable

namespace AwesomeShop.Api.Models
{
    public class Role
    {

        public int Id { get; set; }
        public string RoleName { get; set; }

        public List<User> Members { get; set; }
    }
}
