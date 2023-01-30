﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Entities.Concrete
{
    public class User :IdentityUser<int>
    {
        public string Name { get; set; }

        [NotMapped]
        public string[] Roller { get; set; }
    }
}
