using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
    public class UserForRegisterDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}
