﻿using Microsoft.AspNetCore.Identity;

namespace ECommerce.Core.Entities;

public class AppUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Address? Address { get; set; }
}
