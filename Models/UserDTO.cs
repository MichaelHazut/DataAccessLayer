using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class UserDTO
    {
        public required string Id { get; set; } 
        public required string Name { get; set; } 
        public required string Email { get; set; }
        public required AuthenticationLevel AuthenticationLevel { get; set; }

    }
}
