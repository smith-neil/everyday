using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Everyday.Web.Models
{
    public class User : IdentityUser<int>
    {
        public ICollection<Task> Tasks { get; set; }
    }
}