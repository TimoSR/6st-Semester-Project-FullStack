using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class RegisterDto
    {
        public string DisplayName { get; set; }
        public int Email { get; set; }
        public int Password { get; set; }
        public int Username { get; set; }
    }
}