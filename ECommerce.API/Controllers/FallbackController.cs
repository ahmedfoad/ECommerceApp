﻿using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers;

public class FallbackController : Controller
{
    public IActionResult Index()
    {
        return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), 
            "wwwroot", "index.html"), "text/HTML");
    }
}
