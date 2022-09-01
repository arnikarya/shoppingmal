using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ShoppingWebApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ShoppingWebAppUser class
public class ShoppingWebAppUser : IdentityUser
{
    public string PANnumber { get; set; }
}

