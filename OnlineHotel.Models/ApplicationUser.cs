﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHotel.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
       public string Name { get; set; }
        public string? City { get; set; }

        public string? PinCode { get; set; }
    }
}
