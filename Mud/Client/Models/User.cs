using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mud.Client.Models
{
    public class User
    {
        public string Name { get; set; }

        public string Username { get; set; }
        public string Rol { get; set; }

        public int? RolId { get; set; }

        public string Email { get; set; }

    }
}
