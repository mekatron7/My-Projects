﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership.UI.Models.Identity
{
    public class CarDealershipDbContext : IdentityDbContext<AppUser>
    {
        public CarDealershipDbContext() : base("DealershipDB")
        {

        }
    }
}