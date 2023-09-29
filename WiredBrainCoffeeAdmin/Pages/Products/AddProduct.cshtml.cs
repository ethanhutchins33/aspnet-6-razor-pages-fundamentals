﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffeeAdmin.Data.Models;

namespace WiredBrainCoffeeAdmin.Pages.Products;

public class AddProduct : PageModel
{
    public Product? NewProduct { get; set; }

    public void OnGet()
    {
    }
}
