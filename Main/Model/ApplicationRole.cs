﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Model
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() { }

        public ApplicationRole(string nameRole)
        {
            this.Name = nameRole;
        }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
