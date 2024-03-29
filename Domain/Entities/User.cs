using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Domain.Entities
{
    public class User:EntityBase
    {

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; } = null!;

        public ICollection<Order> Orders { get; } = new List<Order>();
        
    }
}