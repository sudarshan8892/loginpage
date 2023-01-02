using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace loginPage.Areas.Identity.Data;

// Add profile data for application users by adding properties to the loginPageUser class
public class loginPageUser : IdentityUser
{
    public string fristName { get; set; }
    public string LastName { get; set; }
    public long PhoneNumber { get; set; }
}

