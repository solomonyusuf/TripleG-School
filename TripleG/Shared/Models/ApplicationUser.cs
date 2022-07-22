using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripleG.Shared.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ImgPath { get; set; }
        public string Role { get; set; }


    }

    public class User
    {
        public string Sub { get; set; }

    }
}
