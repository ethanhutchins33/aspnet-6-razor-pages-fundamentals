using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffeeAdmin.Data.Models;

namespace WiredBrainCoffeeAdmin.Pages.Products;

public class AddProduct : PageModel
{
    [BindProperty] public Product? NewProduct { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        // TODO: Save product to database
        var productName = NewProduct!.Name;
        return RedirectToPage("ViewAllProducts");
    }
}
